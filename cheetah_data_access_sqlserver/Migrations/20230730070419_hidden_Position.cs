using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class hidden_Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5209), new Guid("7bc19135-6878-4748-9c10-0541f059aaaa"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5213), new Guid("defc3059-4519-4e06-b905-115859c07c6b"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5217), new Guid("fb408204-56be-4da2-b9db-becda4de40d9"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5219), new Guid("0aa5cc66-8944-4d46-8aa5-e5e99a498b1d"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5612), new Guid("64dce63f-cc9e-41f3-8f82-0625c336b97c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5691), new Guid("56d63a52-a944-4777-aa9d-0fb7ec85024a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5699), new Guid("dfe12bdd-a6fb-4ddf-98a0-efd3ea48531d"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5704), new Guid("b082c262-33cf-4c61-aa4a-1848665c3276"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5710), false, new Guid("2b2fc83c-05d3-4b8e-a843-c702991cc6e8"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5715), new Guid("d8a23641-84d9-4d93-9819-aac861857afb"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5722), new Guid("5932b9dd-2f19-49f5-9406-257af2345aaf"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5727), new Guid("eaef989b-c79b-48d4-9225-29473f175c96"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5733), new Guid("2ce35b19-9535-4e2a-a234-57966256b13e"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5739), new Guid("e287fa19-c39c-4ad5-8793-3e021a71db2e"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5747), new Guid("533f7f1c-c23c-41ab-a62f-f72e345ebdd8"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5756), new Guid("7d1b6031-5891-4c2b-9cf7-295933756f3f"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5763), new Guid("98c20a17-4574-4c6b-8e79-36711822acd9"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5771), new Guid("7c447596-30e9-4b78-859e-d98dddd409e1"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5777), false, new Guid("b01ddb02-b016-413c-9e50-4f885341f9d3"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5783), new Guid("ddb5d041-f542-462b-9116-b4bad4e6f931"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5788), new Guid("56d743a7-21f2-46d8-85cf-e46d3fc660d6"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5793), new Guid("fb2a4d14-094f-4cd3-9f7d-76b15b810a46"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5798), new Guid("f7913d05-be71-4aaa-8e51-9ea5e47f4795"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5802), new Guid("cb85ea49-9412-46e4-80d6-c3bdff0cd13d"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5282), new Guid("0082a543-68d7-46ad-b371-3280d4482036"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5290), new Guid("47189af1-3187-420c-9439-66b9e84852ef"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5292), new Guid("517790be-82bc-4117-aa64-f0c8de638f96"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5309), new Guid("1f89af23-7e4a-4050-8a9b-3d83ef812ea3"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5312), new Guid("e18e5412-2523-49bc-a364-e877bc0e86f0"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5318), new Guid("55e4a585-891b-42f5-9a00-cadf031722b2"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5322), new Guid("2413e997-291d-458d-8d4a-a623d8f224db"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5325), new Guid("1a58c466-9633-4306-beda-d5917bc604ab"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5328), new Guid("54c1f33c-0763-4847-a010-ace8c747ff5c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5570), new Guid("361a81fe-54d8-422c-9f1a-986f1369a2de"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5573), new Guid("3066dd95-9439-474e-8484-506a351f1c5f"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5575), new Guid("ebdbbec5-f705-4a9e-8189-6a181fb6d561"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5578), new Guid("6ff5fc9c-265f-4d27-90fa-2ed859e19f93"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5580), new Guid("796e4639-8386-4707-88c9-e9671062c7e2"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5584), new Guid("7731b309-d545-4ce0-aa5f-9e492b75382f"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5589), new Guid("31789361-06d7-4cf3-ab14-640ecd8117f8"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(4994), new Guid("14c8eedd-d207-4d30-a59d-dc398c9f5bf4"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5042), new Guid("68a7eaa7-962c-4624-a5e8-7e8f21e88c9a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5045), new Guid("799a0287-6fde-491e-8d1f-606bb77e78ce"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5532), new Guid("10bfaa6d-95de-47d7-8c0f-f8f4aea25955"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5535), new Guid("fd58dd25-287a-412f-875b-dec4c83fa27f"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5537), new Guid("16bc3b4b-e653-41ae-8c04-62ecba0ec9f6"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5540), new Guid("a36cc658-8e66-47b0-95f7-195104a95432"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5544), new Guid("fb88fe24-2c18-4a24-abfb-1cfd06e9b1d3"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5547), new Guid("54df8179-acfd-4b83-b916-88f8c2e57d62"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5550), new Guid("c4d629f8-7ebc-4751-8595-7e99280f1a2a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5388), new Guid("a1e59827-9f00-4a60-b785-30d91103b854"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5392), new Guid("b26bb487-919f-4dfa-9378-d63fe05e5a2a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5395), new Guid("7b79f16f-9e8b-4171-aa0d-fe0e10dda73b"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5398), new Guid("daa88544-b9f3-4b49-b6c9-4e24009732f3"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5400), new Guid("f780ab26-81c9-4de8-8c72-526ca69b2372"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5402), new Guid("8832d09e-9d12-4057-b00b-4889fd1db2dd"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5468), new Guid("17136118-6ee8-45d0-959f-8782df80b2fd"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5472), new Guid("0789f2e8-fb6a-49b5-9bdb-9aae51dca6b4"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5478), new Guid("fac6266a-9fbb-4216-b82e-2398aa932f7d"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5480), new Guid("c8080e93-9406-4cea-aa49-a00074344e62"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5357), new Guid("cf667283-822e-49f3-9ab2-5a9be47296cb"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5362), new Guid("e86eedd7-934d-4104-9dd3-494b792b5e16"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5365), new Guid("2f532c0b-951a-4276-8787-5b0e6754655a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5369), new Guid("821fd760-164c-4d88-8fd4-d3975770b092"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5506), new Guid("9998a325-12eb-4029-a20c-1a2e5f97a124"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5509), new Guid("08992f43-84a5-4056-9772-e85d9ccac54c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5241), new Guid("9de1772f-2ae8-43d2-8b44-51d7ffb6e3ca"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5254), new Guid("7cd81dfa-1b8e-45be-bb7d-a9cabada0330"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5258), new Guid("d03a0ccf-9eb5-4439-a036-1db1d462d040"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5260), new Guid("b81ce981-c4f7-422d-96b2-b198b9a80688"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5930), new Guid("4f88c3de-46b1-41f9-bc35-eae42bbc624c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5936), new Guid("4fd549ab-5239-45b1-ba05-e13d8b49965e"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5939), new Guid("9284de01-9659-437a-b4e0-de809d5fae38"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5942), new Guid("0570b6f4-fc43-4e08-8983-390c57e98329"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5945), new Guid("52a053a6-ff0c-410d-afbb-8b55e85c6a64"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5964), new Guid("bbdee1b9-d490-4c8f-bd46-bfbbc7c3aec4"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5968), new Guid("60aa9d69-487f-402e-840c-3ee3d9a825e0"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5973), new Guid("3d8832dc-5ab8-40c1-813c-6fd2dd02e6bd"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5975), new Guid("ae42ea83-2ee5-40f5-a08d-de2fcf121b9c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5897), new Guid("ebac9bfe-93d7-4de6-b67d-07b7c02c99a8"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5901), new Guid("a395f1f4-31c7-4a47-9dfa-97b14b2a143c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5906), new Guid("fa03212b-fa3b-4f82-b459-f14be37da01b"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6107), new Guid("4eee658f-1a8d-4ee6-a69a-890f69292b7c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6111), new Guid("edb12baa-b4ef-495f-8de1-6bb7375b93e0"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6114), new Guid("7d77f432-badb-437b-b8b9-c5da40f55ca3"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6119), new Guid("191a0f88-efba-4fb2-847e-f6ba694f426a"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6122), new Guid("5215ddf3-bfc9-4849-883b-638361e4a604"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6028), new Guid("b90c4044-5b2f-450f-8e85-66df400da2e5"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6031), new Guid("148e34f7-260d-46f4-935c-02921b0f4a83"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6037), new Guid("88dedb78-d7f7-4cb1-9fc1-6376690efb81"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6040), new Guid("a94ea43e-faed-4eaf-96ec-44e0b52d55ca"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6043), new Guid("3c5eb48b-5794-4fb0-9a30-1bb4a368362d"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6046), new Guid("6c5c0813-1771-477c-a0f0-b0552f5e5112"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6049), new Guid("11e61064-f4f2-43b0-911a-fb52d52c1ee4"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6001), new Guid("0c35c8b2-c10b-48dd-96d1-a9e731fab629"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6005), new Guid("1113366b-2492-4efe-89e1-631909e7beca"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6008), new Guid("1f228434-4032-42ed-adc6-edabe2967b0c"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6010), new Guid("fb12aa20-254c-4b4a-8a3c-443db70e1451"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6146), new Guid("e7f5c716-8cf9-42ed-bf4c-6be6499973ae"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6149), new Guid("94b0a4a5-8fe0-437e-becd-63a95b5b31da"), new DateTime(2023, 7, 30, 10, 34, 18, 447, DateTimeKind.Local).AddTicks(6149) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3113), new Guid("540ba569-dc40-4773-9e39-70d0cbabace4"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3119), new Guid("5f14387a-a932-4096-8751-acd55d42135f"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3121), new Guid("54b34ddb-ff74-4b80-abca-9421a9910ea0"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3123), new Guid("33d01d51-fa3f-4777-a1d2-f2e7f6d0f8af"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3553), new Guid("13b1a8dd-8829-4d04-96ba-4be6c9de68bb"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3599), new Guid("8f51feb8-154f-4c07-820b-c0f145fd2265"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3607), new Guid("1b17177d-5626-4408-b876-8eacaf451737"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3614), new Guid("ddb4cc37-25ea-4b37-90f6-98a8774fc93d"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3619), true, new Guid("48d3c5fc-262a-47ae-a776-f89b8bca5b3b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3662), new Guid("2f05b060-ca37-4def-bd88-75e06302c857"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3669), new Guid("7e61b956-2193-43b0-91ff-dd442261c3af"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3674), new Guid("1f1ebd6e-3ea4-4c5a-a907-bf816a6b1117"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3681), new Guid("fd3aff1a-8a98-494d-8af7-24630a3bb741"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3686), new Guid("657248f3-0031-4529-bf19-cf1d502e8d2b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3692), new Guid("b608bbc4-13ba-4910-841f-12862be1c258"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3697), new Guid("8bfead73-f85b-461e-a98d-c8b457cd06f0"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3703), new Guid("6e87d885-9dfe-4bc3-a557-418c39909c4a"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3709), new Guid("62da2497-9b19-488e-80f2-6bc1ddff1801"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "Display", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3714), true, new Guid("6af06b12-ca0a-4ce3-a447-78de09196f06"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3724), new Guid("7f9605d2-d74d-41e6-bb82-d8c424518bd0"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3731), new Guid("f4748532-ce86-4f83-80ae-6c57f52dcc3a"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3736), new Guid("c8e34935-6a02-485d-b628-8c5460bf7797"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3741), new Guid("fc7a8123-994f-439a-869f-da46506c0275"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3746), new Guid("e0741698-3fbf-4883-8c1d-9c2076fbc2a9"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3197), new Guid("0fd75ed3-0e69-4108-b40a-b7ae28e5878a"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3201), new Guid("05f12800-33ab-42b1-b563-3ac56e7d516b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3204), new Guid("cb461ea2-ba35-44da-bf7f-fdc6e9c7d4e4"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3225), new Guid("91555e22-3589-4af3-9197-7223544b0fa7"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3253), new Guid("be92c45b-58dd-45e2-86ce-7be74cb066ad"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3256), new Guid("47b15cda-d066-4e47-b5c0-901979ccb7ea"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3259), new Guid("ada64c36-4d39-4f5a-840e-12ee3dd6a927"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3265), new Guid("cc86d132-dd7d-4427-92bb-b996626cd2cc"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3268), new Guid("ca22ecde-070e-4ed6-884e-bdab457e15c8"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3515), new Guid("23cb9239-23b0-4350-8599-2905c1cd964c"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3518), new Guid("564d014d-7a7a-4cb4-b2e6-3cb7b6b5d729"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3521), new Guid("04c07bc7-eb91-46fc-8f88-b512274c5d1c"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3523), new Guid("24afceff-4653-4818-9fbc-6ab500231bc2"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3526), new Guid("e2dab696-ca73-48f9-8c5f-55b5b2a94ba9"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3528), new Guid("acaaedc4-3357-4ba5-923c-f167b733cfa9"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3531), new Guid("538c0c04-71f4-456a-ac8b-5f2bb6c05b7f"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2784), new Guid("1e68115c-7f56-40a1-b3c9-63055482dbc9"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2900), new Guid("95c0fa44-6750-467e-971b-e3a5978a351c"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2920), new Guid("816e9489-248e-4e4b-a7c6-5abdd7b996a7"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3458), new Guid("09754f54-718a-4ba6-87de-68fcd83aa310"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3462), new Guid("2ed42f45-2de7-4acf-86aa-164abbd04acb"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3464), new Guid("f56e0149-064a-45b6-9ef5-825dd1c08076"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3467), new Guid("eadbad35-5946-4ed9-a85e-53b2b48ded67"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3470), new Guid("92477d9e-aa56-4552-87af-0f29c0370eb9"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3473), new Guid("13fb921b-d5df-4dcc-9789-3beb177d280d"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3478), new Guid("bb2c9435-691a-434c-81f2-22805714596c"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3326), new Guid("02d5de93-04ff-436c-ae44-999e9ed16493"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3329), new Guid("9a48f72e-26bd-40a8-9712-9ad945a19ea5"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3335), new Guid("da0a4e25-683e-4592-b401-a707dc38eb58"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3338), new Guid("516ec0cc-3a7c-40ab-936d-2d4867a92572"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3341), new Guid("519b3799-0fac-44fd-bb46-f6fc36878557"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3344), new Guid("e83fe513-431e-4541-9545-79969c61844b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3350), new Guid("325fdaaa-8346-4bf0-974a-8a4a56040fb0"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3354), new Guid("5237953e-e68e-4204-a326-bda2e43b434b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3357), new Guid("496ba048-d202-42a0-b8f4-ad2ba5ee24ee"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3361), new Guid("76a3fc5f-57ec-4998-b0a8-212376606a1f"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3300), new Guid("f0be8907-45f2-4a9f-a33e-615c082bad98"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3303), new Guid("831916bc-d1f9-403a-a4e8-1273f4537e4b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3306), new Guid("ffc5a18d-b604-4c00-82dd-4a6ea4f71a00"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3309), new Guid("6f69ee64-c377-4db4-894e-d319324f30ac"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3432), new Guid("0d67df82-2576-4ec8-92ae-399fbfd8b62d"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3436), new Guid("2bdf749b-0f76-4ece-a2f2-e53ee9b22f41"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3153), new Guid("bee58238-2587-4202-be5f-46f262b64737"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3157), new Guid("3ae96685-d315-4af8-a187-9b4da80bfa23"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3159), new Guid("4c5ef1f5-d6a1-469a-bb44-c8956a68080c"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3166), new Guid("53036fc8-3779-4196-a3dd-1e08569163ed"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3866), new Guid("f5d19a1d-9910-4c2a-84f6-211a8421cae6"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3874), new Guid("70feb155-efa4-46cf-8ecb-2e06236bf398"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3878), new Guid("f30ed6d0-bc65-422d-a36d-6b943d11d838"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3881), new Guid("c831b446-3f5d-4bfc-b72c-e933a2ab25c7"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3885), new Guid("f68ab120-3251-45fe-ae41-cb59a4628b39"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3909), new Guid("6ea2a6b2-1931-4ca7-8b7c-4e4d715a5ca2"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3913), new Guid("c6675e25-e241-4f10-a2c0-690f68bd0339"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3916), new Guid("312638bb-5be9-482c-9841-e0461c733ded"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3919), new Guid("227b375e-a986-469e-a037-655d985c3dab"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3791), new Guid("d7edc252-1407-4798-8bda-61fb4333e115"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3795), new Guid("7b17a75a-f766-433c-bc6a-73d14e0fbc94"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3835), new Guid("b49ab978-f080-454a-acc6-80965ee05043"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4044), new Guid("c93043f9-1e56-4dc7-ad10-76437243c77b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4048), new Guid("682ab38a-0228-4add-a98c-792c8b0636c1"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4051), new Guid("e5ccca81-737f-4e9f-ba81-be82d48ac10b"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4054), new Guid("28bc72d7-e2bb-4b51-9547-e37b8241bab4"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4056), new Guid("37f63ff6-262c-4a8f-8ac5-139d3780b1f1"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3999), new Guid("fab887f7-029f-45d7-a2d9-fe7757d1fe36"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4002), new Guid("a8004676-3e2e-40e1-bd60-2a1996396392"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4005), new Guid("9aac069e-093c-4963-b496-d1a03cdc8d73"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4008), new Guid("24755cd2-1a45-4731-b140-53bcbb4f82a2"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4013), new Guid("a785b9d7-dfd5-4f2c-8419-6fda13988bae"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4016), new Guid("1888f2d4-1583-4e00-b3bc-5f312f2e4968"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4018), new Guid("bbc8f06e-a466-405f-a703-1f01b81d00c2"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3947), new Guid("eb1c03bc-3503-48ef-8c23-0022ca8893ba"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3951), new Guid("7a985a38-85d9-454c-8449-6cc339996647"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3954), new Guid("394afff7-8764-4a4b-abc4-bf0dee83c92a"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3958), new Guid("aaa74d84-50ac-4719-b6e5-0e528c717c9d"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4117), new Guid("dcb33683-c60e-45dc-82e8-75caa55fdce6"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4121), new Guid("4046c29a-32ff-4f2c-ac04-91dad95275fd"), new DateTime(2023, 7, 29, 17, 4, 54, 346, DateTimeKind.Local).AddTicks(4121) });
        }
    }
}
