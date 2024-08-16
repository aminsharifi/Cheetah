using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Constraint_Condition : Migration
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9834fc29-00ca-41e4-8825-39535727b74c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f295e54-708b-41c5-b5f9-ac6e6116892e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3137a024-ccd9-4189-894a-330a1b5096f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47ca22d5-3014-43de-b106-16ba9463d3a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f72b37e3-378b-45eb-955d-e137ed7d7f6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d66418f-c168-4aeb-a639-de6af357fa99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 438, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f969a4a-3246-4692-96bb-0211e5dbb41f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1eb79c97-b2f5-4c9c-9a5a-a5954d42e26b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26834f8e-b80c-4e0a-9d2e-5c5d256c918c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd206cc2-3a2f-4968-bb77-eda27ddeea6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9404f290-9beb-4ebe-afe2-78f431223258") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58952886-0463-46b4-ba8d-b07c526d0123") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6887), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13c0d38f-66a5-4141-9db4-1723708fe683") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 3, 30, 0, 0)), new Guid("17a6da1b-c128-4a01-95a0-8a97e1af2e20") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06786388-35c8-4b8a-954e-9debe9085bdf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ecb348d-c19b-450c-951d-45fda8de0148") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b01ea2d0-81d6-43ff-8fb0-6421a811cfc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f00f0922-e7f1-422d-bbe6-aa45021f704a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1758675-6d84-4e71-9773-5203492fad32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4cdb446-82bf-4f35-ad1a-a20cfff2d9ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5994e635-d5d1-4c62-aa8b-ac4f3575776f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c5cf9ebf-6237-46db-9e2b-37feee0220f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d136dae8-26ec-48b3-8016-2646aaaac6fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bb2960b-723d-4e18-a184-21089ca053c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6762072-3e79-4d50-b21a-63c20baa71bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e66268c6-77b2-448b-8aad-a8f569c11d45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 435, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cee06d2-e81a-4547-93b0-dc7b5a3aaab8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(3426), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a9c3ec5-cefe-452b-8884-4e6b546e9166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("95e14b5b-9bb3-45ca-860f-25fe52a3326e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe5c147d-3f8f-410a-bbf6-3fa179f252e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7171374-b8d5-4765-9c0f-260bbfd1f82e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed6a4415-e9c0-4e4a-a08f-ef6150103771") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1e87c8c-9dcb-436a-b1a1-d1e094f5ee82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("60ee9dc5-454b-4cfc-b364-b8269dfbc378") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e80c0701-b6c3-474a-b7de-23d11b258cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5629), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d559ef7f-0fe9-4c71-8bf8-f083eb35ff93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7bac6619-0470-4d76-bf39-1c1fe232e699") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d332c87-685b-413b-bedc-d9da910a8a12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("014eaa9e-ae74-44b1-9df2-39504074bbda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81a2ec7f-0735-407b-92f2-220a185d707f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1e86d61-eb5e-46b7-8060-912060983c3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7c8ef6d-4960-4d4a-8c91-ac86f41d1f78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5171), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba1ea0d9-54f8-45e2-9fb5-51681a9a2089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04a622b5-3598-40c5-b924-30993eb9bb1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 30, 0, 0)), new Guid("765b9dd6-b942-48c5-a3fb-94ed59c32166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab2dad4b-1dd5-4137-91a6-40cc7de311d5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 3, 30, 0, 0)), new Guid("22016b97-1534-48d5-8913-d9adcd6b4df1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9933), new TimeSpan(0, 3, 30, 0, 0)), new Guid("264666c2-5523-4987-bd47-641557241c8f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69f1c605-48c8-45aa-b273-58baa083e0f0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b38e63bf-65ce-4f30-abbe-2d0d24e95b80") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 435, DateTimeKind.Unspecified).AddTicks(4631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e9db4d0-642e-41d4-90f6-5be8095d5bd4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5a9668d-6577-475b-be7b-64e2d1e2b37d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79c8338b-331f-4219-ba98-34237bc8437c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 433, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9682847-ef73-42ab-9ded-cfb5a73014c1") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_TaskCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_TaskCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_UserCondition");

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
        }
    }
}
