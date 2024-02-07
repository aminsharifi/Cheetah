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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("29ac12d4-f166-4f5c-9309-c154ca669d72")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(5461), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("b1d8d434-045c-489d-a617-ac27487ceb0c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8a4bd697-4a08-446e-96b1-5ad978db47ac")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("4b36d22c-9246-4643-a764-7d186646e843")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("c021e67c-3d3c-434a-9110-58a116f61585")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("45925529-610f-4559-ab97-a4d0aa2e6de8")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                name: "D_Role",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("f439ada9-a416-4e52-bb06-db5d1acb9973")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Independent = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FixedRole = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a2497045-ebda-47ec-b278-bb52a7042085")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("23aba9e4-5c5b-44b0-8e65-82125cdd6f09")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("0d0ff193-54a1-4760-ae17-584aa2f98517")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("81a169ef-d4ba-401f-ae75-53206ceb4941")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1cce491f-cdac-461a-b722-a5fc06040635")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                name: "F_Action",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(4865), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("ac4a6e0e-9084-494b-b2d7-00b8e6c0a48a")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Action_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_RolePosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(6067), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("faf237b8-d006-48ab-9325-f87877c7468b")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("eef57a1e-15ce-4cee-b29b-4b644d4dcc74")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3e770f6a-efc4-4c1f-8a6f-b10637456c24")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a1f47cc0-fd64-430f-a8e3-856c014ac2a4")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("88c684df-8884-4e83-ad02-3a1925e004ad")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                name: "L_UserLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("6ab94bb4-179c-45ed-b61d-1e8452e04801")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                name: "L_UserPosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("963ebe24-08bf-4d31-b2d6-597e855afa30")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("b4068e23-b96a-4fb9-bc4d-8f1bfc2b030c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    ActionId = table.Column<long>(type: "bigint", nullable: true),
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
                        name: "FK_F_Condition_F_Action_ActionId",
                        column: x => x.ActionId,
                        principalSchema: "Facts",
                        principalTable: "F_Action",
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("9c94d8e9-339c-40d1-88ed-cc0c6e83ed47")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    ConditionId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Task_D_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Task_F_Condition_ConditionId",
                        column: x => x.ConditionId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Task_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1ba507c5-b71b-4912-96a4-08ec0e82ed95")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("2be3293f-fc74-4917-9efa-7123931d9a2c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                name: "L_TaskAction",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("fc1a346f-fde0-4671-a9f0-30a19dff658d")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
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
                    table.PrimaryKey("PK_L_TaskAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TaskAction_F_Action_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Action",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_TaskAction_F_Task_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 3, 30, 0, 0)), null, "در دست بررسی", 1L, true, new Guid("19475260-09c7-42a6-a6e9-bde4adfc09bd"), null, null, "Ongoing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 3, 30, 0, 0)), null, "منتظر بازنگری", 2L, true, new Guid("8e74ab29-18a1-4b6f-a111-0f18e9a78874"), null, null, "Editing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 3, 30, 0, 0)), null, "کامل شده", 3L, true, new Guid("f5c836a4-37df-4f5f-8514-ca5a68371bbc"), null, null, "Completed", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1064), new TimeSpan(0, 3, 30, 0, 0)), null, "عدم تایید", 4L, true, new Guid("ccfb176b-2ffa-4e56-8fd6-f8a41b70f3a9"), null, null, "Rejected", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 3, 30, 0, 0)), null, "ابطال شده", 5L, true, new Guid("c1ede1c9-f61f-4201-aebe-0fd79510ed7d"), null, null, "Aborted", 5L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "CreatedBy", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 584, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 3, 30, 0, 0)), null, false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("321f14f4-882c-4273-b817-3c3197b7f9f6"), null, null, "D_TagType", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 3, 30, 0, 0)), null, false, "موقعیت‌ها(Dimentions)", 102L, true, new Guid("cbdaa45c-c5de-4ff7-b624-647f86fcae29"), null, null, "D_Location", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 3, 30, 0, 0)), null, false, "عملگرها(Dimentions)", 103L, true, new Guid("cd919d24-8068-405e-b43d-04aa6d4ceb09"), null, null, "D_Operand", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1024), new TimeSpan(0, 3, 30, 0, 0)), null, true, "تگ‌ها(Dimentions)", 104L, true, new Guid("984a95aa-403d-44eb-bfc3-0455452f9edd"), null, null, "D_Tag", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 3, 30, 0, 0)), null, false, "سمت‌ها(Dimentions)", 105L, true, new Guid("56a2fb72-b391-4eb9-88cc-67e2e512adae"), null, null, "D_Position", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 3, 30, 0, 0)), null, false, "وضعیت فرآیندها(Dimentions)", 106L, true, new Guid("e7ba93f4-807c-4749-8c88-d5f16aa85f7c"), null, null, "D_CaseState", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 3, 30, 0, 0)), null, true, "فرآیند‌ها(Dimentions)", 107L, true, new Guid("02e34806-230f-471b-b36d-da14bd9314c0"), null, null, "D_Process", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 3, 30, 0, 0)), null, true, "نقش‌ها(Dimentions)", 108L, true, new Guid("23733f3c-8f2e-4dd6-be41-b4fa6c395511"), null, null, "D_Role", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 3, 30, 0, 0)), null, true, "کاربران(Dimentions)", 109L, true, new Guid("ea1083fe-bf2c-4472-b775-b83761115f1d"), null, null, "D_User", 109L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات کاربرها(Facts)", 112L, true, new Guid("2143cca9-00ec-4657-9d94-c2977ccfd232"), null, null, "D_UserInformation", 112L },
                    { 200L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 3, 30, 0, 0)), null, false, "تمام تاییدها(Facts)", 200L, true, new Guid("336754b9-658c-4868-a17c-968be1a63ba5"), null, null, "F_WorkItem", 200L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1122), new TimeSpan(0, 3, 30, 0, 0)), null, false, "ضمیمه‌ها(Facts)", 202L, true, new Guid("7b67f284-6b8b-4aa7-9024-cc2f63e01208"), null, null, "F_Attachment", 202L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 3, 30, 0, 0)), null, false, "لیست تخصیص‌ها(Facts)", 203L, true, new Guid("b6c739eb-2a88-400d-910a-292914f80fc9"), null, null, "F_Task", 203L },
                    { 204L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 3, 30, 0, 0)), null, false, "لیست شرط‌ها(Facts)", 204L, true, new Guid("df46d271-e654-4b45-a5ab-854e90d1711c"), null, null, "F_Condition", 204L },
                    { 205L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات درخواست‌ها(Facts)", 205L, true, new Guid("eff302e1-bb50-4f12-882d-db9f6bd8a7c9"), null, null, "F_Case", 205L },
                    { 206L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 3, 30, 0, 0)), null, true, "سناریوها(Facts)", 206L, true, new Guid("394a1531-2523-4326-a204-04b587145ec8"), null, null, "F_Scenario", 206L },
                    { 300L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 3, 30, 0, 0)), null, false, "نقش-سمت(Links)", 300L, true, new Guid("1c01b035-21de-49bc-8b2c-f362dd2b8c70"), null, null, "L_RolePosition", 300L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 3, 30, 0, 0)), null, false, "فرآیند-سناریو(Links)", 301L, true, new Guid("faefefc8-f947-467c-a82e-618d24d3f209"), null, null, "L_ProcessScenario", 301L },
                    { 302L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 3, 30, 0, 0)), null, false, "کاربر-موقعیت(Links)", 302L, true, new Guid("37adffed-65ed-4025-8b5e-3cc9f6d6734e"), null, null, "L_UserLocation", 302L },
                    { 303L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 3, 30, 0, 0)), null, false, "کاربر-سمت(Links)", 303L, true, new Guid("440cb2c5-c0dd-4b47-b8f7-40c352af1f61"), null, null, "L_UserPosition", 303L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 3, 30, 0, 0)), null, "موقعیت", 1L, true, new Guid("43f8144f-8371-4a8a-bb25-7cd4232d8940"), null, null, "Fars", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 3, 30, 0, 0)), null, "مساوی", 1L, true, new Guid("06a9cbb0-6055-489e-a7d0-8f0d017d5063"), null, null, "=", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5327), new TimeSpan(0, 3, 30, 0, 0)), null, "مخالف", 2L, true, new Guid("2e77e0b9-6690-4c4e-b3d3-9af3501dfeaf"), null, null, "!=", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 3, 30, 0, 0)), null, "بزگتر از", 3L, true, new Guid("218d84f6-9821-4add-b8bc-ab7f3274af08"), null, null, ">", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 3, 30, 0, 0)), null, "بزرگتر و مساوی", 4L, true, new Guid("875a6d89-783b-4d49-a51c-bea1b2759c9b"), null, null, ">=", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 3, 30, 0, 0)), null, " کوچکتر از", 5L, true, new Guid("48ff11c8-9062-43fa-a62e-e19e21139121"), null, null, "<", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5338), new TimeSpan(0, 3, 30, 0, 0)), null, "کوچکتر و مساوی", 6L, true, new Guid("ddf48ad7-ab78-4416-a6ba-60c7f15c7e4b"), null, null, "<=", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 3, 30, 0, 0)), null, "کارشناس", 1L, true, new Guid("448940cf-e1b2-46a8-a451-5a4703dd3bcf"), null, null, "Expert", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه", true, 1L, true, new Guid("b7ceaf9a-a8be-4eac-aa5b-a974bf8631b9"), null, null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FixedRole", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 100L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 3, 30, 0, 0)), null, "درخواست کننده", 100L, true, true, new Guid("5faf2ab5-5f4a-4f1b-8903-de85d35cb808"), null, null, "Requestor", 1L },
                    { 101L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, 3, 30, 0, 0)), null, "مدیر درخواست کننده", 101L, true, true, new Guid("c975064f-eb3f-4815-b8fd-f87d17d2936b"), null, null, "RequestorManager", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", 1L, true, new Guid("8843f06f-e244-4a8d-9e05-82b60bb2fc81"), null, null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", 2L, true, new Guid("4fdfa96a-ccf8-45a3-85d4-ce5b19359727"), null, null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)), null, "تاریخ", 3L, true, new Guid("7d971c83-fbfa-4153-b0d6-67299eabb2fd"), null, null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", 4L, true, new Guid("2560fcbe-834b-44e3-b5d9-cee5dd4aed90"), null, null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Created", "CreatedBy", "DelegateId", "DisplayName", "Domain", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModified", "LastModifiedBy", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 3, 30, 0, 0)), null, null, "محمد شریفی", null, 1L, true, new Guid("ba5c3147-4921-4146-a078-eaba7ed8dbdc"), null, null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 3, 30, 0, 0)), null, null, "امین شریفی", null, 2L, true, new Guid("480a6b4c-ffb0-4788-8dd9-b88c15f74117"), null, null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6860), new TimeSpan(0, 3, 30, 0, 0)), null, "صندوق ورودی", 1L, true, new Guid("46e682a3-dc30-4aeb-8782-250571d45929"), null, null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6874), new TimeSpan(0, 3, 30, 0, 0)), null, "ارسال شده", 2L, true, new Guid("33b0e591-cc6a-4c08-b778-bf449a531b43"), null, null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 3, 30, 0, 0)), null, "خارج شده", 3L, true, new Guid("d432ec2f-d71f-49e8-b261-a86be215b0ba"), null, null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 3, 30, 0, 0)), null, "آینده", 4L, true, new Guid("c179671a-0bd2-483e-9e6d-720a2ab74ddc"), null, null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)), null, "سناریو نمونه", 1L, true, new Guid("cf5ec95a-67c9-45bc-8a26-66a1230eefca"), null, null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", "مرکز", 1L, true, new Guid("3c44d21e-7102-4e92-980a-c678a3e6e5ad"), null, null, "D_Location", 1L, 1L },
                    { 201L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "تایید", 201L, true, new Guid("828c84b9-81d2-463f-9cc8-e61d27baaeec"), null, null, "Approve", 2L, 2L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "عدم تایید", 202L, true, new Guid("b464f278-0f53-45d4-a556-25f30539c961"), null, null, "Reject", 3L, 2L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "بازنگری", 203L, true, new Guid("023cfae0-7563-46a5-a397-0404956eedbd"), null, null, "Revise", 4L, 2L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1084), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", "مبلغ", 301L, true, new Guid("79333b7b-e21f-498d-87b0-3c94e19bb6c4"), null, null, "Price", 5L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Action",
                columns: new[] { "Id", "CaseStateId", "Created", "CreatedBy", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3499), new TimeSpan(0, 3, 30, 0, 0)), null, 1L, true, new Guid("bd2d558e-f194-4ae9-be92-92c53b1d0e18"), null, null, "one", 1L },
                    { 2L, 3L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3715), new TimeSpan(0, 3, 30, 0, 0)), null, 2L, true, new Guid("3ed0ffa0-80bd-4d1b-bdf6-65cdef504a41"), null, null, "two", 1L },
                    { 3L, 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 3, 30, 0, 0)), null, 3L, true, new Guid("4fb678aa-d3a0-4c66-a857-81fd107648d2"), null, null, "Three", 2L },
                    { 4L, 4L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 3, 30, 0, 0)), null, 4L, true, new Guid("b3921197-74f9-42bb-8dad-b7e8200779bd"), null, null, "Four", 3L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Task",
                columns: new[] { "Id", "ConditionId", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "RoleId", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(9296), new TimeSpan(0, 3, 30, 0, 0)), null, "ثبت درخواست", 1L, true, new Guid("6da386c2-5698-4653-8a0a-8438c2f22b76"), null, null, "Sample_Scenario_Requestor", 100L, 1L, 1L },
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 3, 30, 0, 0)), null, "بررسی درخواست", 2L, true, new Guid("97bd45e1-887d-4da2-8dde-8e8bea9c58be"), null, null, "Sample_Scenario_RequestorManager", 101L, 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه-سناریو نمونه", 1L, true, null, 1L, null, new Guid("c9bd59e3-cfea-4278-882b-cb98233bf49d"), null, null, "SampleProcess_SampleScenario", 1L, 1L, null });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(9078), new TimeSpan(0, 3, 30, 0, 0)), null, "درخواست کننده-کارشناس", 1L, true, null, 100L, null, new Guid("c99a1044-8cb1-4083-a8a8-b9c7c830d89a"), null, null, "Requestor_Expert", 1L, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 3, 30, 0, 0)), null, "مدیر درخواست کننده-کارشناس", 2L, true, null, 101L, null, new Guid("4dbd3885-8ea2-4b16-8b9e-00965bd33c8f"), null, null, "RequestorManager_Expert", 1L, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 30, 0, 0)), null, "محمد شریفی-فارس", 1L, true, null, 1L, null, new Guid("4aa54c27-f8de-45d7-bb08-42919ec6da3e"), null, null, "m_sharifi__Fars", 1L, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 3, 30, 0, 0)), null, "امین شریفی-فارس", 2L, true, null, 2L, null, new Guid("79a96521-6657-48e5-96bd-6dfe170f0035"), null, null, "a_sharifi__Fars", 1L, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(1318), new TimeSpan(0, 3, 30, 0, 0)), null, "محمد شریفی-کارشناس", 1L, true, null, 1L, null, new Guid("d5417d11-4cdf-41fd-931a-9ce24c14967e"), null, null, "Requestor_Expert", 1L, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 30, 0, 0)), null, "امین شریفی-کارشناس", 2L, true, null, 2L, null, new Guid("73059df2-b2b9-4111-ad0d-6a12ad191d54"), null, null, "RequestorManager_Expert", 1L, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "ActionId", "CaseId", "Created", "CreatedBy", "D_UserId", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value", "WorkItemId" },
                values: new object[] { 1L, null, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)), null, null, "مبلغ", 1L, true, new Guid("544ec3c6-0b88-4661-b9e3-234c85c77022"), null, null, "Price", 3L, 1L, 1L, 301L, "0", null });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "ActionId", "CaseId", "Created", "CreatedBy", "D_UserId", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value", "WorkItemId" },
                values: new object[,]
                {
                    { 2L, 1L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 3, 30, 0, 0)), null, null, 2L, true, new Guid("455ebe78-9d95-489c-beea-2993f01872f4"), null, null, "One", 1L, null, 1L, 201L, "0", null },
                    { 3L, 2L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6690), new TimeSpan(0, 3, 30, 0, 0)), null, null, 3L, true, new Guid("5b60cc0f-d469-44bc-929d-ed8b727e048a"), null, null, "Two", 1L, null, 1L, 201L, "0", null },
                    { 4L, 3L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 30, 0, 0)), null, null, 4L, true, new Guid("03b312e1-f779-49a9-abe5-4ffccb227f1a"), null, null, "Three", 1L, null, 1L, 203L, "0", null },
                    { 5L, 4L, null, new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 3, 30, 0, 0)), null, null, 5L, true, new Guid("08e29e7d-a5f8-433d-8d25-cc319d99d219"), null, null, "Four", 1L, null, 1L, 202L, "1", null }
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
                name: "IX_D_Position_Created",
                schema: "Dimentions",
                table: "D_Position",
                column: "Created",
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
                name: "IX_D_Position_LastModified",
                schema: "Dimentions",
                table: "D_Position",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Name",
                schema: "Dimentions",
                table: "D_Position",
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
                name: "IX_D_Role_Created",
                schema: "Dimentions",
                table: "D_Role",
                column: "Created",
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
                name: "IX_D_Role_LastModified",
                schema: "Dimentions",
                table: "D_Role",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Name",
                schema: "Dimentions",
                table: "D_Role",
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
                name: "IX_F_Action_CaseStateId",
                schema: "Facts",
                table: "F_Action",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Action_Created",
                schema: "Facts",
                table: "F_Action",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Action_EnableRecord",
                schema: "Facts",
                table: "F_Action",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Action_ERPCode",
                schema: "Facts",
                table: "F_Action",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Action_LastModified",
                schema: "Facts",
                table: "F_Action",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Action_Name",
                schema: "Facts",
                table: "F_Action",
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
                name: "IX_F_Condition_ActionId",
                schema: "Facts",
                table: "F_Condition",
                column: "ActionId");

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
                name: "IX_F_Condition_WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "WorkItemId");

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
                name: "IX_F_Task_ConditionId",
                schema: "Facts",
                table: "F_Task",
                column: "ConditionId");

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
                name: "IX_F_Task_RoleId",
                schema: "Facts",
                table: "F_Task",
                column: "RoleId");

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
                name: "IX_L_RolePosition_Created",
                schema: "Links",
                table: "L_RolePosition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_EnableRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_ERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FifthId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FirstId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FourthId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_LastModified",
                schema: "Links",
                table: "L_RolePosition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_Name",
                schema: "Links",
                table: "L_RolePosition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_SecondId",
                schema: "Links",
                table: "L_RolePosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_ThirdId",
                schema: "Links",
                table: "L_RolePosition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_Created",
                schema: "Links",
                table: "L_TaskAction",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_EnableRecord",
                schema: "Links",
                table: "L_TaskAction",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_ERPCode",
                schema: "Links",
                table: "L_TaskAction",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_FifthId",
                schema: "Links",
                table: "L_TaskAction",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_FirstId",
                schema: "Links",
                table: "L_TaskAction",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_FourthId",
                schema: "Links",
                table: "L_TaskAction",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_LastModified",
                schema: "Links",
                table: "L_TaskAction",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_Name",
                schema: "Links",
                table: "L_TaskAction",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_SecondId",
                schema: "Links",
                table: "L_TaskAction",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskAction_ThirdId",
                schema: "Links",
                table: "L_TaskAction",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Created",
                schema: "Links",
                table: "L_UserLocation",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_EnableRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_ERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FifthId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FirstId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FourthId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_LastModified",
                schema: "Links",
                table: "L_UserLocation",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Name",
                schema: "Links",
                table: "L_UserLocation",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_SecondId",
                schema: "Links",
                table: "L_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_ThirdId",
                schema: "Links",
                table: "L_UserLocation",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_Created",
                schema: "Links",
                table: "L_UserPosition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_EnableRecord",
                schema: "Links",
                table: "L_UserPosition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_ERPCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FifthId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FirstId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FourthId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_LastModified",
                schema: "Links",
                table: "L_UserPosition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_Name",
                schema: "Links",
                table: "L_UserPosition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_SecondId",
                schema: "Links",
                table: "L_UserPosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_ThirdId",
                schema: "Links",
                table: "L_UserPosition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_WorkItem_WorkItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "WorkItemId",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
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
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Action_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Action");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Task_F_Scenario_ScenarioId",
                schema: "Facts",
                table: "F_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Operand_OperandId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_Tag_TagId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Action_ActionId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Case_CaseId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_WorkItem_WorkItemId",
                schema: "Facts",
                table: "F_Condition");

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
                name: "L_CaseTaskUser",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_RolePosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_TaskAction",
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

            migrationBuilder.DropTable(
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Action",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Task",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Condition",
                schema: "Facts");
        }
    }
}
