using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Condition_Color : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ColorId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43cf548a-ae7a-4fb4-af35-4cedb2aa13b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9313), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e361e2d-327c-40d7-842e-43780e93a755") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bdd94e3-fe57-4e64-a987-a7d0819d3195") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d835dd61-1fb4-43aa-b9cf-8d346a5a2c55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f64bb782-8788-4af2-b8b1-0ad6ad10222c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b809d781-6175-4728-a1f3-472d149e1b0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc6e897b-83a8-4cc7-843d-0962a1818b9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b74fc779-dc3d-45d1-9deb-c5dd55ad154c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(899), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7e1bdf9-fcd3-458d-9841-8816b71a87c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("679f58b0-fda9-4dc7-adbb-909747733dca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(904), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91706487-50ec-478a-b4ec-a0949a94b012") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d127380f-66a5-4260-90cf-d453d227b493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2bb8ebb-efdf-4bb5-9309-c769c8278099") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b21def7-b2d3-4434-af0c-58d75f7cc13d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83288a8e-88ba-4316-900a-fe94137f6f1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 3, 30, 0, 0)), new Guid("caacb63f-ef9c-41e4-9951-ee629098695b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e0e6bba-d0d8-4c20-a147-1ae26a27aeb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e165fb9-7ff0-4539-b820-d4477f6badfb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 412, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9d60c33-7ed1-45ca-89ca-f034183216d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b85db7c4-e41c-4ae5-8c89-e6b27a1d9eba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56d570f3-546c-4592-a8b5-0ffb88088087") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a70df2c-dd9b-4c0c-85d3-4f11ba862e2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8c98719-65d9-4deb-b32c-2fa112bc0b56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d82dbb9-2edc-4456-a709-aeece27fd21c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1c07573-4eda-4da4-8e62-51c3072ddcf9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50088348-885e-49c0-863f-22a827e0e07c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d8a3938-1352-4538-8025-b0601b2a86ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6344), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2357a6d9-48c9-4685-afb3-3eaf30f885e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc77b8a5-4fef-4e2d-8a06-8db4a14a9b5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3be09ce0-359a-4cbd-a8a0-ad345da6e4a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b7343d0-b67f-4b1e-bd90-7dc594079036") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a04dfb1f-451e-4a03-982b-ea3648fbb09a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 414, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7782bd54-9847-4870-b40e-e44bb4d9dec1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1bb3155b-a91d-46a7-b820-4e355799c5a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ec9c6e-9427-419b-81dc-f6091c671d16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78c87e35-970f-46f3-9c9b-f932f586f85f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed36c78f-46f6-4bc2-a567-75f368a8a33f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db34260c-4273-4eed-8abb-4f304874fd69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59b53dee-0f13-4fa0-9180-8ca613b0eaa4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fc30ca3-35a0-4cd0-a706-2af8ddeb625b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(9487), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9d82607-3bd7-4c05-86e1-6d3e44a93e9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ea6bf62-7751-4cbe-8272-2909f6828cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8396509-f7d2-46e5-8af5-08f81e8da217") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2679), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56db0c98-3cea-4651-bce0-2acbb1db11ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8714ded-222f-4ac0-b61a-e96ddc6e1bb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c505b07-b597-4020-b7e2-5618afd7537c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4876cd81-7ca7-4894-a0f7-dce7d03b80b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e6a3b4d-8cef-4c2e-8557-5dbf3bfc98da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a6672be-9c42-49ae-bc8d-a91e05eba0f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4091e051-b37e-402e-9f5d-7d3f033fe104") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ccd6c4f-1503-457c-be47-fb0fceae7c3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e28f4848-470c-495c-b076-bc7897a32695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61107578-9acc-46bb-93d0-56228bdc2199") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 407, DateTimeKind.Unspecified).AddTicks(6908), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64234da2-c0f9-4cdb-8b3b-3efee28fa880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7067274-0958-4c12-8da5-dcea6db52668") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b2b8779-acad-48e0-85d1-666ba1360887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e04c3c71-bb87-465e-8bec-ac604bf5280e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 3, 30, 0, 0)), new Guid("676adbcc-a373-4baf-9ac7-39472ac91ffc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 415, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f80d4204-331b-429e-b39b-db875ebea84e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ColorId", "Created", "GuidRecord" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(5803), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a1c6e8e-eee4-4c09-b47f-8b65d222792a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ColorId", "Created", "GuidRecord" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7afd0b96-fb98-4df9-9ac1-2240874e00bd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ColorId", "Created", "GuidRecord" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 3, 30, 0, 0)), new Guid("610c74de-e684-4c4b-bfec-a949813c5dcd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ColorId", "Created", "GuidRecord" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 411, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a28a5a2d-6da2-428b-89b4-b770c90b0dea") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(1143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b44a671-ad49-46ac-b94b-4f70c62dda9b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02d1113f-8338-490b-90c0-23dfea8d8d45") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5127fc5-bce1-4c5d-b41b-584c1e1899af") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(2952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dd38652-33d9-45f0-b79e-d41b28c4d870") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 410, DateTimeKind.Unspecified).AddTicks(3359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f903129f-b7b9-4d86-859a-81d588ccad46") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 13, 2, 32, 409, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d1c0fca-8cee-461b-a699-b506d122600e") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ColorId",
                schema: "Facts",
                table: "F_Condition",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_Color_ColorId",
                schema: "Facts",
                table: "F_Condition",
                column: "ColorId",
                principalSchema: "Dimentions",
                principalTable: "D_Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Color_ColorId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_ColorId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "ColorId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b571bf3-edcb-4237-a51a-38ca5dc0b3b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b20fa94-d712-499f-b9b4-7070b5e0f229") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa63f9c8-6423-4040-8ee7-707a4f01a392") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9873), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47a9babf-e51b-4237-884c-2c45fcaaf28d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 3, 30, 0, 0)), new Guid("34085f1f-2bb4-49fd-8a89-0fbac370a024") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(9908), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e80643fc-482c-42a2-9240-66532e0e7286") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b55eee1-390d-4f0e-8442-a8ea3af8cb22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b41dfc2-dbc1-411e-b4fa-d375a4628e32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20a882df-e8fd-48be-b6a3-006b1014fdb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5147490e-45a6-4bfe-8fea-6b8f278503b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2c66d2a7-9316-4865-8979-1b7cd2d6942d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e7d3d15-c691-4da5-887c-e051f89d0db1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f5c998ce-60e0-4f8d-ae1c-a6e2547d9521") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce94e421-c5b8-4a60-8810-ab86d9e25a43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c89c8bd6-62f8-47f9-b04d-a717dcd02c89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16c95483-052f-4d75-870e-fe15c08e023f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 3, 30, 0, 0)), new Guid("518feb73-b82e-44bf-b97f-009fc79fdc8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Color",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45f2df29-c1ad-419b-8d93-0b5ebfae9774") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 671, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b135ed55-994a-4a0b-99a6-4fb9ee17816c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90332929-0d2d-4f38-9269-842e04782f4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40fb5f42-d30f-4517-bfb0-4b1e051db10c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77f80f14-4d7d-4df4-9486-00df6d8b933b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ad4d973-86c1-4764-9490-b0c6de64f89b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd2639f0-66d9-42ba-b8dc-acfbdf889362") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc800d5d-6f82-4251-85f8-cf89a2b66a0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6b5e50e-df35-4c06-b003-e2ae2a9f780d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48a20ebc-3026-4754-8494-baaafdb6aa26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83085e15-dcda-475a-8853-6bc8d32bb074") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eafefbf9-7928-4700-8c77-d54777f7de49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bd289c2-60c8-40ba-87fd-a47e3ea61d3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6800), new TimeSpan(0, 3, 30, 0, 0)), new Guid("958ebbef-1873-461d-90a3-8b66ce223aee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(6805), new TimeSpan(0, 3, 30, 0, 0)), new Guid("29a2541c-6382-4259-b506-4546c1205f49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 672, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15218b9c-993d-4a17-8b23-7c6a760bf6a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9930f652-3575-446a-97f3-4e5cfbdd3d58") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9320214c-6852-4cda-85f1-d0b40d800c51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5211b38d-d1c0-4f5f-8092-3ecd2ec65667") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf5959ce-6465-4f91-9537-753e5a09b37b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84f49c97-ba76-4a03-b180-7e007039e0b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51521588-d706-45e4-a704-2ece89f30e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(3042), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ffcdeb5c-9ac5-45d3-87f1-d7fed8c10d44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(5667), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e280b3d4-20c8-460a-809d-3c6313a3fea6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8944), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f5a29095-0819-4e67-b71e-6dbec641022f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f75c5973-558f-478b-933b-7fe2dc49717a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, 3, 30, 0, 0)), new Guid("addfc85b-3653-4baa-aa11-02f33c9bdef8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a4718da-d5c0-4454-a5a3-a5fdafa3f621") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3b59828-be69-4c9f-b1a3-7e3285f042f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(8974), new TimeSpan(0, 3, 30, 0, 0)), new Guid("276cdc3a-8dfd-4dcd-98ea-34918a81b73f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abcbfd6c-eaba-44e5-a727-361afbeab816") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(7969), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df81b65d-01ad-4399-abd7-3efdec03ffc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(6843), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b328f4fe-34a2-4793-814d-0a52b0ab4433") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1db252ce-5fa5-4c61-899d-797d0c202403") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(6853), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cedb4fc-5471-400c-8342-d9577687597c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(6863), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2da7d44-097a-48d6-858a-57ab648a03df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 665, DateTimeKind.Unspecified).AddTicks(9707), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef4728fb-ef95-43d3-b46a-b5d9fe68c7c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 667, DateTimeKind.Unspecified).AddTicks(6821), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7d5efbc-0d9c-4db5-982f-4466bdcec5b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 673, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aae959e4-100d-4509-ad33-12e3c90f4351") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 673, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("335dbe49-d035-4e90-9b12-01611c8d5f67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 673, DateTimeKind.Unspecified).AddTicks(1339), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccde1e78-b6f4-49ef-a202-7977b7d4a4bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 673, DateTimeKind.Unspecified).AddTicks(1341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1408e885-0208-47ed-aa20-470f78606af0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 669, DateTimeKind.Unspecified).AddTicks(1892), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90242253-0e33-4e1e-8b7d-f22af29ab575") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ee240c2-1e1c-4ca3-87e1-26e6f65b7caf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ccbfcf8-dbec-4a5b-b707-1debb74b45a4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03140ce5-2714-4046-94c0-b0a9f82d9548") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d855bcb1-b283-4291-bb93-184cc6150329") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15172320-b06a-46b2-8b2e-6879b52332fc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bc04e68-f2af-4d0d-b370-7714b82c23af") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9b17d409-7ec6-4094-8fb1-2941347a6ae4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(9002), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa812c19-c159-45db-82dc-f8afd680b1ad") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 668, DateTimeKind.Unspecified).AddTicks(1808), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3fcc84f1-14b0-4a7b-bb86-0bd936c8479f") });
        }
    }
}
