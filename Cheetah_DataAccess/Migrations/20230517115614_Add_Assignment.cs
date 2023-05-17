using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_Assignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Request_F_RequestId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.RenameColumn(
                name: "F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                newName: "PRM_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Assignment_F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                newName: "IX_F_Assignment_PRM_RequestId");

            migrationBuilder.AlterColumn<long>(
                name: "PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2610), new Guid("af409eee-9486-4cee-8941-0893d27691f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2663), new Guid("a90c652f-ff07-46ff-a096-d6a1eb8ed78f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2673), new Guid("6094db31-4c80-4393-83c0-8997aa96c458") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2683), new Guid("d789322d-5c5f-4477-b3a6-4f380f6422d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2692), new Guid("41de58c7-9b14-4ac6-8899-c27e8313d653") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2701), new Guid("6cb9923b-51c4-468d-babc-565f15c7aff5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2710), new Guid("f1e1906f-1347-4db0-8a4b-eafd36802460") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2722), new Guid("ebdf7739-32db-41ef-aa97-21d7c321ffaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2730), new Guid("0c4d73d7-0508-401c-92c8-0f13a5cd2343") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2741), new Guid("946b613f-28aa-41a6-82f0-d3d270ccadea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2749), new Guid("ae001913-b446-4227-a12c-dc4adb89038c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2786), new Guid("7ecd52c6-d8af-4d51-b4d1-e65b5fe9c2eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2797), new Guid("6ebed7ca-07aa-44e6-9e0e-c1c9eeaedd5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2805), new Guid("b5e738c9-3de3-47ae-a05d-492abe126e03") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2814), new Guid("ffbca71c-dee9-46f8-b104-9996a88f1fa4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2830), new Guid("2941d01e-698b-42fc-9019-0352e9788e1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2841), new Guid("afc16634-dd3e-4b68-ab91-457a02e46e33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2850), new Guid("365d7b20-55b4-4fb2-8bce-ecae72df5b55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2858), new Guid("c3ff1230-3413-4442-b12c-22f955018185") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2867), new Guid("f5dcd872-bfbf-4c51-8d1d-1f2675f84a03") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2875), new Guid("6957ac4e-15d9-4811-8dd2-d2fbb8f29199") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1918), new Guid("069d158f-1aab-4666-b0c5-12e117ec2e6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1951), new Guid("69ba08fe-0c9b-43ad-b188-f8e0f079d588") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1956), new Guid("5f5b4bad-1536-40bf-9e2d-0cb583d85bd6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1990), new Guid("1c00aec7-a016-433d-bc68-c0a292e8a148") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2000), new Guid("d6992426-35f7-414b-82f3-a697dbf501ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2007), new Guid("782cba74-22ad-4c54-b393-c00f931df89a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2012), new Guid("3ba2597d-a6f5-43b8-9e61-5d7c1b469390") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2017), new Guid("4667e7cb-eb69-44a8-a67e-b2811aa81ea6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2076), new Guid("da4187e0-bf84-4612-8ae9-f853fe1a567d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2428), new Guid("7255b669-8017-4656-99d9-2a36e3d7c040") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2435), new Guid("c65dc74b-e2ae-4436-9f89-1f67dc60661f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2444), new Guid("d26b9000-6f38-43da-a346-b4b0f7bafe76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2540), new Guid("48232718-19b8-4aee-946b-d4169efdb767") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2546), new Guid("9cc0cd5a-e0f0-4534-82ca-bb059301ab07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2552), new Guid("5b9898d8-7bfb-4247-8f0f-c4406c440bf1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2559), new Guid("59248c05-a85e-43ae-bd9a-ab549f6093d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1301), new Guid("f3b5fb21-d3c1-4545-bf96-529542ee6b96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1414), new Guid("68c4011f-679b-48c0-a058-9bd4fd6cf166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1421), new Guid("db334b0b-b51b-4d86-92e4-591c4bb7e239") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1850), new Guid("a3277912-4ac6-4255-a5cb-b845eced1ef1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1866), new Guid("4bbd2c81-e02d-4916-b3fe-9c19651585a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1875), new Guid("2f24e0b4-716a-4b38-983f-a66c6ae13ba7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(1881), new Guid("d9e71864-f8e9-4ff8-ac6a-76d95f5d6257") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2370), new Guid("a623935a-eeec-49c7-a179-64a547e44b4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2378), new Guid("d87d6a6c-c8ff-4652-be9e-0fcabf829890") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2383), new Guid("8e79265b-34e7-4f5f-a263-c4b318cba9da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2391), new Guid("1c508da3-ba6d-4111-bdf2-f93218c232c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2396), new Guid("c6c32dc2-8e39-4dc1-bbaa-d0205caa7b5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2169), new Guid("a7a68fed-d019-492e-a118-a9640ee75b6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2178), new Guid("93e06c0e-2d5a-4b41-8de0-b37c92034207") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2244), new Guid("4ee2130d-6a05-4b63-8ac5-efb932160115") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2251), new Guid("4c6b372d-6522-4fb9-9344-580978b3e614") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2256), new Guid("f6c1377b-f299-416a-b2f9-803b13ba4231") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2262), new Guid("ccb6c59c-6fd4-4ae1-b34a-876a13ab4566") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2267), new Guid("a69e7139-2371-4e90-bbab-997623083f80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2275), new Guid("5dba682e-798f-440c-b5bf-951c95957e4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2280), new Guid("7f7935a3-18f7-4c15-b87d-c7e75d64b110") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2285), new Guid("d9c5ba2e-79e2-4205-a619-f208c53a55d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2121), new Guid("be091736-bba1-4aba-928e-d61dfff720d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2129), new Guid("400d11d3-1747-4946-9fa5-83194a6dd7f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2134), new Guid("033f8f14-e1f7-4118-b562-5b9266246375") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2142), new Guid("d5e7cf8e-4a04-40d5-86e9-0e5e9d38e167") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2334), new Guid("a9b28fdd-2db7-4312-a4f0-d849a8caf0ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2341), new Guid("74369ae4-8b9e-4e10-b24f-d0146a67eeba") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2971), new Guid("2b832a43-8d47-43f0-96b6-12ca00e676f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3043), new Guid("d02ec4d0-81de-4cc4-b107-560668d00b3a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3051), new Guid("3f293ec4-13c1-48fd-be6d-e77cda86b609") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3057), new Guid("ad7dec15-b1de-4de6-9a2c-c2b0d24f669a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3063), new Guid("a97cd7e8-8192-4808-a3fa-017ab6d59407") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3103), new Guid("bdd3bff9-9a90-4bf2-9ebd-5da72e47d7d3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3112), new Guid("a406021f-d785-498a-ae37-3fb8e2b0cc54") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3120), new Guid("5c1b62a4-2953-47a7-85bb-baab94ad1c67") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3125), new Guid("d01aecc4-764c-47a5-af09-ac24a924c4c1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2924), new Guid("73d6fcd8-6c9a-4a91-ab20-7a15b24952d6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2934), new Guid("354ecfec-0dd0-4870-bb1a-73278e944d6a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(2941), new Guid("0b9b1e2e-5037-4051-a7e7-7fb35018c96f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3514), new Guid("d76465c1-fb4d-4796-9d1f-82078460a648") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3541), new Guid("75f7df3c-de2c-4d0e-9091-f72bb6711003") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3546), new Guid("18dfb9f9-9920-445c-83a3-5778ef421a34") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3551), new Guid("4000ce49-cf8a-4489-873d-e074b6544fd1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3557), new Guid("b26d2d23-1df3-4029-b154-679078c8a8c1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3198), new Guid("c63e1949-02d5-4547-a767-1d0fb56d7688") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3205), new Guid("21122b5a-d62e-4248-a71e-7baad108a025") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3211), new Guid("52bebed4-8d79-4736-bbd8-85321bee20fe") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3216), new Guid("f0446d11-33ca-4e1f-9fac-8d32891b9118") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3224), new Guid("af22e5df-0d13-4d33-88ee-ca5881711a67") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3229), new Guid("d85d7664-ef23-4fd6-9286-7a7ab8eea497") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3235), new Guid("7a177fce-95dc-4b09-b04d-0542fbee5aa7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3158), new Guid("7bc35631-f7d1-4312-b9c6-24d3b4311c1b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3167), new Guid("94a7fe09-acb5-483e-8ccc-884a8ccbff5b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3618), new Guid("b113b8f3-3db8-4f9b-8345-50d52a3a1e12") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 26, 13, 65, DateTimeKind.Local).AddTicks(3670), new Guid("9a06e1d0-44c4-45fb-b1af-57b89eef58ca") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_Assignment_F_Request_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Request_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.RenameColumn(
                name: "PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                newName: "F_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Assignment_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                newName: "IX_F_Assignment_F_RequestId");

            migrationBuilder.AlterColumn<long>(
                name: "F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9607), new Guid("ea12dd0a-b1a5-4ee4-9bb6-19b73482ea24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9685), new Guid("656e30f9-ce9e-4866-98a7-7367495d23b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9700), new Guid("6772d985-b5a0-46b8-b4b1-54412dc07424") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9711), new Guid("0873f086-39cf-4593-bede-ce969e323f62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9725), new Guid("7c0a1a33-dc37-417d-bbc6-deb549e84f48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9743), new Guid("337a8924-9c9e-4d34-b39f-d3ff3388b383") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9757), new Guid("64343736-4b8b-4591-9975-fc4d9a732b17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9810), new Guid("8860f119-c145-477a-8695-5983986b23fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9826), new Guid("d65fac45-8dfd-4c54-aeb1-35c6742c9e54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9838), new Guid("04fa1109-912e-447b-8c6a-4a54a44a48a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9852), new Guid("df934d98-b271-4b0a-beca-cf9c3a3be6ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9867), new Guid("e5fe6bfd-5473-440d-b4e3-2ce867d34aea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9880), new Guid("27ec9b35-1ec2-4903-a88a-b694f461e4e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9896), new Guid("73293e57-32e4-4c07-a37d-7ff0f0f308ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9910), new Guid("668373c1-1b05-47cc-8965-3553d65fa077") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9930), new Guid("74c6efc6-ff55-4f7b-b1bf-8e856f4cafdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9944), new Guid("0da67c23-4ea3-4e66-a6ab-7fdc536807fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9957), new Guid("cd05d09d-2f78-4515-a203-dac099234994") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9970), new Guid("ba0176a0-ad6d-41e0-be08-8da85bc12d1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9983), new Guid("ae13706c-de7a-46ff-a25e-695e82ba90b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9996), new Guid("47dd22f7-166d-4fdf-a659-8b13f49b2ee0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8613), new Guid("379c7f74-eccd-4106-bb58-b276c9bb9616") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8649), new Guid("e7ed9bd7-60df-4168-9d1e-75cea001ff58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8664), new Guid("2a702f88-cecc-40bb-b7e0-d567a482c79f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8710), new Guid("ce41d222-45d4-4984-8a74-acd34f86b131") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8719), new Guid("4021d1d2-acfb-4930-b1f1-f7d3b1deba38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8728), new Guid("eddf2461-7f4c-4cec-92e8-811341f4d3a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8737), new Guid("c2ab02c7-eda1-410d-9e54-d2b4a4a6bc88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8746), new Guid("87d5ec40-6660-4783-89c6-e751dcb45c78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8961), new Guid("27836329-6ffe-4b1a-b8e5-817395d0df00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9515), new Guid("a9b00db5-6472-4fa9-8a1a-9dba9b0e8605") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9525), new Guid("1fd82b3e-5de6-448e-9af5-f2df62b573cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9534), new Guid("901ea22c-885e-4612-ae16-1633a48aaf19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9542), new Guid("3fbc5b3f-7840-4e93-bdd6-60a5473f69b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9555), new Guid("6ef36165-9bb5-4da3-96f0-07cf79be2472") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9563), new Guid("56ccccfe-9fde-4c85-8c64-fed57e40d16b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9572), new Guid("1e5101bb-fbb5-4bd2-a581-bd8074fe3334") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(7470), new Guid("4c1aa946-40c0-466d-a038-7d4505a6a019") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(7814), new Guid("f4dfebf1-31f2-4d6d-bc29-0c56a8b1764e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(7834), new Guid("ed8f9b8a-5617-4755-bf6c-5aa460ee05aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8523), new Guid("ea580b8b-5a70-4c04-852e-938b791ca6e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8540), new Guid("51a4a0e3-8977-47f5-9a73-71cdb31d0160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8559), new Guid("0a0a7e19-d120-44d0-aa49-8423d5fc4344") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(8568), new Guid("6a19293f-0e5c-43ef-b8db-ce7cd8f5a545") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9399), new Guid("fb87d607-0f41-4354-9ada-624202426af1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9412), new Guid("388b9758-ebb3-48d1-8be0-e6a74fabfc32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9421), new Guid("d113706d-0f34-47d0-94ba-113ad844d777") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9468), new Guid("7eeaad77-5bb2-4e44-90d2-344bd5460be7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9478), new Guid("e9d15c52-764b-4858-a59d-7674732adf3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9201), new Guid("bb9c6047-e2db-42ed-b4c8-c8761ff43f52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9212), new Guid("e4649c65-3fdc-42f2-8f6c-5231a30c5f43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9220), new Guid("ec2b7ce9-c478-4318-ae2d-aa60974c61ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9230), new Guid("165f6f7d-b00e-46c6-b98d-ad72f8544c5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9237), new Guid("5750a7a7-1dbf-4b52-a0c1-a3ee6976bf7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9250), new Guid("13a68bfa-6099-4e6e-838d-478db5d26b5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9260), new Guid("383a52cd-60b8-405a-b395-cce36ab35d0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9270), new Guid("4428281d-4241-448b-a70e-dc977540f57d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9280), new Guid("94793be8-ed85-4f4d-af57-fe7dccd66954") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9290), new Guid("0ba40ff3-d211-4069-9e08-95baf0808bf5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9135), new Guid("00522279-089f-4990-be17-ffe658611100") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9151), new Guid("b0f57caa-a1e8-46e4-bd09-cd9e6eee12c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9159), new Guid("e998c4e6-a1b3-406e-aa45-4ee558fb686d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9166), new Guid("56d62804-23c4-4962-a9a1-9e347c4afdd9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9350), new Guid("b7bab87f-c197-44e6-8eb1-f0267b5b5b29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 234, DateTimeKind.Local).AddTicks(9363), new Guid("4b4dd419-0628-4f5e-875a-fa64646e8bfd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(165), new Guid("6599ba64-f63c-4a44-a70b-e3fd08a9d883") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(179), new Guid("0810c229-989b-4fc9-8d84-ea1727e91acf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(188), new Guid("c7284076-8d52-485e-a0c4-e343bd150523") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(197), new Guid("23d10d45-1c9e-4dcc-8ea7-f610af2b998e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(207), new Guid("a6af7e7b-cad5-4d67-8624-c04980bba313") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(254), new Guid("ad130ec7-b4ab-4347-b681-ed2436fb3218") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(267), new Guid("aaaab26a-9c55-4f36-bbf6-b7ebbce56262") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(276), new Guid("7739e5f5-4071-4b69-bc22-24ac40a092f5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(285), new Guid("5ad41acc-ef7d-49e0-bcc6-f21a0ebaf69e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(106), new Guid("bd128bb1-1f21-45d4-8db2-9f4de85f1d87") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(119), new Guid("31c7ff08-d980-4925-8bdf-fa30fe96977b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(128), new Guid("7a550b98-91b7-4dd9-abf3-25674607691d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(525), new Guid("d6606b8f-8ebe-4a48-a383-98a095010d42") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(536), new Guid("faf5bedf-1913-4e3a-94bd-894e00149873") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(547), new Guid("19fcc888-e976-460b-a3f9-0872b373c8ba") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(559), new Guid("6598e70a-7a4b-41df-b979-2c48e15d7739") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(567), new Guid("e4ea8d03-3051-4711-9993-2b6c7357d31c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(371), new Guid("33085fb0-dc51-4eac-a532-b5f635253378") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(380), new Guid("9fdf4cf7-04af-423b-89a1-a9358b98231a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(393), new Guid("6a5efc51-1c76-4a59-b6a2-6f5d5e8ee6b1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(402), new Guid("ebc720b3-fb9e-4499-aa23-92a87bee6e34") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(410), new Guid("0d2cfd3c-5435-4c08-8d4a-4f8546d1c420") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(419), new Guid("d15d1a03-9c6b-4168-8d3b-b4af8829df4d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(464), new Guid("bebbf5e3-77b9-48ba-baba-4dfc84e8f917") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(329), new Guid("864e68e0-524e-4ca4-a790-d0d8fd59f300") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(339), new Guid("8d5f404c-09e1-4617-800a-0c3ab7751ca8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(600), new Guid("94c9700b-9e80-4d4a-a589-4551290f26e7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 56, 3, 235, DateTimeKind.Local).AddTicks(610), new Guid("6d370afc-4f0c-4ed1-bc4a-13143e1d2843") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_Assignment_F_Request_F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "F_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
                principalColumn: "Id");
        }
    }
}
