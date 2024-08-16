using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_FlowCondition_Constraints : Migration
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, 3, 30, 0, 0)), new Guid("804b4127-9884-45ee-9b9d-95a74e357e72") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb861eac-3fdf-44a3-8d66-68218bd6fa3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d37e1f52-f4f7-4e2d-a7c0-b9485d1bfa97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7417a5ad-e130-4764-a415-86871765252c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57092539-e83b-42bf-aff9-cf1d7be0b095") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39d3f601-34da-40a0-840f-f9e27d9f57eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 591, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, 3, 30, 0, 0)), new Guid("820b2b9a-706f-4eda-b69b-a0f3830ac239") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5f546bb-e23d-4c7c-8af5-47e34bf54665") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(995), new TimeSpan(0, 3, 30, 0, 0)), new Guid("182b869b-9041-43b5-ab89-77ba4c102217") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63e652b0-08ea-4430-89e1-43681fb897e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f41fa2cd-6044-4883-92e7-2eb74c9980f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0774f112-aeba-44ac-9eed-d457a39f1993") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f9ef515-7287-43e5-8f41-4e418d08a2ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("462eb57c-0a34-4902-ad97-543b326b2eac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa9d3466-fd20-47e8-9248-27d91b54454d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b08a2600-c489-45ba-b6eb-ecdbf4ba7eb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91fd2330-44ab-47e8-8731-7037349c2ea2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1bf65536-375d-47d8-bc8f-e93536be4ee4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("620dd466-210f-43bd-a5d8-3b1115e6b12d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00f774f2-357c-4b81-93db-59b183d377bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("796e678d-e8a9-455d-bca0-dff1644d3dd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66233e61-c67a-4755-9912-c647baae8f74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("956d7098-4a67-40d4-8b34-1d59d08ca562") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6349e78-10a9-403f-8645-2c78dbd9916d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d77d16e6-547d-4e04-8284-1e2cac2542a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6247e1ea-b1f4-4c09-b7e0-584dd1cef6d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 587, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5875cef3-3b54-4d35-9cec-ded35341b62f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f790c6a3-6e0c-4c09-bb71-31bbed1d5e9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("556b65d7-0b86-4052-a49f-f278bee998e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f98f3cf9-4d9c-47dd-a62b-05fd8d694bd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49516a47-f988-4bb3-b13b-c92daec956d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9613209-63bc-4e7e-a208-8c233248023b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbdc2954-c262-4aaa-b576-e6d92c2be6c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c082ba50-1d85-4b13-83b3-6ff9edeecdfe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2a88ffc-7feb-4c41-bbed-27278ea8b594") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8efae4c-772f-4a8c-b713-1dbe9336151f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("556be316-5496-4de0-80e2-9ce74dc83475") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(225), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec05e034-50ae-448f-8b45-4d81a3db7740") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c31345f-5450-4649-83bf-ba9ae112d2d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(230), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1947a49c-6653-4439-a898-06e252e54f48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(3390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e813f8e-785c-4e55-8820-2814cb3821d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e40e740-d8bb-40c5-8bc9-3220a2fe5bbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(543), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f96c270a-f914-4d38-b4ec-21f05705bbf4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b511976e-e08f-44f9-9943-30be71841beb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa84a0ee-9e81-4775-b12a-3cb9877d09ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35eeacdb-9872-4a0c-a115-7e349468950d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(5760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("373bc06a-9e53-4a5c-a4e3-057df0a8435c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b08d445-4aab-4ac8-8243-b4676f11c52b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abce97b2-2caa-4502-a430-4c31b9dc5cff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5582), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6f4c853-31c4-4e5f-8cef-18078b94acc0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 3, 30, 0, 0)), new Guid("559e6ff3-0a32-45c1-9374-bb8dd35cd6d2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45c0236c-8ebe-4d29-b9fc-88648b6ed505") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f16f3200-31dd-4ee3-98cb-de9f6f00e7c6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 586, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b2ded92-fca7-4860-8a21-46aa59cf257a") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_FlowCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_FlowCondition");

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
    }
}
