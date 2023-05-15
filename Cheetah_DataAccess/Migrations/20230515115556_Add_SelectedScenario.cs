using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_SelectedScenario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 113);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7289), new Guid("1e042763-fa7e-4c09-b73b-689b3011f617") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7351), new Guid("33bdad35-01f7-4fe7-97a3-15591f416b8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7360), new Guid("db0d9590-c517-44e3-ae5f-65dcdf3e2adb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7368), new Guid("a383eb89-962d-479b-b0a3-d355eee4a8df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7378), new Guid("485cc8a0-9037-4a2d-a16c-a43b1e4440b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7387), new Guid("2b4f08d4-341f-4eae-9c1e-8cd09e36ea15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7395), new Guid("f7d17699-cc11-455d-857a-537d9e2061aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7439), new Guid("e5606f49-003f-43ae-b14a-204fcaf69027") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7448), new Guid("b5aa5e61-84fd-4309-b722-d6453d9a3371") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7458), new Guid("64d2d9d3-574f-427f-bc36-e441b12a96af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7466), new Guid("19bf469d-d0bc-4667-a00b-a1f557a11690") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7476), new Guid("70208e1b-5414-4df0-ab81-9ae859339c1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7483), new Guid("9430fa5c-98ac-4703-abab-908888184953") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7491), new Guid("a353834b-f229-49b7-9af7-6fa23c6da41b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7498), new Guid("b35d4984-ab13-4bb5-a5a9-094520953738") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7506), new Guid("67b84548-3c61-461d-b3bf-529d1c312b7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7513), new Guid("739bb532-5521-4727-afe6-78882b8d650f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7523), new Guid("f08b3ed8-a7b4-41c5-b6c7-126114c220da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7532), new Guid("ef8b55d9-3190-4891-87a3-534d803acca4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7540), new Guid("0e300e6f-ec0b-49af-b32d-f42f3487bba4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7548), new Guid("4d31df7f-527f-4c29-aa01-d6444d651652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6780), new Guid("5879e9ce-1609-470d-b3ec-30dd87283de7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6786), new Guid("1f403150-083e-45ed-b947-f9b6e0886f04") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6791), new Guid("6c9cc6f3-8393-43a2-bdf3-68491c652be4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6815), new Guid("1e250dce-bf4f-4381-bf4a-1ec8c1430602") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6821), new Guid("2b286564-1556-436f-9271-c6a84bfa3176") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6825), new Guid("2dd6d760-b447-4f8f-8e3d-f13d93862b81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6833), new Guid("5de92c75-a88b-4c35-b0d2-d513a07a6fc1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6837), new Guid("9a01d83a-a681-4161-9b6c-c2923df18390") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6880), new Guid("2cdbc8cc-c462-4a50-bb90-764c6268f36f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7174), new Guid("ab72c189-510e-4571-bf59-8068ef49b856") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7180), new Guid("e278adf0-fc91-4ccc-af5f-ad4ee99764a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7185), new Guid("ac3c0774-5940-48c8-ba68-3e22dd7eb6df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7191), new Guid("3f9f1e54-1580-4bc7-a09f-455c9eb50f15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7196), new Guid("01cfd399-a96f-4de0-afbb-66367521e30f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7202), new Guid("9a454b0e-4f55-4a1d-baaa-1734cc391b66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7207), new Guid("27f7e181-15b2-4a29-a464-8d8d61f8838a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6275), new Guid("e975e774-f787-48cb-a8ae-7858682db019") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6382), new Guid("0976fd7b-4859-4ed5-a718-5ec38f2237d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6388), new Guid("7e9408f5-2840-42ce-b061-fdbe47fdb503") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6719), new Guid("1b529246-1a8e-4d10-a284-a3bae4043c24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6727), new Guid("9b9f2282-8d03-4191-b0ff-f2b574b97b27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6745), new Guid("0df8d9c6-23d9-4b50-8a1f-f7c099fa64e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6750), new Guid("541b3d30-dcee-46be-ae3e-3f43fd498b4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7093), new Guid("67543e25-66fd-4c85-9643-2beb6e09e6ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7099), new Guid("65090567-7f5d-43bc-80ad-5152e598aa58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7104), new Guid("859573b9-4a63-4d15-8ea5-4b4428af3d87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7134), new Guid("ca835835-1cfc-4776-955e-2cda2e00ad66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7139), new Guid("981ea394-432d-4649-a6ff-754e0bc011c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6969), new Guid("af926bff-1660-4185-bcdb-f6e19bad0347") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6978), new Guid("76bea6cf-643f-44b4-92ee-b71743d0a2f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6984), new Guid("4d129195-251c-425c-8259-2d81d837a92a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6989), new Guid("f672ace7-6c65-4970-be64-b179191b637a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6995), new Guid("0167a603-3379-4548-ac9e-346b3cfe283f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7000), new Guid("dd2273e9-21a7-43c5-a129-1da4ec40363c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7005), new Guid("614267b5-0f13-49c6-a263-fdbf2eb23322") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7010), new Guid("2eac6709-4a1c-4f30-8ed2-8b7a0b1fd687") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7014), new Guid("e84d8386-03d5-4375-9db9-966ed9e908f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7022), new Guid("115b1195-adad-4b0f-9a31-10d672b7d7b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6930), new Guid("53da3a61-a6ba-4542-9c13-b07a334fab0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6936), new Guid("941d34de-8fa0-4bb0-ab59-dce31e08e4fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6940), new Guid("62a09179-ec0c-439f-90aa-4dfef3f8da33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(6945), new Guid("49b06010-682d-47e7-b056-6b24f399e27b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7059), new Guid("eb7222c0-ce90-4696-a2ad-b4f01d8d5b87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7066), new Guid("8d335f1e-6010-4bb0-a6e3-d09a061d1d81") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7657), new Guid("7fd40769-5681-4879-a7b4-8edcb6fe9df9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7670), new Guid("96400da5-d682-4c07-bf6b-2f1648c6960b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7676), new Guid("a877d6f3-d9e9-4185-b2a2-5da745eab973") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7681), new Guid("d99a6c0f-bfc8-4b7f-bd74-aad6a6ccd04c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7686), new Guid("93e1a00e-69e9-451c-b31f-9dae69d76885") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7715), new Guid("95c26b23-2bfe-4a16-8987-807f16c0f6de") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7723), new Guid("bb11f1cb-bdf8-45dd-b561-3778a6813ba2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7732), new Guid("a8c3d972-dcd1-4499-8557-601b069a6bf5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7737), new Guid("9bfb9778-da06-4a38-8809-d50476720140") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7621), new Guid("e386462a-ed15-482e-8be4-86c67cb17c04") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7629), new Guid("fba91a63-0bec-4ebd-850d-5bc27672bc33") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7634), new Guid("b25ebd93-edad-4fdc-8b96-693c390f79bd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7889), new Guid("a0fb448a-2030-4765-a96f-a4d43c28615f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7895), new Guid("fd947eb3-6507-430b-b01a-4f7a8dfc0a03") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7899), new Guid("9796bb17-cd05-4252-9fb7-69976919b90b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7907), new Guid("c1e6f870-e9a7-462b-8e65-4d8125740a82") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7912), new Guid("15c95fc8-1fc0-49b1-9257-0823f7202cf3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7795), new Guid("336c6e2b-bd32-4bc9-84a0-4c4870ea287f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7801), new Guid("32b4c66c-137a-4c5a-830d-481af6fb6362") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7805), new Guid("1889af57-7800-4723-900d-155699ca7b73") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7812), new Guid("754c33ee-1d1f-45dd-8330-39343634e44f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7817), new Guid("0bd05eaa-314f-45bb-9b6c-8e91187d0743") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7851), new Guid("c3000334-9d79-40d5-809f-506063505afc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7859), new Guid("e5a6b221-b9bb-4330-9c4a-9ace33eb2652") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7764), new Guid("8bff5987-3c68-4529-9d3b-51d2fbf75bc5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7772), new Guid("768cbb5a-3856-4fd0-b262-5621d8710d5a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7940), new Guid("08ae2f97-bb34-45c9-926a-03d9e73ea5bc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 25, 55, 610, DateTimeKind.Local).AddTicks(7946), new Guid("de0717b4-c5b1-4f57-a50b-359ab7c82a6c") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_SelectedScenarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Request_F_Scenario_RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_SelectedScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Request_F_Scenario_RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropIndex(
                name: "IX_F_Request_RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropColumn(
                name: "RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4822), new Guid("0184faae-42e4-49fd-bf26-b8b14e3b4a38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4872), new Guid("7ed5e893-611b-49a8-9db5-6b4fb8193cb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4880), new Guid("6b091146-a3b9-4248-b32e-85ae91b8ba66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4889), new Guid("2c4b416d-81f1-45e0-a797-dd9e38dffe75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4897), new Guid("689c53bd-662f-4eeb-8246-2762db7de059") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4905), new Guid("b733d130-0637-4a0e-9427-ff17f36f95e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4915), new Guid("9f96078d-de82-4901-b50a-f39446badd48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4925), new Guid("4dce9810-4ad7-4e37-8785-a68c3db30a4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4934), new Guid("a7a7774f-c2a9-42cc-be27-31fe12a1b532") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4942), new Guid("d15f6777-4e7b-4591-b1cc-c3a32dda8ce8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4979), new Guid("7c4e2f69-4f59-47b4-a1f6-445c7b70446b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4988), new Guid("313b2826-4c17-470d-8482-63a84ec15eb7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4997), new Guid("88e406e4-86dd-46f8-8b0f-0a80c6d1653b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5005), new Guid("750459ba-cb4d-4931-8ffe-a70344f7c4f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5013), new Guid("29175cad-b35e-4c53-a5ef-cdb5ef9aac14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5029), new Guid("ea427bf5-2669-4b47-bc52-f767b417105a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5038), new Guid("5214685b-ba59-425e-99d7-7ccdfa9c1d21") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5045), new Guid("a66f2cda-8209-4f66-88b8-91b9fd2dd032") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5054), new Guid("9ea3c0a7-5b35-41d3-9680-c0868233a329") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5063), new Guid("b886fb08-5574-42fc-9417-00cece2439b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5070), new Guid("53e9be66-ebed-4b99-825c-7bf3e9770382") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4203), new Guid("d436d6c3-be2f-43bb-bad7-fef1f982fd0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4232), new Guid("b73759ae-ab57-4a24-a072-09991f277648") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4237), new Guid("d7e37c7d-706a-44ed-ae8c-8ade0a6c4be4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4265), new Guid("a64bd45d-176a-4e55-8ac9-28872c2f503c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4274), new Guid("373fe6f6-cff8-4a74-b4d5-3d34d8b9b7ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4279), new Guid("c1dbe579-b01e-4aa0-8c94-4b2e8ac10762") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4284), new Guid("1b283f96-815a-489e-aebd-2e17e76c6ae8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4289), new Guid("acc74b6a-0617-47bc-94fc-98c28f52f2f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4377), new Guid("d1f4aa3f-ab51-4b99-beba-d1e645fe9817") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4688), new Guid("fb1c07e1-5195-4646-ae81-a3cd548782df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4757), new Guid("9fb921e5-2548-4f1a-8e3b-7e61509db76d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4763), new Guid("1646e387-a3bd-4740-8f6f-15a0aea42893") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4768), new Guid("aff98783-c151-4b0e-8857-ab498dda03b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4773), new Guid("6dd94ac7-394e-48de-8a52-ec1bcc99b1a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4778), new Guid("5fd437e5-d0e4-4fe5-8fa9-c64c2ef97c62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4787), new Guid("2c6d35bf-deb0-498c-9ef8-98d55f81d545") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(3693), new Guid("89ba5902-eb92-4ceb-8330-e8522000d6a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(3809), new Guid("6b45e81e-b9b2-410a-afe5-e4f5ff47e2ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(3815), new Guid("c64f8c05-eab9-4e89-a659-6353f0fe9ad9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4143), new Guid("280ad962-f626-41bf-a690-b54b4c77de09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4152), new Guid("d5a91214-5a2a-4560-b0ff-a3e158368981") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4162), new Guid("addeeb7b-be08-4fee-826c-470b83ab110f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4168), new Guid("d9c414cb-6bd4-4bda-800a-7b9921370e6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4636), new Guid("83c1746e-e8ce-4de3-8030-e0c6f4c2c6ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4644), new Guid("19b8968b-ecd6-46fe-9999-330d6e8929cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4650), new Guid("bf83b0a5-d6ee-43e9-b82f-8b0582065589") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4657), new Guid("eee78c6b-d35d-4269-8c39-0044457f59d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4662), new Guid("ddefa40f-c094-47ff-a61d-6cd6d9fc976e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4511), new Guid("61772d47-db47-499e-9881-4b5ba035a456") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4519), new Guid("f33ec48f-1477-40fb-b3e2-156cdb01a255") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4524), new Guid("1fb62636-1e3c-4d48-9112-e6ac5455c1db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4529), new Guid("a8612dde-b396-4d5b-b48c-fd7bd6ede861") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4535), new Guid("988aceaa-cb01-4422-85a6-020fd8623960") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4542), new Guid("feea0e00-daf9-434e-bc94-4deca84cd149") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4547), new Guid("41f30718-5dd9-47c5-9adc-6ab4699abff9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4555), new Guid("4831f352-3e5e-4bbc-ab94-4901ba99e612") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4560), new Guid("31fa7286-f705-41fb-8189-3d206ffdc211") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4565), new Guid("30771f0b-b56a-4589-854e-7b9a7fc3a40d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4426), new Guid("f7f04cb4-d658-4032-878b-016f0f5602d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4432), new Guid("03c97b0c-e6ed-4354-a185-956b36b47d19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4437), new Guid("36d25310-dddc-4daa-a8f3-d04549fd079b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4445), new Guid("1e575555-04b6-4b47-b639-10a452ced037") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4606), new Guid("a3dfc817-d038-47bc-8f7d-162f5f48a0b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(4612), new Guid("0bbf2e9e-bd07-4972-8f8a-eeaf1f66621f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5177), new Guid("94fe85c2-28d4-4284-b9ee-0ae47ceab598") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5191), new Guid("35f46d1a-f83c-4d4e-8143-a6e958a3a585") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5197), new Guid("36060f35-ec2e-4a4a-a7cd-af6ac47af7cc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5202), new Guid("6d5ac8f9-3805-4d46-be4d-7fbc8f082ffc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5208), new Guid("8cd18628-5094-4168-b306-ad634accd3f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5233), new Guid("ecfd422e-6f5b-405b-9b58-c6c3fe036976") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5241), new Guid("56ada24e-5cbb-4af1-a19c-86e3ac823984") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5249), new Guid("b02b1a0d-8b54-46e8-972b-bb804cae481a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5256), new Guid("a6f49e5d-3f18-4531-a4dd-15beb460d5ad") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5110), new Guid("7b7fdddb-5bf8-4cb1-a30a-519bdec955c5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5116), new Guid("56bd2446-bdd9-40d5-9486-070854ce59d1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5151), new Guid("c2c89a9d-71d3-483e-a584-4df765323619") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5395), new Guid("8fd6aff1-938a-4d57-ba45-93c8c550e7f7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5401), new Guid("d8dcf998-8e4b-4f14-89f8-30d2555b51ca") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5407), new Guid("fe2e2b5a-cb0c-4add-9814-3d19f834d246") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5413), new Guid("56d19d9e-a13b-45a9-836e-c555326f0fa9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5446), new Guid("dcbd2b74-44a9-42fd-b242-ca490c9ba2fa") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5318), new Guid("bfebde53-7e5c-4b5d-963d-d6ceec67ef67") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5323), new Guid("4e804728-d133-4b2d-a55b-7dcccd85b23c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5329), new Guid("65ab7378-9777-4e2c-8b51-646becfd58c8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5334), new Guid("70d170e5-08fe-442e-8033-5d469e11fc97") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5345), new Guid("31f9a62a-5671-4b44-991b-fe61a582d5b8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5351), new Guid("3c21d3df-b380-4de1-9538-96b6ffc5c476") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5356), new Guid("3cd2fda9-3170-4d0a-a0a9-72d4a23dda94") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5287), new Guid("1e0fd6f0-58c1-41c3-9487-c87fa3f002cd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5294), new Guid("695b3fc0-7eb8-468e-8e8f-4700ece4ebea") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5476), new Guid("0a86aff3-aeeb-4dc6-95ec-889bc3051e43") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 37, 41, 94, DateTimeKind.Local).AddTicks(5482), new Guid("8684363d-6896-40aa-a5f2-10b76803f932") });
        }
    }
}
