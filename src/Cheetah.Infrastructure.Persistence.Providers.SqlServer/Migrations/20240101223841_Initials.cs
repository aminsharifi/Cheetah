using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 150, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 151, DateTimeKind.Unspecified).AddTicks(98), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("5f439273-ba88-47da-9e99-cbe40fc29f93")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 151, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 151, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("667968b0-0e51-49a8-8bd7-e970f75ae010")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Display = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 153, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 153, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("83329a5b-6759-4a43-9ddb-09bbfb24ef80")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Position",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 153, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 153, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d2a3b76d-76b8-4855-8909-1284ba237c88")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Process",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 154, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 154, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a5829f9e-8bac-41e4-be10-d2b2db066a56")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ERP = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ShowSupport = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Role",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 155, DateTimeKind.Unspecified).AddTicks(161), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 155, DateTimeKind.Unspecified).AddTicks(613), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("ff057eee-f55f-4442-a690-86f54d15222f")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Independent = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FixedRole = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_TagType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 156, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 156, DateTimeKind.Unspecified).AddTicks(7242), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("ca240cb6-6b8f-430d-aee1-4fe2b5400abc")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 157, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 157, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("0358f5ef-4df3-4dda-bc2d-f9735ea33eea")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 158, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 158, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("bcace081-0d0a-4c3f-9ec9-304eb05a5c25")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 158, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 158, DateTimeKind.Unspecified).AddTicks(7726), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d6d19f74-8e35-41ff-8713-a929d5a5d13e")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: ""),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 163, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 163, DateTimeKind.Unspecified).AddTicks(3451), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("17e8cd1e-0ff6-4a39-82f5-457cf354b040")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
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
                name: "L_RolePosition",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Role_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Tag",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 155, DateTimeKind.Unspecified).AddTicks(8390), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 155, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("cc1ed8df-bf80-451c-a10f-f5c4eaa255a0")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagTypeId = table.Column<long>(type: "bigint", nullable: true)
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
                    Domain = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DelegateEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    UserInformationId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                name: "L_ProcessScenario",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
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
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
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
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 159, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 159, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("9195babd-836b-4e61-9e48-0d14bfefdacb")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "L_UserPosition",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
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
                name: "D_Location",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 152, DateTimeKind.Unspecified).AddTicks(3940), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 152, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("035f01c9-b223-43cf-8610-6a47cca6cd22")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L_UserLocation",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 160, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 160, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d67b9b06-5482-42e6-92c6-123429dace97")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_F_Condition_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Endorsement",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 161, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 161, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("ba0f4696-2aba-45e1-b646-3a5269e7c768")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                    ConditionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Endorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Endorsement_D_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Condition_ConditionId",
                        column: x => x.ConditionId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_EndorsementItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 162, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 162, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("e4355ea6-15ed-486d-8071-3966a7b1825a")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_WorkItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 164, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 3, 30, 0, 0))),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 40, 164, DateTimeKind.Unspecified).AddTicks(2767), new TimeSpan(0, 3, 30, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("bd9d5228-a2a4-4fc0-8fe8-061952f14801")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    WorkItemStateId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
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
                        name: "FK_F_WorkItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_EndorsementUser",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EndorsementUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_F_Endorsement_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_EndorsementItemEndorsement",
                schema: "Links",
                columns: table => new
                {
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTimeRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedRecord = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EndorsementItemEndorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_EndorsementItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_Endorsement_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 3, 30, 0, 0)), "در دست بررسی", 1L, true, new Guid("89d4e884-a04b-484d-8426-b81d5dd567d4"), "Ongoing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 3, 30, 0, 0)), "منتظر بازنگری", 2L, true, new Guid("95482bf2-b673-4911-bdfe-ca8539c1c788"), "Editing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 3, 30, 0, 0)), "کامل شده", 3L, true, new Guid("a4c471e5-b176-4d59-b9c4-9be099249125"), "Completed", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", 4L, true, new Guid("2a4725b3-ab14-4b3d-84cc-4cee1f87f5c6"), "Rejected", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 3, 30, 0, 0)), "ابطال شده", 5L, true, new Guid("9b9a910a-73e0-4230-8ebe-136a90539d9d"), "Aborted", 5L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 215, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 3, 30, 0, 0)), false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("1ac61008-66d2-4a24-9d40-370e7119c210"), "D_TagType", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3302), new TimeSpan(0, 3, 30, 0, 0)), false, "موقعیت‌ها(Dimentions)", 102L, true, new Guid("101f466d-440c-42d1-ab4d-502b81c05f64"), "D_Location", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 3, 30, 0, 0)), false, "عملگرها(Dimentions)", 103L, true, new Guid("40df96ab-dfdf-4655-bb25-c6250cbd7972"), "D_Operand", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3443), new TimeSpan(0, 3, 30, 0, 0)), true, "تگ‌ها(Dimentions)", 104L, true, new Guid("9bb303af-e1e8-4c38-94c4-79c204831d95"), "D_Tag", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3461), new TimeSpan(0, 3, 30, 0, 0)), false, "سمت‌ها(Dimentions)", 105L, true, new Guid("17202ceb-05aa-4cc0-b572-49d2a654f1c4"), "D_Position", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 3, 30, 0, 0)), false, "وضعیت فرآیندها(Dimentions)", 106L, true, new Guid("5e075699-6587-40fa-a017-54a06f6d1a10"), "D_CaseState", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 3, 30, 0, 0)), true, "فرآیند‌ها(Dimentions)", 107L, true, new Guid("49b03f1c-b05e-4306-b1aa-19d5dcc1bee6"), "D_Process", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 3, 30, 0, 0)), true, "نقش‌ها(Dimentions)", 108L, true, new Guid("959a0f36-d0e5-4f63-885f-293a418122ad"), "D_Role", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, 3, 30, 0, 0)), true, "کاربران(Dimentions)", 109L, true, new Guid("1000badf-3535-409e-8832-012ca36b8f07"), "D_User", 109L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات کاربرها(Facts)", 112L, true, new Guid("8e14479d-11d0-46c6-a75c-4bc055108f75"), "D_UserInformation", 112L },
                    { 200L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 3, 30, 0, 0)), false, "تمام تاییدها(Facts)", 200L, true, new Guid("aed67cbb-864a-48b7-9677-9bcfd490abd2"), "F_WorkItem", 200L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3603), new TimeSpan(0, 3, 30, 0, 0)), false, "ضمیمه‌ها(Facts)", 202L, true, new Guid("0087c84a-a690-4579-80b9-bafdc94b724d"), "F_Attachment", 202L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3609), new TimeSpan(0, 3, 30, 0, 0)), false, "لیست تخصیص‌ها(Facts)", 203L, true, new Guid("95fcff24-b1cf-4fc1-88c2-4f71c2770860"), "F_Endorsement", 203L },
                    { 204L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3668), new TimeSpan(0, 3, 30, 0, 0)), false, "لیست شرط‌ها(Facts)", 204L, true, new Guid("5748cb0f-e189-4117-9209-b6f488851376"), "F_Condition", 204L },
                    { 205L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات درخواست‌ها(Facts)", 205L, true, new Guid("49573f9c-7b51-423c-aba4-432700bdb84f"), "F_Case", 205L },
                    { 206L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 30, 0, 0)), true, "سناریوها(Facts)", 206L, true, new Guid("1e980b9b-c0d5-4bce-a14c-e1a80053a8fe"), "F_Scenario", 206L },
                    { 300L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3692), new TimeSpan(0, 3, 30, 0, 0)), false, "نقش-سمت(Links)", 300L, true, new Guid("d4c078a5-7a43-403d-b0de-9d5e010ec5d9"), "L_RolePosition", 300L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, 3, 30, 0, 0)), false, "فرآیند-سناریو(Links)", 301L, true, new Guid("c8abf036-29fa-4335-82ef-a3a6fced9cff"), "L_ProcessScenario", 301L },
                    { 302L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 3, 30, 0, 0)), false, "کاربر-موقعیت(Links)", 302L, true, new Guid("05df7904-4fdf-4b9d-9030-c87e59ab72d6"), "L_UserLocation", 302L },
                    { 303L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, 3, 30, 0, 0)), false, "کاربر-سمت(Links)", 303L, true, new Guid("e417056b-c8e3-47e3-9204-6ebea49cb915"), "L_UserPosition", 303L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 217, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 3, 30, 0, 0)), "فارس", 1L, true, null, new Guid("418514f1-3bd5-47a7-a035-684228178d49"), "Fars", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 3, 30, 0, 0)), "مساوی", 1L, true, new Guid("ccf266f7-3fdb-4eb4-96cf-df8438848185"), "=", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(637), new TimeSpan(0, 3, 30, 0, 0)), "مخالف", 2L, true, new Guid("ea29030c-939e-4e47-9e56-366d184e4bfa"), "!=", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(647), new TimeSpan(0, 3, 30, 0, 0)), "بزگتر از", 3L, true, new Guid("243b9d8d-648f-4cca-b2b4-03efb5a5e9be"), ">", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 3, 30, 0, 0)), "بزرگتر و مساوی", 4L, true, new Guid("7636530e-88e1-46ec-a5ba-3e89015f952a"), ">=", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 3, 30, 0, 0)), " کوچکتر از", 5L, true, new Guid("00ca11e4-fd19-4fb5-9fa9-7c2c418da1a6"), "<", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر و مساوی", 6L, true, new Guid("45006648-db2b-4d5d-b2ac-182bce4d99d9"), "<=", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(3785), new TimeSpan(0, 3, 30, 0, 0)), "کارشناس", 1L, true, new Guid("64811158-323c-4c83-ad73-756e69aeadd4"), "Expert", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(5897), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند نمونه", true, 1L, true, new Guid("ab4407a8-2bfc-4cfe-bcbb-19fbdc6890c2"), "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "FixedRole", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 100L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(8419), new TimeSpan(0, 3, 30, 0, 0)), "درخواست کننده", 100L, true, true, new Guid("f52333b4-f4cc-46ad-afe0-dbf7a4bc0e59"), "Requestor", 100L },
                    { 101L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 218, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 3, 30, 0, 0)), "مدیر درخواست کننده", 101L, true, true, new Guid("48cf41d1-3115-48b7-bff4-474d9760d247"), "RequestorManager", 101L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(7992), new TimeSpan(0, 3, 30, 0, 0)), "عددی", 1L, true, new Guid("518be551-e9dc-44b8-a30a-188df359c0ff"), "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", 2L, true, new Guid("4dbd05c5-e7db-4ad4-8189-d4ff90d31760"), "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 3, 30, 0, 0)), "تاریخ", 3L, true, new Guid("8fbd24bb-fd4a-4fb3-8938-0e5b7c660e2a"), "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 3, 30, 0, 0)), "حروف", 4L, true, new Guid("31976beb-3e17-4103-a2ee-934abf928956"), "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 220, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 3, 30, 0, 0)), "صندوق ورودی", 1L, true, new Guid("d73e35f6-38a1-4829-a8b8-37fd7b4e333c"), "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 220, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 3, 30, 0, 0)), "ارسال شده", 2L, true, new Guid("a46612d2-5602-478a-b34a-f1ffceddeedb"), "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 220, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 3, 30, 0, 0)), "خارج شده", 3L, true, new Guid("5f2e5e83-4a8c-4b54-b5d7-86d19577c8b9"), "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 220, DateTimeKind.Unspecified).AddTicks(1156), new TimeSpan(0, 3, 30, 0, 0)), "آینده", 4L, true, new Guid("a249c477-d6c3-4641-9a6f-85bb03d09873"), "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(3934), new TimeSpan(0, 3, 30, 0, 0)), "سناریو نمونه", 1L, true, new Guid("460088bb-8d2e-4968-a11a-380cf7ba458e"), "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(3877), new TimeSpan(0, 3, 30, 0, 0)), "عددی", "مرکز", 1L, true, new Guid("15e847c3-e44c-4e00-a134-0ca8a80d725b"), "D_Location", 1L, 1L },
                    { 201L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 3, 30, 0, 0)), "پارامتریک", "تایید", 201L, true, new Guid("bea49889-364f-4ea5-a9ad-8ffde5486233"), "Approve", 201L, 2L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(4706), new TimeSpan(0, 3, 30, 0, 0)), "پارامتریک", "عدم تایید", 202L, true, new Guid("5bdfdb1e-1991-413f-bc22-e55be3881818"), "Reject", 202L, 2L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(4826), new TimeSpan(0, 3, 30, 0, 0)), "پارامتریک", "بازنگری", 203L, true, new Guid("849378c9-0652-4d8f-ba74-02be71b4af32"), "Revise", 203L, 2L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 219, DateTimeKind.Unspecified).AddTicks(4841), new TimeSpan(0, 3, 30, 0, 0)), "عددی", "مبلغ", 301L, true, new Guid("cf2c8fcd-3c34-49ff-8611-e0fa9e461d27"), "Price", 301L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "ConditionId", "CreateTimeRecord", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "Name", "RoleId", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 211, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, 3, 30, 0, 0)), "ثبت درخواست", 1L, true, null, new Guid("88858e14-c2db-4afa-833c-a274da5266e6"), "Sample_Scenario__Requestor", 100L, 1L, 1L },
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 211, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", 2L, true, null, new Guid("278cc6bd-8a35-4ba5-a892-c1cbaa8f2d13"), "Sample_Scenario__RequestorManager", 101L, 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CaseId", "CreateTimeRecord", "D_UserId", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value" },
                values: new object[] { 1L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 209, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 3, 30, 0, 0)), null, "مبلغ", 1L, true, null, new Guid("720ccbc3-d922-47f7-8439-579e16b1ae7a"), "Price", 3L, 1L, 1L, 301L, "0" });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_EndorsementItem",
                columns: new[] { "Id", "CaseStateId", "CreateTimeRecord", "ERPCode", "EnableRecord", "EndorsementId", "GuidRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 3, 30, 0, 0)), 1L, true, 1L, new Guid("844f15af-7202-4ef7-94b6-6d616a0140fa"), "one", 1L },
                    { 2L, 3L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 3, 30, 0, 0)), 2L, true, 2L, new Guid("9b2ceb78-e295-449f-b348-195d3680257a"), "two", 1L },
                    { 3L, 2L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(988), new TimeSpan(0, 3, 30, 0, 0)), 3L, true, 2L, new Guid("e79a3585-a792-419f-82a7-90d95320e1c1"), "Three", 2L },
                    { 4L, 4L, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 212, DateTimeKind.Unspecified).AddTicks(994), new TimeSpan(0, 3, 30, 0, 0)), 4L, true, 2L, new Guid("890369bb-1e5f-4191-9eb0-d50c82a2af32"), "Four", 3L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CaseId", "CreateTimeRecord", "D_UserId", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 210, DateTimeKind.Unspecified).AddTicks(2271), new TimeSpan(0, 3, 30, 0, 0)), null, 2L, true, 1L, new Guid("48147843-2868-4073-b9f6-65ce9ad06e7d"), "One", 1L, null, 1L, 201L, "0" },
                    { 3L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 210, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 3, 30, 0, 0)), null, 3L, true, 2L, new Guid("bbd32109-a82c-4c3c-be5a-f638f2c8ff68"), "Two", 1L, null, 1L, 201L, "0" },
                    { 4L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 210, DateTimeKind.Unspecified).AddTicks(2662), new TimeSpan(0, 3, 30, 0, 0)), null, 4L, true, 3L, new Guid("850bd914-0fc3-4102-89c6-81cdac877b0d"), "Three", 1L, null, 1L, 203L, "0" },
                    { 5L, null, new DateTimeOffset(new DateTime(2024, 1, 2, 2, 8, 39, 210, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 3, 30, 0, 0)), null, 5L, true, 4L, new Guid("02a6e880-f320-45ff-89b7-7716981b4a30"), "Four", 1L, null, 1L, 202L, "1" }
                });

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
                name: "IX_D_CaseState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "CreateTimeRecord",
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
                name: "IX_D_CaseState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Name",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "CreateTimeRecord",
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
                name: "IX_D_Entity_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Name",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EnableRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_ERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Name",
                schema: "Dimentions",
                table: "D_Location",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "CreateTimeRecord",
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
                name: "IX_D_Operand_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Name",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_EnableRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_ERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Name",
                schema: "Dimentions",
                table: "D_Position",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "CreateTimeRecord",
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
                name: "IX_D_Process_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Name",
                schema: "Dimentions",
                table: "D_Process",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_EnableRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_ERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Independent",
                schema: "Dimentions",
                table: "D_Role",
                column: "Independent");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Name",
                schema: "Dimentions",
                table: "D_Role",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "CreateTimeRecord",
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
                name: "IX_D_Tag_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Name",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "CreateTimeRecord",
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
                name: "IX_D_TagType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Name",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId");

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
                name: "IX_D_UserInformation_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "CreateTimeRecord",
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
                name: "IX_D_UserInformation_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "CreateTimeRecord",
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
                name: "IX_D_WorkItemState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "CreateTimeRecord",
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
                name: "IX_F_Attachment_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Name",
                schema: "Facts",
                table: "F_Attachment",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreateTimeRecord",
                schema: "Facts",
                table: "F_Case",
                column: "CreateTimeRecord",
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
                name: "IX_F_Case_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Case",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Name",
                schema: "Facts",
                table: "F_Case",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

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
                name: "IX_F_Condition_CreateTimeRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "CreateTimeRecord",
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
                name: "IX_F_Condition_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Name",
                schema: "Facts",
                table: "F_Condition",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ScenarioId",
                schema: "Facts",
                table: "F_Condition",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ConditionId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_CreateTimeRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_EnableRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ERPCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Name",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_RoleId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ScenarioId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_CaseStateId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EnableRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EndorsementId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_ERPCode",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_Name",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_CreateTimeRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "CreateTimeRecord",
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
                name: "IX_F_Scenario_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Name",
                schema: "Facts",
                table: "F_Scenario",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CreateTimeRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CreateTimeRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EndorsementId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_LastUpdatedRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "LastUpdatedRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Name",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TagId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TagId");

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
                name: "IX_L_EndorsementItemEndorsement_FirstId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_SecondId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FirstId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_SecondId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FirstId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_SecondId",
                schema: "Links",
                table: "L_RolePosition",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FirstId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_SecondId",
                schema: "Links",
                table: "L_UserLocation",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FirstId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FirstId",
                unique: true,
                descending: new bool[0],
                filter: "[FirstId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_SecondId",
                schema: "Links",
                table: "L_UserPosition",
                column: "SecondId",
                unique: true,
                descending: new bool[0],
                filter: "[SecondId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Location_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement");

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
                name: "F_Attachment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "L_EndorsementItemEndorsement",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_EndorsementUser",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_RolePosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserPosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Position",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_EndorsementItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Endorsement",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

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
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_CaseState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");
        }
    }
}
