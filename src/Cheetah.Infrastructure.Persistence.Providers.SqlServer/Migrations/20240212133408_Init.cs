using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dimentions");

            migrationBuilder.EnsureSchema(
                name: "Facts");

            migrationBuilder.EnsureSchema(
                name: "Links");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_CaseState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 67, DateTimeKind.Unspecified).AddTicks(2911), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("47143842-c165-4421-806b-db13a6072f20")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_CaseState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Entity",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 67, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("b1f0f3f0-4458-4d1d-94b9-bda7891afc73")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Display = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Location",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 67, DateTimeKind.Unspecified).AddTicks(9832), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("9dbe99a6-968c-4260-9324-4d55574eecdc")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 68, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("7afd3e40-593b-4530-8fbb-01460bc8d176")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Process",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 68, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1c86151e-f316-47d6-8dd9-8f594d871b09")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ERP = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ShowSupport = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_TagType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 69, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("b82ccc64-cca7-4b9a-b0c5-270ff6b83101")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_TagType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 70, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d0c5c3ae-99b4-4405-805f-9ff62f229a70")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotifByEmail = table.Column<bool>(type: "bit", nullable: true),
                    NotifByMessenger = table.Column<bool>(type: "bit", nullable: true),
                    NotifByCell = table.Column<bool>(type: "bit", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactMessenger = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactCell = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InternalPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UserInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 70, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("496b29dc-890c-4547-9fca-c9c7ccdba5ef")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_WorkItemState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 71, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("17318914-9744-47e1-9ee1-85c4d9bdbcbf")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: ""),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 73, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("cc1e3c57-a7dc-41d2-8e6f-e00f623af0dc")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Scenario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_Flow",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 72, DateTimeKind.Unspecified).AddTicks(9591), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("dd17e4bc-4868-49fa-be98-109d58d42794")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Flow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Flow_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Tag",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 68, DateTimeKind.Unspecified).AddTicks(9992), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("0ed0d202-630b-4796-9578-52e9a875a7d7")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagType_TagTypeId",
                        column: x => x.TagTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 69, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("978e4ca7-a531-4781-9808-6cc04b3546ce")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DelegateEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    UserInformationId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_D_UserInformation_UserInformationId",
                        column: x => x.UserInformationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UserInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_DelegateId",
                        column: x => x.DelegateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Task",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 74, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("28479e92-1be7-42cf-86fa-f56627ec2235")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Task_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_ProcessScenario",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 76, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a0f6ccee-f0d0-455e-bb86-24953979e510")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ProcessScenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    IU_UserId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_D_User_IU_UserId",
                        column: x => x.IU_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Case",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 71, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("58ff6c76-034c-420a-9a0a-80c27560025c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Case_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_CreatorId",
                        column: x => x.CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_RequestorId",
                        column: x => x.RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                        column: x => x.SelectedScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_FlowTask",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 76, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("abe8edb3-b4f7-4977-8109-3cd0d8cc769c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_FlowTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_FlowTask_F_Flow_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_FlowTask_F_Task_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_TaskFlow",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 77, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("14b6ad30-e2e8-449f-a0db-166bcccc1038")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_TaskFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TaskFlow_F_Flow_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_TaskFlow_F_Task_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_WorkItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 74, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1efc81cd-f4c5-428b-ba47-c0dae61f8e7b")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TaskId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    WorkItemStateId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                        column: x => x.WorkItemStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_WorkItemState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_CaseTaskUser",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 75, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8853ce62-cde6-453c-96bc-826d207c40e8")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_CaseTaskUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_D_User_ThirdId",
                        column: x => x.ThirdId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_F_Case_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_F_Task_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 72, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("f303bef6-b7d8-4bd5-8eb5-825f2d0dced2")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    WorkItemId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Operand_OperandId",
                        column: x => x.OperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_User_D_UserId",
                        column: x => x.D_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_WorkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalSchema: "Facts",
                        principalTable: "F_WorkItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_FlowCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 75, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("03e648c8-b22f-410d-b612-7a357244b491")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_FlowCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_FlowCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_FlowCondition_F_Flow_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_ScenarioCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 76, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("4a1af4d4-6da0-4432-90ee-cd3e7c8899e3")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ScenarioCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_TaskCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 77, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("adbd54d1-c3df-4d06-9810-540a414e1ceb")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_TaskCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TaskCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_TaskCondition_F_Task_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 8, 77, DateTimeKind.Unspecified).AddTicks(8355), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3c44387c-484d-4978-a031-76a8e2c17690")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserCondition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9274), new TimeSpan(0, 3, 30, 0, 0)), null, "مقداردهی اولیه", 1L, true, new Guid("ad935af3-22d2-47d1-a1f6-2fa8a3b4447f"), null, null, "Initializing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9279), new TimeSpan(0, 3, 30, 0, 0)), null, "در دست بررسی", 2L, true, new Guid("a58aac61-e5f3-451f-ab69-d25eb4af24d8"), null, null, "Ongoing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 3, 30, 0, 0)), null, "منتظر بازنگری", 3L, true, new Guid("858cad04-f4a6-42b9-bc03-0d485be85db8"), null, null, "Editing", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9284), new TimeSpan(0, 3, 30, 0, 0)), null, "کامل شده", 4L, true, new Guid("1ae2b809-c112-4d1b-895a-d4441def8e2f"), null, null, "Completed", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 3, 30, 0, 0)), null, "عدم تایید", 5L, true, new Guid("bf5629cd-4078-46ac-9b94-b246c33ec7e3"), null, null, "Rejected", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(9294), new TimeSpan(0, 3, 30, 0, 0)), null, "ابطال شده", 6L, true, new Guid("9ee8045d-65a3-4e58-a6e8-970484abb52d"), null, null, "Aborted", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "CreatedBy", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 715, DateTimeKind.Unspecified).AddTicks(6902), new TimeSpan(0, 3, 30, 0, 0)), null, false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("d1637523-f92f-41a8-8ea8-8646ac2fe631"), null, null, "D_TagType", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 3, 30, 0, 0)), null, false, "عملگرها(Dimentions)", 102L, true, new Guid("da0e9c57-7180-4716-b40b-53e1c9968c4d"), null, null, "D_Operand", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 3, 30, 0, 0)), null, true, "تگ‌ها(Dimentions)", 103L, true, new Guid("3a9fc9d7-9fac-4570-a9ee-9d9612e965b3"), null, null, "D_Tag", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 3, 30, 0, 0)), null, false, "وضعیت فرآیندها(Dimentions)", 104L, true, new Guid("1379b2eb-e59c-4715-a92b-fdf744c00ab6"), null, null, "D_CaseState", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 3, 30, 0, 0)), null, true, "فرآیند‌ها(Dimentions)", 105L, true, new Guid("c11f7536-7c4c-4333-aa61-12f2559501b2"), null, null, "D_Process", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 3, 30, 0, 0)), null, true, "کاربران(Dimentions)", 106L, true, new Guid("0c711cb2-83ea-4b36-9330-a7d71c863fdc"), null, null, "D_User", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات کاربرها(Facts)", 107L, true, new Guid("c7a284c8-261f-4b41-9e6f-024dd35a618e"), null, null, "D_UserInformation", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 3, 30, 0, 0)), null, false, "تمام تاییدها(Facts)", 108L, true, new Guid("d18969e8-f287-4d38-ae02-0a37139130d1"), null, null, "F_WorkItem", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 3, 30, 0, 0)), null, false, "ضمیمه‌ها(Facts)", 109L, true, new Guid("ae41c59f-616a-4998-94ab-b6f9a99f88e5"), null, null, "F_Attachment", 109L },
                    { 110L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6786), new TimeSpan(0, 3, 30, 0, 0)), null, false, "لیست تخصیص‌ها(Facts)", 110L, true, new Guid("86b910eb-0971-4f11-9586-a9615dc6d241"), null, null, "F_Task", 110L },
                    { 111L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6792), new TimeSpan(0, 3, 30, 0, 0)), null, true, "لیست شرط‌ها(Facts)", 111L, true, new Guid("6db1abe6-e3ee-422a-9637-eb68a611f3ce"), null, null, "F_Condition", 111L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6798), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات درخواست‌ها(Facts)", 112L, true, new Guid("1be9c728-ec80-493c-a1a0-b4b1d8a4d7c8"), null, null, "F_Case", 112L },
                    { 113L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 3, 30, 0, 0)), null, true, "سناریوها(Facts)", 113L, true, new Guid("1c337c94-8638-4c0a-955a-a9f00416937a"), null, null, "F_Scenario", 113L },
                    { 114L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 3, 30, 0, 0)), null, false, "فرآیند-سناریو(Links)", 114L, true, new Guid("2812a340-d432-452b-a743-9018bb0ce8e7"), null, null, "L_ProcessScenario", 114L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 3, 30, 0, 0)), null, "مساوی", 1L, true, new Guid("859d045f-bfad-4137-bad6-37656017e85e"), null, null, "=", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9144), new TimeSpan(0, 3, 30, 0, 0)), null, "مخالف", 2L, true, new Guid("b3b85359-c63e-4f5b-b20c-f141721c746c"), null, null, "!=", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9147), new TimeSpan(0, 3, 30, 0, 0)), null, "بزگتر از", 3L, true, new Guid("11d3a8a9-9ed8-41bf-b4eb-7970261ae44c"), null, null, ">", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 3, 30, 0, 0)), null, "بزرگتر و مساوی", 4L, true, new Guid("2527bbbd-2e7f-4ed4-9667-1af5a665fcc6"), null, null, ">=", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 3, 30, 0, 0)), null, " کوچکتر از", 5L, true, new Guid("74dc31e5-cc97-45da-b8b4-b87b58496e46"), null, null, "<", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 716, DateTimeKind.Unspecified).AddTicks(9155), new TimeSpan(0, 3, 30, 0, 0)), null, "کوچکتر و مساوی", 6L, true, new Guid("eee423cd-d2c5-4205-9d71-bbcf21a82d1c"), null, null, "<=", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه", true, 1L, true, new Guid("d5cf9490-4608-4081-b229-006148c389c8"), null, null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", 1L, true, new Guid("f49546a2-17be-4940-96d9-ee022274e619"), null, null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(4650), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", 2L, true, new Guid("369d996f-a116-4d2b-bee7-e8dfdafe9804"), null, null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 3, 30, 0, 0)), null, "تاریخ", 3L, true, new Guid("91ffe319-cb6d-4dbc-9dec-c049e5831937"), null, null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", 4L, true, new Guid("01c4afc4-6abc-4488-99e6-7ea28de8b486"), null, null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Created", "CreatedBy", "DelegateId", "DisplayName", "Domain", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModified", "LastModifiedBy", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(8313), new TimeSpan(0, 3, 30, 0, 0)), null, null, "محمد شریفی", null, 1L, true, new Guid("fc6ce9e1-8e1e-47b7-b7ee-4069e761d592"), null, null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(8344), new TimeSpan(0, 3, 30, 0, 0)), null, null, "امین شریفی", null, 2L, true, new Guid("18640c71-328d-4680-b188-1083d0563809"), null, null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 3, 30, 0, 0)), null, "صندوق ورودی", 1L, true, new Guid("e9985175-a8c0-454a-a8cb-a2e2c3e77e3d"), null, null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(9769), new TimeSpan(0, 3, 30, 0, 0)), null, "ارسال شده", 2L, true, new Guid("3aaf500b-f0c0-49ad-baf0-aee6d21c5580"), null, null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)), null, "خارج شده", 3L, true, new Guid("0801ffb8-150e-4fb6-ae65-2a6fe89a4f84"), null, null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(9775), new TimeSpan(0, 3, 30, 0, 0)), null, "آینده", 4L, true, new Guid("a80fc679-e918-4bde-8fbf-cab4ae8ff259"), null, null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(5328), new TimeSpan(0, 3, 30, 0, 0)), null, "سناریو نمونه", 1L, true, new Guid("b8099ea3-1c87-4f98-94fc-5f8475ff2575"), null, null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(3404), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "تایید", 1L, true, new Guid("b5f87e3c-4aff-4d38-8744-67221850545d"), null, null, "Approve", 1L, 2L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "عدم تایید", 2L, true, new Guid("09748b0a-e12e-4433-90c7-fecf5dd87969"), null, null, "Reject", 2L, 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5182), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "بازنگری", 3L, true, new Guid("b0d4393b-9071-4162-b75f-897bcb2b207d"), null, null, "Revise", 3L, 2L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "موقعیت", 4L, true, new Guid("be149b58-5ca9-4d6e-897d-1627934deba8"), null, null, "Location", 4L, 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5188), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "نقش", 5L, true, new Guid("c8216b65-a920-4961-ac52-74be5ef54392"), null, null, "Role", 5L, 4L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "سمت", 6L, true, new Guid("b613da2a-ef23-47ae-bc92-6570b6daef44"), null, null, "Position", 6L, 4L },
                    { 7L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "مدیر این پرسنل", 7L, true, new Guid("759e9434-df3a-41b7-ae3b-869164a34498"), null, null, "Employees", 7L, 4L },
                    { 8L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 717, DateTimeKind.Unspecified).AddTicks(5199), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", "مبلغ", 8L, true, new Guid("d02c558d-b068-4862-9125-d728b49409e4"), null, null, "Price", 8L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Task",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(7218), new TimeSpan(0, 3, 30, 0, 0)), null, "ثبت درخواست", 1L, true, new Guid("68ef5e58-1170-4bde-b580-15a6376dedc9"), null, null, "Sample_Scenario_Requestor", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 714, DateTimeKind.Unspecified).AddTicks(7421), new TimeSpan(0, 3, 30, 0, 0)), null, "بررسی درخواست", 2L, true, new Guid("16b719f2-4bbc-47d9-9a4a-400a6dd42278"), null, null, "Sample_Scenario_RequestorManager", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 12, 17, 4, 7, 713, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه-سناریو نمونه", 1L, true, null, 1L, null, new Guid("17e3ead6-ce5c-43ae-aff5-a4bb2ae64f4b"), null, null, "SampleProcess_SampleScenario", 1L, 1L, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IU_UserId",
                table: "AspNetUsers",
                column: "IU_UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Created",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Name",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Created",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Display",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Display");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Name",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Created",
                schema: "Dimentions",
                table: "D_Location",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EnableRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_ERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_LastModified",
                schema: "Dimentions",
                table: "D_Location",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Name",
                schema: "Dimentions",
                table: "D_Location",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Created",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Name",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Created",
                schema: "Dimentions",
                table: "D_Process",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_LastModified",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Name",
                schema: "Dimentions",
                table: "D_Process",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Created",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Name",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Created",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Name",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Created",
                schema: "Dimentions",
                table: "D_User",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_ERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_LastModified",
                schema: "Dimentions",
                table: "D_User",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Name",
                schema: "Dimentions",
                table: "D_User",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Created",
                schema: "Facts",
                table: "F_Attachment",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_LastModified",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Name",
                schema: "Facts",
                table: "F_Attachment",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Created",
                schema: "Facts",
                table: "F_Case",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_EnableRecord",
                schema: "Facts",
                table: "F_Case",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ERPCode",
                schema: "Facts",
                table: "F_Case",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_LastModified",
                schema: "Facts",
                table: "F_Case",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Name",
                schema: "Facts",
                table: "F_Case",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CaseId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Created",
                schema: "Facts",
                table: "F_Condition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_LastModified",
                schema: "Facts",
                table: "F_Condition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Name",
                schema: "Facts",
                table: "F_Condition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_CaseStateId",
                schema: "Facts",
                table: "F_Flow",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_Created",
                schema: "Facts",
                table: "F_Flow",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_ERPCode",
                schema: "Facts",
                table: "F_Flow",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_LastModified",
                schema: "Facts",
                table: "F_Flow",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_Name",
                schema: "Facts",
                table: "F_Flow",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Created",
                schema: "Facts",
                table: "F_Scenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_LastModified",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Name",
                schema: "Facts",
                table: "F_Scenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_Created",
                schema: "Facts",
                table: "F_Task",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_EnableRecord",
                schema: "Facts",
                table: "F_Task",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_ERPCode",
                schema: "Facts",
                table: "F_Task",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_LastModified",
                schema: "Facts",
                table: "F_Task",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_Name",
                schema: "Facts",
                table: "F_Task",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_ScenarioId",
                schema: "Facts",
                table: "F_Task",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Created",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Name",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId");

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_ERPCode",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FifthId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FourthId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_Name",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_Created",
                schema: "Links",
                table: "L_FlowCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_ERPCode",
                schema: "Links",
                table: "L_FlowCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FifthId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FirstId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FourthId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_Name",
                schema: "Links",
                table: "L_FlowCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_ThirdId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_Created",
                schema: "Links",
                table: "L_FlowTask",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_ERPCode",
                schema: "Links",
                table: "L_FlowTask",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FifthId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FirstId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FourthId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_LastModified",
                schema: "Links",
                table: "L_FlowTask",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_Name",
                schema: "Links",
                table: "L_FlowTask",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_SecondId",
                schema: "Links",
                table: "L_FlowTask",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_ThirdId",
                schema: "Links",
                table: "L_FlowTask",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Created",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Name",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_ERPCode",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FifthId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FourthId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_Name",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_ThirdId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_Created",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FifthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FourthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_Name",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ThirdId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_Created",
                schema: "Links",
                table: "L_TaskFlow",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_ERPCode",
                schema: "Links",
                table: "L_TaskFlow",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FifthId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FirstId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FourthId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_Name",
                schema: "Links",
                table: "L_TaskFlow",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_SecondId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_ThirdId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Created",
                schema: "Links",
                table: "L_UserCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FifthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FourthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_LastModified",
                schema: "Links",
                table: "L_UserCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Name",
                schema: "Links",
                table: "L_UserCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ThirdId",
                schema: "Links",
                table: "L_UserCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "D_Entity",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Attachment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "L_CaseTaskUser",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_FlowCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_FlowTask",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ScenarioCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_TaskCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_TaskFlow",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "F_Flow",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Condition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Task",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_CaseState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");
        }
    }
}
