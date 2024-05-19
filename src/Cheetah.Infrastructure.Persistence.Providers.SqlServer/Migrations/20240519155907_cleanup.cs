using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class cleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F_Job",
                schema: "Facts");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("89a5ae0f-6006-48c0-9ae5-af71153cbf44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06f6d91b-158d-4f8b-bd09-00f734d09486") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a24fde2-9596-4f42-82cb-c0a3877cdd73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83d95c62-3dda-4427-89eb-f69ddef6a741") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc06a9ef-c49e-4d34-8d31-8077689890af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(6255), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01bf60b4-556a-4895-9f14-a0e7d0c62a64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 686, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6408a310-a34a-4ebd-b99c-386670d2971b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7672), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d47b8c8e-ec89-45a6-88a0-66fc0aa5bdcc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23d1a5e0-6e89-4dc0-8267-ff1b0e698916") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b67e72f-f59b-48db-8220-6c2804c36d5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1588765-e4b9-4662-9ab1-95952a82118d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7736), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4814317-d670-4b25-8c35-08e197f52b3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c1a6f20-4e21-4780-aee9-4a5c748f1958") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5481d8e8-bbea-443a-a27a-88308be4e4c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7759), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d21cc05d-53b3-4193-9de9-c098bb83db3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81933375-54e2-4ca7-9ac9-c44f422716f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0461e4d2-55c5-43cb-a755-b3f97775f0c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ead08054-364f-4528-9861-b6b1fb662ca5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1782af4a-d2e6-4dcf-812d-248e43a48e68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 687, DateTimeKind.Unspecified).AddTicks(7782), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64dca82a-4be0-4419-a3d6-b8baccd574b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1304), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1255cd7-631e-4764-840e-0876cfc382d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a77cc2e-9ba6-4279-b191-4039b9720ca2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1312), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b243bc3-4fc2-4a93-80b9-1b1c080d68cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1315), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b84f3ef-1ae6-42a1-9491-20c3589e1cfd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e3d0a1a-1227-4607-b8a0-9104cfe7e867") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8fab7851-fb1f-49c5-9c60-bf1aec6da066") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 683, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fd4fc87-c778-405b-9488-db51191365d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("027c3410-a7b9-4084-abf2-d0f22b54e71c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8c4be384-eebe-4096-9cbf-a3f667f1a39a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("239394ef-eea2-4cac-859b-8d8cf2be38e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7622), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52affb63-09f5-4dfb-ad36-b5a8f160851c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7626), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24d43c0d-929a-4adc-9901-ddaa7749aabf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a80bb2e7-d700-4f90-95a0-05e7b2a1a47a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6f3c269f-aa9f-4c69-948a-ee2f791847d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a093f905-f8cf-4369-aace-05cff6b9a197") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4b434cd-a085-4880-9424-0fe170da946e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1af8160-5eea-4d0e-9fd8-fcb45298232f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab26cea8-5b98-4ced-98d5-0f346a94b2c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(6345), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a27a2b09-372f-4062-a993-60bfaf9d65c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b016112-84a3-4687-9274-ae3c13875779") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 686, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33404436-11bd-4073-9357-8328d01bcaee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 686, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71d46048-9e47-40aa-a005-75b703f4056d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b7ce00c-f4c4-42d1-a85c-c0873eed80ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73f8a9d5-5603-440a-acae-86b061dd1e2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52f93e20-2259-4192-8972-66d56e9c6c65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(7581), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4076ffb2-8ec7-4f76-9efb-34af7e225c1a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 684, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98099557-cfb9-475c-8090-6bc82ae862e1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1682), new TimeSpan(0, 3, 30, 0, 0)), new Guid("337eabe2-39e6-4592-86fd-7e245248af29") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("455480a4-0056-4718-b83b-f5a136f7b7f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(1690), new TimeSpan(0, 3, 30, 0, 0)), new Guid("19b1ec95-724c-4798-a074-8eaf937bc0f5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 683, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5690223-4adf-47ae-bb1d-59d0c45537b2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(4085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2783267a-6cc7-4d3c-a6da-8a1e22108716") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 685, DateTimeKind.Unspecified).AddTicks(4318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4e0c0a6b-d0f0-4643-bc3a-172d12800f29") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 6, 682, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35373999-7e0f-4d3f-b108-016bf56b6798") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "F_Job",
                schema: "Facts",
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
                    Entity_NameId = table.Column<long>(type: "bigint", nullable: false),
                    JobData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDuration = table.Column<int>(type: "int", nullable: true),
                    JobError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobFinished = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobNextRetry = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobResult = table.Column<bool>(type: "bit", nullable: false),
                    JobRetryCount = table.Column<int>(type: "int", nullable: false),
                    JobStarted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Job_D_Entity_Entity_NameId",
                        column: x => x.Entity_NameId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Job Info");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec1e188d-925e-40b8-a5d2-348d4f9448dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4613), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8a63716-94a9-4561-9610-d2e0f01305bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4616), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d69714a-a570-406f-909f-d963f5bd172e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01c1ce92-d9fc-4b2a-81dd-1449453cb136") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d3b9670-b693-4c78-b113-9c7d2ede6646") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, 3, 30, 0, 0)), new Guid("22af7267-c217-4172-ad25-dde6f534c463") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 673, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 3, 30, 0, 0)), new Guid("184516bd-3422-4973-ab02-4fa4277a8f55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc3c4c0d-5ab9-4c73-ac91-5d98243d891e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7873c56-3dee-46cc-9ce1-c33267fed94e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7f2f78ee-db3b-46e2-964f-b4dacdbc384c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6266), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0e9735f-d094-4b41-816a-41ca19bc0a9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba6df9d2-1484-468c-b597-c8827e63bf8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e240c1cb-275e-4c87-918a-08d8913d6089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6292), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9226e28b-69db-43cf-b2ce-80380dba51db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5526dcdf-161b-430d-864c-520306f0cdfb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ea6e927-df59-46ac-9a8e-3c62992419d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0f3fc735-f45f-46d4-a681-cf20cf975739") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6347), new TimeSpan(0, 3, 30, 0, 0)), new Guid("588c22b6-921d-46e1-8881-601fa12368ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 3, 30, 0, 0)), new Guid("113323e8-a231-4376-9a18-b5a896b22a29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 674, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("341edc01-c1af-489a-96cc-99be0a4d0d87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ed1a0a4-6616-4018-8069-1d87c0e612c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(311), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eecd8a4-3138-450a-9fe9-1b26d49553cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8641d68c-390a-46ab-8bcc-5609d5b81c1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(381), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e6b5d00-f698-414f-83cb-4b7355f8f84d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd2cb4f2-5649-43f7-9ae0-5b439e969c85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a4b33bc-1c6e-489f-9705-fb96dd565f67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 670, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54d75355-1037-44b6-ae73-dd21161b51d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(3976), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f01b57e9-c531-4675-9f50-53662b58008a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c386df4a-83ac-4b9d-a5c9-42dc961a03fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6423), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8fa48807-2846-4634-b996-a94077f03d00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd6e5f53-76e7-407e-a178-d8193f3028bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6429), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f51338b-0139-48e9-bb89-e52b5ae4f282") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d83995a4-5af5-4f62-8b19-982ac6a13d97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6435), new TimeSpan(0, 3, 30, 0, 0)), new Guid("256081f2-38b2-4d78-9d19-237ae8b59652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("53e6d1da-ae47-4bf7-a3a2-ad5cb71efdef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(6272), new TimeSpan(0, 3, 30, 0, 0)), new Guid("352361b6-40d5-4d41-8be5-41c871faf520") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(5077), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7996316-1f99-40c9-983f-9fded916e48e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b1c8a8d-7724-45e4-a636-c8134f0541ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(5087), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84a6cc86-f6a0-4340-8b37-b4a6e9f0db56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(5089), new TimeSpan(0, 3, 30, 0, 0)), new Guid("702f1068-93d7-4cac-a114-6fcc646068e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(9029), new TimeSpan(0, 3, 30, 0, 0)), new Guid("75f24b80-e0c7-48a7-8a65-a27845cc313e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a0d69c1-6afe-433b-9244-597a95d53815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15bd7bfc-3dea-4e80-b25c-48232da18045") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7821e1ff-99b1-402c-a9af-30006ca19aa7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf9f0c6c-4b04-49d5-a6ec-e74e14f3689f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c6e1500-30a9-48a3-ba90-14463c2f5307") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 671, DateTimeKind.Unspecified).AddTicks(776), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf7a3198-b18d-431b-a351-8bf7e5f16228") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d5b58cd-d249-4275-b0b0-62f0b380934e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50db2fbf-4f6d-40e9-9288-efcf1e08844a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f5c3df43-faed-4b7f-825a-30693b4104bc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 670, DateTimeKind.Unspecified).AddTicks(5048), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7b7d009-dcc7-4e77-8f8d-d3071e0c666b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7aab1ab4-6e39-48b7-83c2-20e711fc2411") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 672, DateTimeKind.Unspecified).AddTicks(3056), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d75fe42-a7b9-4fc4-a36c-6fb5d9137382") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 14, 52, 0, 668, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4647db2e-2c2d-45e5-9db9-66df09b0fed4") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_Created",
                schema: "Facts",
                table: "F_Job",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_EnableRecord",
                schema: "Facts",
                table: "F_Job",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_Entity_NameId",
                schema: "Facts",
                table: "F_Job",
                column: "Entity_NameId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_ERPCode",
                schema: "Facts",
                table: "F_Job",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_LastModified",
                schema: "Facts",
                table: "F_Job",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Job_Name",
                schema: "Facts",
                table: "F_Job",
                column: "Name",
                descending: new bool[0]);
        }
    }
}
