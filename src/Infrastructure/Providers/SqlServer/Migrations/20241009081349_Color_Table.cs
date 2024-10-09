using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Color_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_Color",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Color", x => x.Id);
                },
                comment: "Color's name of objects");

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

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Color",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 3, 30, 0, 0)), "Default", 101L, true, new Guid("4b55eee1-390d-4f0e-8442-a8ea3af8cb22"), null, "Default", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 3, 30, 0, 0)), "Primary", 102L, true, new Guid("1b41dfc2-dbc1-411e-b4fa-d375a4628e32"), null, "Primary", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 3, 30, 0, 0)), "Secondary", 103L, true, new Guid("20a882df-e8fd-48be-b6a3-006b1014fdb4"), null, "Secondary", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 3, 30, 0, 0)), "Tertiary", 104L, true, new Guid("5147490e-45a6-4bfe-8fea-6b8f278503b2"), null, "Tertiary", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7170), new TimeSpan(0, 3, 30, 0, 0)), "Info", 105L, true, new Guid("2c66d2a7-9316-4865-8979-1b7cd2d6942d"), null, "Info", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, 3, 30, 0, 0)), "Success", 106L, true, new Guid("0e7d3d15-c691-4da5-887c-e051f89d0db1"), null, "Success", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 3, 30, 0, 0)), "Warning", 107L, true, new Guid("f5c998ce-60e0-4f8d-ae1c-a6e2547d9521"), null, "Warning", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 3, 30, 0, 0)), "Error", 108L, true, new Guid("ce94e421-c5b8-4a60-8810-ab86d9e25a43"), null, "Error", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 3, 30, 0, 0)), "Dark", 109L, true, new Guid("c89c8bd6-62f8-47f9-b04d-a717dcd02c89"), null, "Dark", 109L },
                    { 110L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 3, 30, 0, 0)), "Transparent", 110L, true, new Guid("16c95483-052f-4d75-870e-fe15c08e023f"), null, "Transparent", 110L },
                    { 111L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, 3, 30, 0, 0)), "Inherit", 111L, true, new Guid("518feb73-b82e-44bf-b97f-009fc79fdc8a"), null, "Inherit", 111L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 10, 9, 11, 43, 46, 670, DateTimeKind.Unspecified).AddTicks(7192), new TimeSpan(0, 3, 30, 0, 0)), "Surface", 112L, true, new Guid("45f2df29-c1ad-419b-8d93-0b5ebfae9774"), null, "Surface", 112L }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_D_Color_Created",
                schema: "Dimentions",
                table: "D_Color",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Color_EnableRecord",
                schema: "Dimentions",
                table: "D_Color",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Color_ERPCode",
                schema: "Dimentions",
                table: "D_Color",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Color_LastModified",
                schema: "Dimentions",
                table: "D_Color",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Color_Name",
                schema: "Dimentions",
                table: "D_Color",
                column: "Name",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_Color",
                schema: "Dimentions");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7032a3b-d9ac-4701-aae1-2e22211a020d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d879e41-7df2-4d72-8c95-4f44f6563703") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7962), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27a86bbd-1ebd-402a-ba5c-2854f534313d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49a3d537-5643-40af-80d4-8d0a01e8bbda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7967), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39c1fa7d-d156-479a-9b5f-d72742cb8cce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d5ff4f0-fef8-4431-9f01-759955b65c4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 134, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15f4dd2e-2038-49e6-8fb2-95fdcb91722d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5045), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a96b32d9-c56b-4376-8e51-e66201dbfc5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ced536be-ca0e-4042-aa05-2c806ae60053") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5076), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9882209-a4c1-4720-8a0a-065c05041441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de852528-20fc-48f5-8b6d-0859d1f1e62b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b813dfe1-c43c-45d1-a663-3ecc0a08d6ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3845093e-9279-4b94-8338-122229136910") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81fcba51-805b-4c80-a48d-fb966b1b03d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5149), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8ebaf03-bfdd-4fba-8a19-de96b42a0ce6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("36a0e1f0-8187-4867-80ee-2fa4bc98d19a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d93e299-e320-406a-bd51-b2bb3cdacf01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("461ee0c6-7cd7-4c40-8323-224bc65405d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("631936cb-406a-446f-804a-7e035b69f48f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, 3, 30, 0, 0)), new Guid("192418aa-cda8-44d7-b66d-561f0b0d3659") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a7a5404-0832-4401-bcef-44411a32012c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd9ba2a1-1644-49b9-8267-9032cfcaef13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("981fc85d-aef7-4a03-b1f5-d33449b5c66d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2545a5c2-7d26-4a7c-9b92-15b101c4ca9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 3, 30, 0, 0)), new Guid("766b7f0c-af97-4ffc-aef0-09dc3e239371") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 3, 30, 0, 0)), new Guid("985a716e-9ea2-41bc-a5ea-ad6071ea8d79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6785), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57d5605d-f662-4323-819e-5a0090aed43d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 3, 30, 0, 0)), new Guid("986a6579-91e6-41cd-acd4-5949c4b368fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(23), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c3add4ef-5f5c-4308-9a36-6af4718cbc90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0e28dfd-b30c-485c-a535-dadb0c13fd66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c80e5ad6-4ae3-4e1a-8050-2f7548798417") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f667832-107b-4216-97ef-b0c43227bddf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ecbaf29d-0741-4909-8939-4fccd15314a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d906e7b3-6df9-4456-b6f0-5091fdb73d79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b27fc8c-ef0b-4bc9-8b51-d0b7bd1c0384") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56e19bb2-800f-4448-b019-45a71ba3ee2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0258f05d-4214-4a3d-982b-5dfcbbf04209") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5987416a-1f69-4c94-af1f-b136d8fff6e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5db99df-12ef-4796-85da-b5e2a9b8a843") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1114), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65dc9cd2-a7ae-49af-b6aa-82cf456b23fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4da6d9b-bb91-4bbf-a586-b195012c6e0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 129, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 3, 30, 0, 0)), new Guid("186ab049-b2be-4fb4-be77-c57ad35c271c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(3855), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c2fa0ed-d48b-44a9-ae7d-314485ef82cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9249), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fbb55e88-d001-4392-b894-b0f3fa1f3829") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("89c64a88-f104-43de-965c-1d3b6acf748c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3b9eb652-c2dc-426e-bacb-782024359821") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbf8c05b-19ac-4fbf-8ce6-727e17a90bf9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(6488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9eb3805-90a4-426e-9a9d-6e5dd120320d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82e7cd27-6a57-4b26-af92-bfeb4e66df4b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cbfe76c-33a5-46eb-90a7-fd6ab6c39e59") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fea65d5-f566-4e25-9ae6-8d699877508a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 3, 30, 0, 0)), new Guid("944ef1d8-d8fc-49b3-9e7b-c7c6b29838b2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d3452b6-2f01-44b4-8564-fd1d0f8ca926") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e48f8b5-b90a-4a65-8c57-a8b2a4b79d76") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("147a7319-8bd6-4a27-96f3-ff7c1c9cdc16") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9fd909b-4843-4c80-b143-735fc9145256") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(7984), new TimeSpan(0, 3, 30, 0, 0)), new Guid("519b988a-8689-4fc8-a197-61710bbfeb8d") });
        }
    }
}
