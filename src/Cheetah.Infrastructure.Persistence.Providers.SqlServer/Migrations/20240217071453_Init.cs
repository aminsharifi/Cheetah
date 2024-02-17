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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("de57c447-f8d8-4ab4-becf-67ad25bbc25c")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 235, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d626a238-4cea-468f-a150-12e474cd2c00")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("aafe212e-4210-4e11-9e1a-384b63456c36")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a3b55eba-6360-4196-b362-8ea12524c900")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("b9c02240-a25b-4f58-b740-b3d8efc8dca1")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("c0aaa4de-bbad-4e11-966e-3a446126ca62")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(257), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("47c2fc25-3c13-4808-9908-361a90802a4c")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(1724), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("701b58d3-8f7c-45f0-9558-b87bf6e81468")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(149), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("aaf053e9-5361-4208-8b8d-e3eb4616e56e")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d38ef06c-20e4-4077-b217-d896c9c9f722")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(3174), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("00e6ecf7-9c0c-4527-bd13-9013df859840")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 236, DateTimeKind.Unspecified).AddTicks(6477), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("dcb490be-f611-4534-af5d-1ba776867059")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8e2d4358-b2f5-428a-b23e-b13a9da1f98e")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d9badfb6-b809-4fac-86e8-20b96eec83e9")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("99f3d322-cb5c-484e-9361-0380f9bc61ad")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("6ebf0c00-ca55-4ed2-a104-29d30f637f31")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(9308), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d91ff64e-8446-42a7-9ba2-ad3b1f634145")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(3843), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("133d34ba-8a95-4b59-a8e5-386c12abd5f8")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("13f37586-8943-4cc7-9773-564866e22db4")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 237, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("83989007-202d-49ef-a2e8-19b8c6d96516")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 238, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("2203f8ff-a77b-40f3-910f-320430f0346e")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("23d18597-0c14-4bf0-b2ed-e6ee77c56818")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 239, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("82752d2c-d9e5-47e1-a0af-7357e3b8b537")),
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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 53, 240, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("fb03bea7-392e-4cae-aafc-fe31fbeceef2")),
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
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 3, 30, 0, 0)), null, "مقداردهی اولیه", 1L, true, new Guid("de6537bd-2b0f-4df8-a1cb-077dfb369ece"), null, null, "Initializing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 3, 30, 0, 0)), null, "در دست بررسی", 2L, true, new Guid("330a4e76-b63d-4cf1-8b00-44f47b6edf2a"), null, null, "Ongoing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, 3, 30, 0, 0)), null, "منتظر بازنگری", 3L, true, new Guid("bc987f44-ce7f-4368-95f6-05ab978283d7"), null, null, "Editing", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, 3, 30, 0, 0)), null, "کامل شده", 4L, true, new Guid("b78bf7af-c37c-420f-b565-e501e003608e"), null, null, "Completed", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 3, 30, 0, 0)), null, "عدم تایید", 5L, true, new Guid("48ebfc3f-d797-463c-9267-9f2872257839"), null, null, "Rejected", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 3, 30, 0, 0)), null, "ابطال شده", 6L, true, new Guid("f280e1da-ab42-4bc4-8004-12f2624e0326"), null, null, "Aborted", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "CreatedBy", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 889, DateTimeKind.Unspecified).AddTicks(1798), new TimeSpan(0, 3, 30, 0, 0)), null, false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("16a878d6-720c-438f-b44d-fba2e80c0dda"), null, null, "D_TagType", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 3, 30, 0, 0)), null, false, "عملگرها(Dimentions)", 102L, true, new Guid("517a3ae3-b8c8-4798-b436-316a1004b160"), null, null, "D_Operand", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1283), new TimeSpan(0, 3, 30, 0, 0)), null, true, "تگ‌ها(Dimentions)", 103L, true, new Guid("f13bbb8a-0622-409d-bb1a-2550063c9a46"), null, null, "D_Tag", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 3, 30, 0, 0)), null, false, "وضعیت فرآیندها(Dimentions)", 104L, true, new Guid("69bee783-60c5-48a8-8383-b0dc834e66ca"), null, null, "D_CaseState", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1297), new TimeSpan(0, 3, 30, 0, 0)), null, true, "فرآیند‌ها(Dimentions)", 105L, true, new Guid("dceffe2e-02bf-4c76-adc9-799429d91ebf"), null, null, "D_Process", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 3, 30, 0, 0)), null, true, "کاربران(Dimentions)", 106L, true, new Guid("899b6546-4d4b-4c4d-b027-b7ca5a7a121d"), null, null, "D_User", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1364), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات کاربرها(Facts)", 107L, true, new Guid("92eb7a6b-6ca2-4b7e-b91e-0ff9b55b6469"), null, null, "D_UserInformation", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 3, 30, 0, 0)), null, false, "تمام تاییدها(Facts)", 108L, true, new Guid("2ac6c01d-31f7-4822-b7bc-9e07a5483dd6"), null, null, "F_WorkItem", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 3, 30, 0, 0)), null, false, "ضمیمه‌ها(Facts)", 109L, true, new Guid("c2693525-c5f6-4c9f-9082-40fca89e5528"), null, null, "F_Attachment", 109L },
                    { 110L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 3, 30, 0, 0)), null, false, "لیست تخصیص‌ها(Facts)", 110L, true, new Guid("4ee9d1d9-fa2c-41d5-b57b-c024610b768c"), null, null, "F_Task", 110L },
                    { 111L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 3, 30, 0, 0)), null, true, "لیست شرط‌ها(Facts)", 111L, true, new Guid("390536c0-a271-43ee-8c39-d33367b17a44"), null, null, "F_Condition", 111L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 3, 30, 0, 0)), null, false, "اطلاعات درخواست‌ها(Facts)", 112L, true, new Guid("bf4ce668-6a50-4729-b3fa-abc152b5d0e9"), null, null, "F_Case", 112L },
                    { 113L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 3, 30, 0, 0)), null, true, "سناریوها(Facts)", 113L, true, new Guid("0ae4d754-6a71-4848-b8b0-ac2f3f504cb5"), null, null, "F_Scenario", 113L },
                    { 114L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 3, 30, 0, 0)), null, false, "فرآیند-سناریو(Links)", 114L, true, new Guid("18b85a95-9e52-49df-ab53-4875821ed29c"), null, null, "L_ProcessScenario", 114L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3692), new TimeSpan(0, 3, 30, 0, 0)), null, "مساوی", 1L, true, new Guid("22bba782-487f-4970-a34e-bb88d6895fc3"), null, null, "=", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 3, 30, 0, 0)), null, "مخالف", 2L, true, new Guid("86781f47-8335-4604-acee-73a7a7ef6f79"), null, null, "!=", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 3, 30, 0, 0)), null, "بزگتر از", 3L, true, new Guid("b0c2657a-227a-4684-aa0f-1d34dafb7fdb"), null, null, ">", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)), null, "بزرگتر و مساوی", 4L, true, new Guid("77ca4157-3118-4971-9e02-9e1f6b4ae510"), null, null, ">=", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 3, 30, 0, 0)), null, " کوچکتر از", 5L, true, new Guid("b5108f08-ea6c-4f97-83e2-383f103b5fb8"), null, null, "<", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 3, 30, 0, 0)), null, "کوچکتر و مساوی", 6L, true, new Guid("a0e564a3-a59a-40da-ab94-fc108c10bacd"), null, null, "<=", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه", true, 1L, true, new Guid("7c4fa5eb-e06f-4c48-81bf-7374cf2e992a"), null, null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9232), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", 1L, true, new Guid("edc9b812-68d2-4bb9-8514-ead27984cf85"), null, null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9237), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", 2L, true, new Guid("4b43b45a-f0e3-44c8-af55-1e286974d9f0"), null, null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9240), new TimeSpan(0, 3, 30, 0, 0)), null, "تاریخ", 3L, true, new Guid("31f8832b-5d45-45a1-9e6c-fc9dcb077cab"), null, null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", 4L, true, new Guid("cd872ed1-0c92-4a40-b445-460e75a38ad0"), null, null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Created", "CreatedBy", "DelegateId", "DisplayName", "Domain", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModified", "LastModifiedBy", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(2856), new TimeSpan(0, 3, 30, 0, 0)), null, null, "محمد شریفی", null, 1L, true, new Guid("ddc3d9ca-a3d8-4278-919e-89e9faaf1740"), null, null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(2885), new TimeSpan(0, 3, 30, 0, 0)), null, null, "امین شریفی", null, 2L, true, new Guid("5558c921-d99c-4930-a184-cd31562bb6a2"), null, null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, 3, 30, 0, 0)), null, "صندوق ورودی", 1L, true, new Guid("5e4b049d-39e2-49fc-b5ce-bf9b3f45db15"), null, null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 3, 30, 0, 0)), null, "ارسال شده", 2L, true, new Guid("d18515be-7712-4922-b2c2-683fc79be620"), null, null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 3, 30, 0, 0)), null, "خارج شده", 3L, true, new Guid("c72d9c35-fe9f-4db1-a2b6-65a8be81516f"), null, null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 891, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 3, 30, 0, 0)), null, "آینده", 4L, true, new Guid("04748a88-e7b7-4dd7-9b30-f1828ee267af"), null, null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 887, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, 3, 30, 0, 0)), null, "سناریو نمونه", 1L, true, new Guid("94661983-1577-445c-aa29-cd0221b9b461"), null, null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "تایید", 1L, true, new Guid("a0ba6956-76af-426e-b1ae-39a86f6f7830"), null, null, "Approve", 1L, 2L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "عدم تایید", 2L, true, new Guid("2609be9f-29c5-4a1d-b0e2-ecfa40f9ac1e"), null, null, "Reject", 2L, 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 3, 30, 0, 0)), null, "دودویی", "بازنگری", 3L, true, new Guid("dfd7030c-fca3-48dc-9073-b9fd6399c7ab"), null, null, "Revise", 3L, 2L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "موقعیت", 4L, true, new Guid("7d94319f-a97c-4cc0-9618-a67fce7e213e"), null, null, "Location", 4L, 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "نقش", 5L, true, new Guid("c462975b-7a0c-49f4-afbe-6803f0837018"), null, null, "Role", 5L, 4L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "سمت", 6L, true, new Guid("8bfafb2c-077f-4f7b-8927-6ad22b8d83bd"), null, null, "Position", 6L, 4L },
                    { 7L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 3, 30, 0, 0)), null, "حروف", "مدیر این پرسنل", 7L, true, new Guid("23c24cc6-574c-42a4-aaf8-8e61ddc8df6e"), null, null, "Employees", 7L, 4L },
                    { 8L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 890, DateTimeKind.Unspecified).AddTicks(9828), new TimeSpan(0, 3, 30, 0, 0)), null, "عددی", "مبلغ", 8L, true, new Guid("3b66ccb3-1174-4472-a77d-2d3701cd6688"), null, null, "Price", 8L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Task",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(186), new TimeSpan(0, 3, 30, 0, 0)), null, "ثبت درخواست", 1L, true, new Guid("3cde28cd-65f1-45f3-8714-3288f6cb9ce5"), null, null, "Sample_Scenario_Requestor", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 888, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, 3, 30, 0, 0)), null, "بررسی درخواست", 2L, true, new Guid("5f710fa1-a36b-4acf-9bcb-f3fae2bc45f1"), null, null, "Sample_Scenario_RequestorManager", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 2, 17, 10, 44, 52, 885, DateTimeKind.Unspecified).AddTicks(8157), new TimeSpan(0, 3, 30, 0, 0)), null, "فرآیند نمونه-سناریو نمونه", 1L, true, null, 1L, null, new Guid("286fc27c-ed8a-4d5b-852b-7ea57c40507b"), null, null, "SampleProcess_SampleScenario", 1L, 1L, null });

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
