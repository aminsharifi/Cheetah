using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class delete_virtuals : Migration
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
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(342), new Guid("6f41e10d-2aa1-41cb-ac7a-cd5b14e5f1a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(362), new Guid("58239a07-744d-483e-ad2e-e931f502621e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(365), new Guid("4631b260-e57d-4d34-8a64-1d1d0d530003") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(367), "عدم تایید", new Guid("e8b6b85e-1bd8-4aa6-be04-e6cdfb13022d"), "Rejected" });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastUpdatedRecord", "Name", "SortIndex" },
                values: new object[] { 5L, new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(368), null, "ابطال شده", null, true, new Guid("f081cddd-b2d4-43e9-87fe-216ff86e5ffe"), null, "Aborted", 5L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(829), new Guid("80c46fc3-14be-4a2a-8c9a-19e8f753a1a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(938), new Guid("d278281a-1d2e-46ba-96ba-4e4224f3c79e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(945), new Guid("674d16b4-9478-4a59-8795-403cfaf08443") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(949), new Guid("23455fcb-978c-44c3-a2e6-636aed292aaa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(957), new Guid("bf15ff3a-3945-4cc5-b830-b359ed56af90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(963), new Guid("703dd41e-aae6-41d1-a2f7-b393df5cc614") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(968), new Guid("dfdc4973-40ff-4028-9aea-dd21d3897315") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(974), new Guid("23e3e58c-1f27-41b7-a100-74a0bf70ef80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(982), new Guid("6a36162a-09e3-4590-af38-5e317eddf7d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(995), new Guid("8ff0b237-4090-4929-90ef-5bc4dcb705cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1002), new Guid("f3afba54-30cf-4445-964a-c729e7c7f0fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1009), new Guid("35137700-149c-4ce6-835f-22aa375dbed6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1014), new Guid("fa058cda-19f3-41e2-a9aa-aff0af325a9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1020), new Guid("acb1ae56-c887-455b-922b-0a2ed2c1a298") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1025), new Guid("aa57b35c-0a13-4ccb-b44e-733913319a93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1034), new Guid("c6e719cc-5975-4286-a98a-992ed7575c0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1041), new Guid("7a737931-0ea3-4a37-b61b-9e9aeab6aab3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1048), new Guid("805cd620-113b-4e0f-96b7-ac23a0ff0aef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1052), new Guid("9180df29-73f5-4d39-b562-aaf0d22385d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1058), new Guid("113673b4-0632-41b8-86cd-ad4552a16026") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(456), new Guid("817e265d-f2d7-4638-932d-fdb1e52b79c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(458), new Guid("86a02ff6-332b-4465-ba0a-d921f8bfb700") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(460), new Guid("2071f1b3-a715-4867-9f7a-aa662fcc2a08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(494), new Guid("d10529bb-c7c3-45fb-b17a-6c3ccb6cd890") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(499), new Guid("7eeef36e-ea54-4cc7-a9c8-3564be1d498d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(501), new Guid("70dc9558-99ce-40d3-9d8b-85d76b937889") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(503), new Guid("39ed6144-b958-4506-bbce-eac7898a1c7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(505), new Guid("c5d158b7-9860-459c-88e2-bd0e1a0fc3fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(510), new Guid("11e7c620-24b7-4e22-acd6-5cccdfffec8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(794), new Guid("07410ae7-124d-4d32-8e5b-78f45365a1dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(797), new Guid("3d14e4e3-f453-4971-8c6c-cfc9399691ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(799), new Guid("4010eff7-d213-4914-a0b5-bc04d15480e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(801), new Guid("2290dde5-02b1-4588-80c7-2662f6fd61cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(803), new Guid("8aebe284-8e14-46f3-9865-ca9c2f3407fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(805), new Guid("409d7749-3db3-45d4-8cd5-110741285944") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(808), new Guid("ef23b7c9-a897-4b9d-b180-d0276e9e8c61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 693, DateTimeKind.Local).AddTicks(9847), new Guid("285c6c2c-c0fc-4da4-8a13-621b2ad26008") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 693, DateTimeKind.Local).AddTicks(9901), new Guid("52ea2fcc-a49e-4bf4-a8d6-a7e41c840a0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 693, DateTimeKind.Local).AddTicks(9904), new Guid("61fefa21-b439-4001-8a1d-12a4daff5f09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(741), new Guid("dd73f898-d34e-4115-bd62-bab882e8f6b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(744), new Guid("26944294-203a-4785-80f6-b3ce4dd0e690") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(746), new Guid("f3b4b86b-dae9-450e-b7e2-38cf0411d6a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(748), new Guid("02acf66d-ce25-434a-89ff-2a367e189b95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(751), new Guid("c2430ee7-4a60-41a5-976f-0d1db065449a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(753), new Guid("185611e4-cc03-41b9-a8e8-d1a28981ad9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(755), new Guid("cf40e42e-d730-4531-a1a5-488de49b5f9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(574), new Guid("fcbba5aa-7e99-458a-8250-f55a13f33a07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(578), new Guid("2e90a338-4499-4cc1-aeb0-238eab527659") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(580), new Guid("a428563f-b081-47c6-83f3-9268a3a34bd3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(585), new Guid("7ecf90a6-abc7-48a7-bde8-7683445dc36e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(593), new Guid("5839e6a2-08e6-491d-ae52-0b017c1ffe9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(610), new Guid("0be97c73-abca-4c17-b8e2-42fe25159383") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "Name" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(666), new Guid("0d800930-2bd5-4150-96a7-4fec081e62d8"), "Edit" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(668), new Guid("152c8907-bd69-4097-92da-eb6e0ab4990d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(671), new Guid("790b0dea-f3da-4b09-8756-48c42ecb1700") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(673), new Guid("70b976db-d713-4858-a289-72cc19a24725") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(540), new Guid("a8daeeb9-76b0-48dc-bda1-af8aa379fc68") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(543), new Guid("d2b1d800-da24-4dbc-9071-4b61e3a12c96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(545), new Guid("a4374b2a-b1df-4d54-ab03-1bfb7c3bfeee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(547), new Guid("d4a73f6d-c8e7-40bc-a680-95291e4f91a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(705), new Guid("506fd619-592d-49cf-a706-b654843ce900") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(710), new Guid("a8182883-2df3-42a9-94af-394cc5b1c6be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(413), new Guid("f45f7382-1af3-4ece-ad25-fab2ba8ffd4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(416), new Guid("9f97df81-e736-4f89-9fa8-6a5b7dd04d8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(419), new Guid("14d6ba82-aa32-4bff-bf01-3a70243e7a06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(421), new Guid("6e1884dc-5b62-45ee-845a-2b28b4173b74") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1274), new Guid("17159a73-c7c5-4417-a462-3f8d2db7be83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1300), new Guid("e3bd5ed0-6a48-4dcc-853f-b0766a2ddb4b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1319), new Guid("d922c12c-9029-4927-aa29-c9090de89689") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1328), new Guid("a036ddf7-1754-40d8-9f4d-ca1f140f9ef6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1331), new Guid("33c16a57-fcdf-4665-8fbf-df98f5fd09ba") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1354), new Guid("59eb90fb-392c-4b93-9c97-d0ca280d63b4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1358), new Guid("ae8d86e5-276c-4810-abb2-9e095fe1d230") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1362), new Guid("d886e352-7eca-4002-9847-550851adbc7b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1364), new Guid("718ece0a-5cb4-430c-9aa7-3acbe4d5379d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1162), new Guid("ee2b0e9e-07bd-4575-9a2a-f4a99e8f4a1b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1166), new Guid("269d9443-6f8a-4503-95b5-65b9ed669a65") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1169), new Guid("a63268ab-91ba-4109-bf5e-cf2c08d4b8fa") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1529), new Guid("4cf7962e-70cc-40b5-ae35-03341a542a67") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1533), new Guid("8c1467a4-423b-46e5-97fc-f796a4c2f966") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1535), new Guid("4e9d12e3-a019-4f0e-affc-bb32becc888e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1537), new Guid("8e72593c-64dd-41d3-b4ff-e626fc02a740") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1540), new Guid("4a9a268d-fd37-45c1-8efa-b6db9a5867ab") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1451), new Guid("ea225deb-f10e-46d2-9ab4-f5e42036b1b1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1454), new Guid("d7ff5c4a-eb9a-444c-b532-c016aad00894") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1458), new Guid("23e692c5-7cc3-422c-a475-2895a465bd53") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1460), new Guid("01d62753-5025-4af9-972c-dfcc48afde2b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1462), new Guid("a9ce7ed3-762a-4181-aefa-1ebbf566adcd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1470), new Guid("cf1e2870-bab6-4cd9-a407-938e739c2e4c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1472), new Guid("f7d8b1df-66bf-44c0-b7a2-7861a2704cc0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1408), new Guid("e93ed6af-74cf-46a5-a8b2-3a128b85044f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1414), new Guid("d89386fb-9d45-4cb6-a66a-af18dd101a8f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1417), new Guid("a7ddc265-e041-4518-b87f-8eceb105d466") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1419), new Guid("f5f2d580-9b15-462d-80a5-c8bae3f16a31") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1562), new Guid("9ffce76f-f459-44d4-b36e-58fc9376034f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 14, 54, 694, DateTimeKind.Local).AddTicks(1567), new Guid("21052ae1-f4e0-4399-b942-ac819e03189e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.EnsureSchema(
                name: "Virtuals");

            migrationBuilder.CreateTable(
                name: "V_Location",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_Location", x => x.PERPCode);
                });

            migrationBuilder.CreateTable(
                name: "V_Position",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_Position", x => x.PERPCode);
                });

            migrationBuilder.CreateTable(
                name: "V_User",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    User_BossName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_User", x => x.PERPCode);
                });

            migrationBuilder.CreateTable(
                name: "V_UserLocation",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_UserLocation", x => x.PERPCode);
                    table.ForeignKey(
                        name: "FK_V_UserLocation_V_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Virtuals",
                        principalTable: "V_Location",
                        principalColumn: "PERPCode");
                    table.ForeignKey(
                        name: "FK_V_UserLocation_V_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Virtuals",
                        principalTable: "V_User",
                        principalColumn: "PERPCode");
                });

            migrationBuilder.CreateTable(
                name: "V_UserPosition",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_UserPosition", x => x.PERPCode);
                    table.ForeignKey(
                        name: "FK_V_UserPosition_V_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Virtuals",
                        principalTable: "V_Position",
                        principalColumn: "PERPCode");
                    table.ForeignKey(
                        name: "FK_V_UserPosition_V_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Virtuals",
                        principalTable: "V_User",
                        principalColumn: "PERPCode");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1839), new Guid("fc0c791e-4c46-42b8-8718-73cda88626a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1843), new Guid("335efbbf-4bd0-4b0e-bc7b-8e9039f1c549") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1845), new Guid("c2c8891e-9a4c-48ae-aa28-6a906e94055f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DisplayName", "GuidRecord", "Name" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1847), "ابطال شده", new Guid("e1a21a5b-d107-4910-8f3a-1796fe841479"), "Aborted" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2217), new Guid("884cd471-abf8-47e0-9a66-9190b7c2b621") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2264), new Guid("f6bbfb70-21bd-438c-bb7e-cc78b4d47436") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2269), new Guid("fd6979f8-0586-47c4-b8b9-f19d3d0dda6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2274), new Guid("8544358a-21ee-41a6-bd01-416877ac4502") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2279), new Guid("97a8bfc5-af93-451f-b38a-b1dd81f209c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2283), new Guid("193758a0-439f-449d-91c6-3cfcc2b4f39d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2290), new Guid("d4cb6de3-41af-445c-a7fb-9f3635d6319e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2295), new Guid("84bc3ec5-d37a-4a7c-b2ea-f714500467ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2300), new Guid("a85d9dc7-4580-45cb-b89c-ca9fd4102ea4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2304), new Guid("4b80d1cc-dcc4-403c-90df-4954f2ea1f9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2309), new Guid("3c1dfdae-b78a-4df5-ae20-c97f2f98dbfd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2315), new Guid("01d8714a-42ee-418b-9c42-76219d6a1541") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2319), new Guid("6c551049-6b13-4901-a8ad-77733a30bb24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2324), new Guid("60410c96-e606-407d-87c6-b054b5a71737") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2330), new Guid("7f253ac4-fe47-4f1c-96e8-2562dd80023d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2335), new Guid("76ceb18c-c75d-43ac-a3e2-d02c1a3a3007") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2339), new Guid("ed798c36-8184-482b-87ac-7022c36b15c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2380), new Guid("c42553b7-c96a-4838-aa34-7ae944b11c9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2386), new Guid("7e65073f-ba38-4038-bc6c-bff0c42a6804") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2394), new Guid("5cf02ad2-9970-49b6-bf70-d4359c733d86") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1908), new Guid("7d93618e-8cff-4dcc-bbc4-91fd779f4b54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1911), new Guid("d3a7a430-819f-48c2-a8ea-370123672ae8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1912), new Guid("53890564-d122-440e-a91d-837fc0a294b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1930), new Guid("be52ac38-818e-4af8-b6d6-a2a7b558ce7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1933), new Guid("e468d2ec-9569-4f69-bbc1-c05d602ec77b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1937), new Guid("cde87b20-0de3-4e87-a96c-3933cb21e8fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1939), new Guid("77e62f66-bf83-46b6-ab03-5132465050dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1941), new Guid("54988cc8-8472-4616-b909-87f71b7c1ca1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1943), new Guid("a98d65b4-3ed2-4eb1-a8bc-6e52abadfb55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2144), new Guid("f683b345-5635-4fb3-806d-0748ac02e2fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2147), new Guid("66ea77cf-e76b-41d5-a1fe-0bff57a61b9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2149), new Guid("6c351172-8fd0-498a-adb3-bc098ffca2b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2151), new Guid("76fc0abd-feae-47d6-8dbc-4dc773416a47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2153), new Guid("7951811c-f92d-44c8-bd85-c3aee0ca364d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2193), new Guid("c90dc3dd-4ecb-452a-88aa-8295996e83d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2195), new Guid("4862249b-ee1a-45b0-939b-c3102ad4fde3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1594), new Guid("feaafb81-8341-4e42-b8ef-3c87d29c70b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1644), new Guid("744a2f18-6af8-45a9-9acb-a0b879bbd6bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1646), new Guid("255af30a-91fb-4a82-b6ed-61671c30416d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2108), new Guid("15bd1d50-6583-4deb-992b-8cab48218d4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2111), new Guid("72c33b3e-36e5-46d5-a3f4-555697c708d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2113), new Guid("8bae47dd-57bf-4ad9-a021-f7e160a8dceb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2115), new Guid("f83d16c3-2123-4ed0-aa64-00a9efb53495") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2119), new Guid("907f3fa0-b51f-4a52-b5cf-9a3910b03676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2121), new Guid("162c197e-a702-4714-8d3e-3e21f8e7df78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2124), new Guid("d7272dfd-a7e0-4a0a-94ec-be3077009107") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2038), new Guid("4270b48c-0213-4df2-a1ce-d90be18a9ac5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2041), new Guid("fa7e216c-de06-41b0-8b2c-9f975dab5a00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2043), new Guid("bf71a257-8b35-468f-941f-1a2c8d6139c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2046), new Guid("87dd235e-df15-4ea9-8ea7-738f3552a2cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2048), new Guid("1af768e3-6953-41eb-a5b8-7e94b24c1966") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2050), new Guid("52d96ec3-9516-4038-bca1-68c23b47f6e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "Name" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2053), new Guid("4f3f512e-6bbf-4cc0-b892-89d14ad163c0"), "Revise" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2056), new Guid("0495e29c-840d-411e-b436-1041d4af5101") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2060), new Guid("409fd689-3efc-4759-ad36-0866b2ab766e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2062), new Guid("4949a6a1-1e91-410c-9585-9296c47d4eba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1967), new Guid("d4e685c1-ec32-46db-9be1-9ae6e2f44ced") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1970), new Guid("afffe7ad-20b6-42b0-8416-ac50a83e910a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1971), new Guid("36f345f6-b5d8-4669-9584-06308404f23b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2018), new Guid("62381246-215c-4a2c-8e73-286007f8d162") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2086), new Guid("5de560ce-8f56-4f0f-bcd5-4cf29a0c9ed0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2089), new Guid("5afa6455-73ca-4f5b-869c-a4b0127961f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1868), new Guid("27535631-654d-4c9f-b215-0bd25d7abfed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1882), new Guid("34b4dc33-f987-451b-9aa7-4d827f5fba4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1884), new Guid("64c2f594-58fc-4a04-b2ed-d5c6df016638") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(1887), new Guid("39188e12-cfc6-4fcc-8f38-90e9f2432e89") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2460), new Guid("23d2c144-20bb-4ab5-af75-4cfbe52b574b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2470), new Guid("6d58cd32-04ef-4afa-9de9-679149707b14") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2475), new Guid("08476a01-fdd0-488d-8129-4552afdf6c5c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2477), new Guid("9bcbae74-def5-4828-b543-43b5d144ac34") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2480), new Guid("8775778d-906c-4b8f-9c3e-6a29e3525063") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2501), new Guid("284a3149-756d-4f0f-9398-454ac23d0d67") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2505), new Guid("970b2264-926b-46bc-9805-dfc01ac352ad") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2511), new Guid("8c6f0d0f-4d56-46bc-809b-ae4770e5d12a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2514), new Guid("c2dee5a8-1ea0-40fa-b6f3-70f3cc39c1cb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2432), new Guid("f14935c5-1624-4dee-91b9-78d1a6d29287") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2435), new Guid("0b2ead90-78bb-49ba-9f40-aff1dd62ac63") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2439), new Guid("dc62d448-f600-4658-845f-d4cab9e89145") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2670), new Guid("8736b243-9ef3-497c-84ef-5cd339ad926e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2672), new Guid("e3024be3-5549-43d9-b18c-10afa032df0f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2674), new Guid("82e3f20b-4b1a-4e00-bb81-87f4eca76499") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2678), new Guid("9cbae39b-f1e3-43d5-8187-9f2d9a59d721") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2681), new Guid("136295b7-67a6-4c75-b2b9-4d24373f72e1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2623), new Guid("34801a5b-6a3c-4f69-b614-8d49e6e55e97") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2627), new Guid("655a02ac-f072-4b82-bd51-46b61f859585") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2631), new Guid("94b1d726-1182-4e23-bc16-ebee631988a6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2636), new Guid("7a0d124f-ae09-4da6-8bb1-6e739910274f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2639), new Guid("58e48b74-7125-4d65-b57e-938f58dbe44e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2642), new Guid("d1cb10d2-49e2-406c-9c2d-117ac8c785aa") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2645), new Guid("809072a4-ba1c-4407-b930-2a481a7898c4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2537), new Guid("bd064a3f-9f55-4b72-883e-2ce4dd142631") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2540), new Guid("90dd5374-2d6e-45df-be49-9695217b8cd0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2542), new Guid("0cae140b-3791-4810-b06d-d49b1a4aa5f8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2544), new Guid("4ca99683-ee5a-46ad-926f-0e597d740212") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2700), new Guid("8b667469-8f2c-458b-bbe7-9357b6afee08") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 7, 30, 15, 10, 44, 990, DateTimeKind.Local).AddTicks(2702), new Guid("f8d52ac1-18dc-4b61-b342-eacae65b4523") });

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_EnableRecord",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_FirstId",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_SecondId",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_EnableRecord",
                schema: "Virtuals",
                table: "V_UserPosition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_FirstId",
                schema: "Virtuals",
                table: "V_UserPosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_SecondId",
                schema: "Virtuals",
                table: "V_UserPosition",
                column: "SecondId",
                descending: new bool[0]);
        }
    }
}
