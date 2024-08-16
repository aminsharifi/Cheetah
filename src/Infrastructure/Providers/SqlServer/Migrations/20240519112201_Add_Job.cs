using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Job : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    JobError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobRetryCount = table.Column<int>(type: "int", nullable: false),
                    JobNextRetry = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobStarted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobFinished = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    JobDuration = table.Column<int>(type: "int", nullable: true),
                    JobResult = table.Column<bool>(type: "bit", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9409), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e4d6cb4-1cb3-4fc2-83bc-26f51a918ce4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d394eab-b61b-4cdd-b027-a32e0e27237a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f941626b-ae9e-47ed-b178-528ce7112bdb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9422), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83e40004-5d5d-4fba-9824-28712b51c4a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9425), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c4d79a9-eb12-4450-af4d-76b8e03cf8f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a7893ed-9c0c-4f94-be93-b1c306c5b645") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 227, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f722160-cbc7-4256-a1ed-d980e8d835dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c710f2c-3571-4bde-aaae-a40725e329ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db61ce08-5b8c-41b2-a8e1-ac78d5ddffa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3501), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24975a56-a909-41f7-92ce-050df141b187") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de7c56f3-a968-44cf-b9df-9f7396a06421") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45bedc52-3458-45f2-8b41-712c68a99a9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5688efe-f157-4f6e-8f4f-38340240d3c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50024bf9-a1b9-4c4c-aea9-c9aff319cd2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a19efce8-6432-456a-8902-7f22335b0064") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61bd6438-c297-49d3-9982-6c68a2c6487c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3541), new TimeSpan(0, 3, 30, 0, 0)), new Guid("180e2000-e64f-4dba-bbd3-238057b86b4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 3, 30, 0, 0)), new Guid("10a5c748-2b44-4008-91dc-7c6d5cf41536") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3549), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd6ae607-bb5e-4495-9b7d-60798159f44b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 228, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b477dc4b-2593-4d8d-8cf9-7687938223d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 3, 30, 0, 0)), new Guid("38c7dbd7-c9ad-45e6-88cf-8269be9069c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bfab4a1-6d72-4006-b5ff-5571bf4c035b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0aba4c33-dab5-4e57-8206-e94fb1d7b8e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bcfa756-2b89-4878-a5b1-5c8c4cbec50d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6063544-d0c9-4826-b30b-4bf4d7ad1b6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("944000a6-4e2c-4372-8942-93830180b3a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 223, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e12fad91-9ebb-4126-aad6-6402dd227bfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(9194), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9107a895-1d8c-4e38-a134-fce160fcc97c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6c12cfd-d67f-4c95-b166-f3c0598d7641") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf22f574-f3a8-43b1-b3e8-6d4c5079c99c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2c1ecdc-ff14-4dba-ad3e-0d8501c41177") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51151ab7-7966-43b9-bc0f-4097d1ed9d75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0b9e522-afe3-496e-a4bf-38adf1c105d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 3, 30, 0, 0)), new Guid("172a2afc-fb77-4fbb-9249-b4e30f42ed67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b37961f-3c5e-4828-befa-3b9d11971093") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(1335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a88ddbf-c3ec-4221-8e5d-d4082691ef1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fb67908c-0f5c-42ae-a90a-f4054768e655") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("631d4b42-7d75-4ca7-8240-7433cd730bb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15486cbe-db10-4e77-b0e4-5822553726b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07f2408e-798b-4a28-9b8a-f014a76688f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9dc2f721-8322-41b6-8760-a65b91f7cf46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, 3, 30, 0, 0)), new Guid("505e9357-3f6b-43c1-b725-e4ea73391b87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27cccab9-c3c7-4c54-abf7-7d29e0bdf115") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28d725d8-bd70-4ebf-8a14-928be816b24b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7181bbd-355a-4185-8ef7-67ffb2c5eac4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 226, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f08c7ac-bbdd-4fd3-af69-7810b6c03de9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a571e31-87b9-42cc-8a84-a8f0f3022f6b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4250e1b4-66a3-4917-b6e6-4d4f9e880c6a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e11e951-6ef3-447b-b050-47cf7e9b3ecd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1268baac-9433-4bb9-8c61-34547cb0074c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 224, DateTimeKind.Unspecified).AddTicks(234), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc306c08-40fc-4d12-8bfa-a60989709aac") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4becb24d-268a-48ff-80b6-4e7f565ca787") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 225, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86339ca7-4034-4ab0-ab58-0c1ee3da9bc7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 15, 11, 41, 34, 222, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bfbeb85-27dd-48a4-96e7-60e28116b95a") });
        }
    }
}
