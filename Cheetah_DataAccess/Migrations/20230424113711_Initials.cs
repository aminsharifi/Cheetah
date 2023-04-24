using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
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
                name: "AspNetUsers",
                columns: table => new
                {
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
                });

            migrationBuilder.CreateTable(
                name: "D_Area",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Area_D_Area_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_EndorsementPattern",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_EndorsementPattern", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_EndorsementPattern_D_EndorsementPattern_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Entity",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Entity_D_Entity_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Entity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_FieldType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_FieldType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_FieldType_D_FieldType_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_FieldType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Location",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Location_D_Location_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Operand_D_Operand_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Position",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Position_D_Position_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_ProcessState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Role",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ROL_Independent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Role_D_Role_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    UI_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UI_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UI_NotifByEmail = table.Column<bool>(type: "bit", nullable: true),
                    UI_NotifByMessenger = table.Column<bool>(type: "bit", nullable: true),
                    UI_NotifByCell = table.Column<bool>(type: "bit", nullable: true),
                    UI_ContactEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UI_ContactMessenger = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UI_ContactCell = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UI_UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UI_NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UI_Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UI_InternalPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UI_Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UI_RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_UserInformation_D_UserInformation_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_UserInformation",
                        principalColumn: "Id");
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "D_RequestTitle",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RT_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    RT_ERP = table.Column<bool>(type: "bit", nullable: true),
                    RT_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true),
                    RT_EndorsementPatternId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_RequestTitle_D_EndorsementPattern_RT_EndorsementPatternId",
                        column: x => x.RT_EndorsementPatternId,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_RequestTitle_D_RequestTitle_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_ParameterType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PT_P_FieldTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeId",
                        column: x => x.PT_P_FieldTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_FieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_ParameterType_D_ParameterType_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Endorsement",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ED_RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ED_EndorsementPatternId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Endorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Endorsement_D_EndorsementPattern_ED_EndorsementPatternId",
                        column: x => x.ED_EndorsementPatternId,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_Endorsement_D_Endorsement_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_Endorsement_D_Role_ED_RoleId",
                        column: x => x.ED_RoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_RolePosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Role_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    User_Domain = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    User_EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true),
                    User_DelegateEnabled = table.Column<bool>(type: "bit", nullable: true),
                    User_CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true),
                    User_IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    User_LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    User_BossUserId = table.Column<long>(type: "bigint", nullable: true),
                    User_DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    User_UserInformationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_D_UserInformation_User_UserInformationId",
                        column: x => x.User_UserInformationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UserInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_BossUserId",
                        column: x => x.User_BossUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_DelegateId",
                        column: x => x.User_DelegateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_ParameterList",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PL_ParameterTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ParameterList_D_ParameterList_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                        column: x => x.PL_ParameterTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L_UserArea",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserArea_D_Area_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserArea_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L_UserLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L_UserRelatedLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserRelatedLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserRelatedLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRelatedLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L_UserRole",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false),
                    D_PositionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserRole_D_Position_D_PositionId",
                        column: x => x.D_PositionId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserRole_D_Role_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserRole_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_AllApprove",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Current_ApproveId = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Last_ApproveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_AllApprove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_AllApprove_F_AllApprove_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Approve",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    APV_UserInChargeId = table.Column<long>(type: "bigint", nullable: true),
                    APV_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    APV_NeedApproveId = table.Column<long>(type: "bigint", nullable: true),
                    APV_ApproveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Approve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Approve_D_Endorsement_APV_EndorsementId",
                        column: x => x.APV_EndorsementId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_D_User_APV_UserInChargeId",
                        column: x => x.APV_UserInChargeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_ApproveId",
                        column: x => x.APV_ApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_NeedApproveId",
                        column: x => x.APV_NeedApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_Approve_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Approve",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_RequestInformation",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RI_ERPID = table.Column<long>(type: "bigint", nullable: true),
                    RI_IsCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RI_PE_Level = table.Column<byte>(type: "tinyint", nullable: true),
                    RI_RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_RequestFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_ExpertUserId = table.Column<long>(type: "bigint", nullable: true),
                    RI_RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_AllApproveId = table.Column<long>(type: "bigint", nullable: true),
                    RI_ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    RI_RequestTitleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RequestInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateId",
                        column: x => x.RI_ProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                        column: x => x.RI_RequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                        column: x => x.RI_CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_ExpertUserId",
                        column: x => x.RI_ExpertUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                        column: x => x.RI_RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveId",
                        column: x => x.RI_AllApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_RequestInformation_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_RequestInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ATC_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATC_Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    F_ApproveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Attachment_F_Approve_F_ApproveId",
                        column: x => x.F_ApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_Approve",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Attachment_F_Attachment_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Attachment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    CD_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_EndorsementPatternId = table.Column<long>(type: "bigint", nullable: true),
                    CD_ParameterListId = table.Column<long>(type: "bigint", nullable: true),
                    CD_OperandId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true),
                    F_RequestInformationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_EndorsementPattern_CD_EndorsementPatternId",
                        column: x => x.CD_EndorsementPatternId,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Operand_CD_OperandId",
                        column: x => x.CD_OperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_ParameterList_CD_ParameterListId",
                        column: x => x.CD_ParameterListId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_User_D_UserId",
                        column: x => x.D_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Condition_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_RequestInformation_F_RequestInformationId",
                        column: x => x.F_RequestInformationId,
                        principalSchema: "Facts",
                        principalTable: "F_RequestInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(1220), false, new Guid("90fd99fb-58a0-4520-8f1e-a4c4fd999d9a"), 1L, null, "فروش دارویی", null, 1L, "DrugSale", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(1413), false, new Guid("d52423a9-ef27-4c06-80b4-324461f3ac68"), 2L, null, "فروش مصرفی", null, 2L, "FMCGSale", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(1427), false, new Guid("76372ef7-8dd5-414d-829e-c8f891fb98d4"), 3L, null, "حسابداری خرید", null, 3L, "PurchaseAccounting", null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(1498), false, new Guid("ecc06fec-c6ac-4c26-b55d-14357bda3eef"), 4L, null, "حسابداری فروش", null, 4L, "SaleAccounting", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2542), false, new Guid("7638f9f5-8472-4f23-869e-d4aee3a3e189"), 1L, null, "الگوی یک", null, 1L, "Pattern1", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2594), false, new Guid("2cf7f607-dee1-4abb-b5e1-9535ddb6843c"), 2L, null, "الگوی دو", null, 2L, "Pattern2", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2604), false, new Guid("ac0d4552-a3dc-4b48-afa5-200ffae087ee"), 3L, null, "الگوی سه", null, 3L, "Pattern3", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3534), false, new Guid("2ec1b309-1864-41eb-b9ea-86fc2a7c3500"), 100L, null, "واحدها(Dimentions)", null, 100L, "D_Area", null },
                    { 101L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3943), false, new Guid("97a8c9a9-c32e-4116-95cf-58b14052f49e"), 101L, null, "نوع فیلدها(Dimentions)", null, 101L, "D_FieldType", null },
                    { 102L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3976), false, new Guid("296c81f2-5a11-458b-9113-b29bff7c6d8e"), 102L, null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4003), false, new Guid("6df6c6c7-c9cc-4799-abaa-3ec1bf155344"), 103L, null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4016), false, new Guid("154b3da7-773d-4652-8958-40bbaa3a02dc"), 104L, null, "لیست پارامترها(Dimentions)", null, 104L, "D_ParameterList", null },
                    { 105L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4028), false, new Guid("ca9ec9d7-4900-4da3-aaf0-977c4dbcbd7e"), 105L, null, "نوع‌های پارامتر(Dimentions)", null, 105L, "D_ParameterType", null },
                    { 106L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4041), false, new Guid("83e6d044-0ce9-4cb1-bb6b-2df218e7ca6a"), 106L, null, "سمت‌ها(Dimentions)", null, 106L, "D_Position", null },
                    { 107L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4056), false, new Guid("b6190fe3-f95c-4a52-8ed3-8686c4b4a79b"), 107L, null, "وضعیت فرآیندها(Dimentions)", null, 107L, "D_ProcessState", null },
                    { 108L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4067), false, new Guid("3c861809-c857-47d8-8835-63ae37139823"), 108L, null, "عنوان درخواست‌ها(Dimentions)", null, 108L, "D_RequestTitle", null },
                    { 109L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4083), false, new Guid("4b538898-cdea-44ff-ae89-441ad9bcab75"), 109L, null, "نقش‌ها(Dimentions)", null, 109L, "D_Role", null },
                    { 110L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4095), false, new Guid("77acbe1c-ff19-4984-9c49-588b7e5d0838"), 110L, null, "کاربران(Dimentions)", null, 110L, "D_User", null },
                    { 111L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4107), false, new Guid("75eb0e98-734b-4235-94bd-e465f0367bce"), 111L, null, "الگوهای تایید(Dimentions)", null, 111L, "D_EndorsementPattern", null },
                    { 112L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4120), false, new Guid("63b32e58-7cc0-4b9e-984c-3daed4bdb2eb"), 112L, null, "اختصاص نقش‌ها(Facts)", null, 112L, "D_Endorsement", null },
                    { 113L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4133), false, new Guid("d1bf1f03-3d4b-4c56-a8f4-e02ad6406ded"), 113L, null, "اطلاعات کاربرها(Facts)", null, 113L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4145), false, new Guid("cddfdcb6-1f32-4e99-999b-f924cbe77cf4"), 200L, null, "تمام تاییدها(Facts)", null, 200L, "F_AllApprove", null },
                    { 201L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4167), false, new Guid("5d0fc118-5aef-444d-8c72-f8d895d88eec"), 201L, null, "تاییدهای جاری(Facts)", null, 201L, "F_Approve", null },
                    { 202L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4179), false, new Guid("0dc8830d-af9a-4f84-9181-20b6f40b2ac8"), 202L, null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 204L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4204), false, new Guid("1ec8858c-0386-43be-bb91-02987180649b"), 204L, null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4217), false, new Guid("58bfa749-08a0-4f1d-8a71-27f7bffdf02f"), 205L, null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_RequestInformation", null },
                    { 300L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4229), false, new Guid("eaecd990-2d3c-4d98-89ee-5bff32d80bb5"), 300L, null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4241), false, new Guid("bc3db2f7-bfd0-4216-9749-607f8af6ee00"), 301L, null, "کاربر-واحد(Links)", null, 301L, "L_UserArea", null },
                    { 302L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4254), false, new Guid("ad26688d-b05f-4750-ba5b-ebc8dbe9a4f5"), 302L, null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4265), false, new Guid("94330aed-a463-4e1d-a411-abd4cce51caf"), 303L, null, "کاربر-موقعیت مرتبط(Links)", null, 303L, "L_UserRelatedLocation", null },
                    { 304L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4278), false, new Guid("584372e2-8e53-4e5a-bd46-4f7a7001f445"), 304L, null, "کاربر-سمت(Links)", null, 304L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2931), false, new Guid("ef5b2825-2068-43d7-a918-298fe17eb677"), 1L, null, "پارامتریک", null, 1L, "Parametric", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2940), false, new Guid("c2e87410-612d-42c1-be0a-15ab1fbb51cc"), 2L, null, "عددی", null, 2L, "Numberic", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2951), false, new Guid("fe6c6640-46a1-4817-bd18-80c8227b1f29"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2959), false, new Guid("fa5eb69a-f091-41d9-88bb-e3724bccc9d2"), 4L, null, "حروف", null, 4L, "String", null },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2966), false, new Guid("21d8c5c9-1be4-4fba-b587-97265acd3ff4"), 5L, null, "دودویی", null, 5L, "Boolean", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2825), false, new Guid("5a144f96-a215-423e-b9d9-9c84b165b224"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2888), false, new Guid("8a525f61-19a2-4535-b33d-469069f3a31a"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2897), false, new Guid("616f87d8-b8ae-4215-881d-910af0788df9"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3021), false, new Guid("ccbd3217-b8b1-4b7b-9a4b-62359ea589c9"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3032), false, new Guid("fcbfe144-4d83-49c6-8571-9f9997f01438"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3040), false, new Guid("87b4e1e2-c9fb-4f7f-afa3-761158dcc35d"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3047), false, new Guid("5618ff91-98f1-4c3e-bade-5a91f0068da0"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3056), false, new Guid("96d21ef0-95cb-4370-b082-e101a03a07e9"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3068), false, new Guid("bd036d20-6cd7-4818-b5d9-2b19ab845666"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3453), false, new Guid("448f456f-6cc3-45d7-9627-5304400e2795"), 1L, null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3461), false, new Guid("f7e62e97-714e-4f9e-a6c4-cee2a4ad63d9"), 2L, null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3469), false, new Guid("17c34951-b838-43f9-89fb-2b53cdd4b7ae"), 3L, null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3477), false, new Guid("2d339183-1f8b-49fe-8f86-a854355d78ef"), 4L, null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3484), false, new Guid("64df043a-a4da-4c25-a539-814d3e4e8bda"), 5L, null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3492), false, new Guid("4cac8050-c39e-4e67-9d4b-aca106299939"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3499), false, new Guid("1eb071f6-4744-4bca-b431-e20b15f73bf1"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2754), false, new Guid("56037bc0-2556-4175-b6d4-0114150a8c91"), 1L, null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2768), false, new Guid("5ced11ce-ba87-4ca4-a922-5f6b38bfd6bb"), 2L, null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2776), false, new Guid("81f786a3-5194-4aec-a825-3ca893fdc52a"), 3L, null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2783), false, new Guid("c927d064-9f5c-4488-9b61-656283accec4"), 4L, null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3378), false, new Guid("416f43fc-9ade-48f4-83cf-e90f7999028d"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3387), false, new Guid("98d10d47-ff87-4469-a49d-61896260bf05"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3395), false, new Guid("c210c604-1e9d-4861-91ee-64088e93a64e"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3404), false, new Guid("ccec609a-e3be-48c7-8199-d1723bf63e3f"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3413), false, new Guid("0071f00c-ad1c-4f7d-8491-bbfb04a183c6"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3331), false, new Guid("2170f20d-3188-4650-bead-e373a70092e4"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3342), false, new Guid("f9864400-7907-42c0-a282-2ee9188a6b84"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "PT_P_FieldTypeId", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3108), false, new Guid("e0117d8a-1f6d-4417-b544-f7e1b0de2139"), 1L, null, "متغیرهای عددی", null, 1L, "NumbericProcessVar", 2L, null },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3121), false, new Guid("bda42b7e-abe9-4e01-a49e-428ed03453d8"), 2L, null, "متغیرهای تاریخی", null, 2L, "DateProcessVar", 3L, null },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3138), false, new Guid("9011d55f-e73a-45cd-96d3-e951da912bfe"), 3L, null, "متغیرهای حروفی", null, 3L, "StringProcessVar", 4L, null },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3146), false, new Guid("8402f91c-1d49-40be-88a1-5ab4cf20f949"), 4L, null, "متغیرهای دودویی", null, 4L, "BooleanProcessVar", 5L, null },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3154), false, new Guid("053094a4-ee2f-4e94-affe-574adfadb7a9"), 5L, null, "اقدام‌های فرآیندی", null, 5L, "ProcessAction", 1L, null },
                    { 6L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3163), false, new Guid("2db9300f-e2db-478e-b55c-8c4ce4fe0706"), 6L, null, "نوع‌های واحد", null, 6L, "UnitType", 1L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2653), false, new Guid("056aab6a-e891-4d9e-a330-f8b88089f63b"), 1L, "الگوی یک", "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null, true, 1L, true, true },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2704), false, new Guid("2de99d6a-d2d6-4f3e-a676-ba2224b9b9f7"), 2L, "الگوی دو", "مجوزهای موردی", null, 2L, "PolicyCenter", null, true, 2L, true, true },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(2712), false, new Guid("a48048af-e517-4cfa-b5e5-152752608a79"), 3L, "الگوی دو", "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null, true, 2L, true, true }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4398), false, 1L, new Guid("3cb39a8b-e52e-4719-abb1-9872a3e8cf7f"), 1L, null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4407), false, 2L, new Guid("3bedf3e5-243e-4584-af42-4fa842f9241b"), 2L, null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4414), false, 3L, new Guid("9c8ed3e0-e865-404a-86d8-248a6cff196e"), 3L, null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4422), false, 3L, new Guid("2f071bc2-610c-42d9-908d-9238c22ca0ec"), 4L, null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4430), false, 4L, new Guid("36b2c742-f270-4ed6-831d-f54a3e545034"), 5L, null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4437), false, 4L, new Guid("064aaec3-9b67-492d-b86b-9c1cd447fcb3"), 6L, null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4445), false, 5L, new Guid("bc6a5a1f-2263-4d5c-8693-c6e7f67653ad"), 7L, null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserArea",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4494), false, 2L, new Guid("9306ad39-e118-487c-9da7-e55a26e8c4e2"), 1L, null, "امین شریفی-فروش دارویی", null, 1L, "a.sharifi-DrugSale", 1L },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4503), false, 2L, new Guid("894a6429-fcb2-4ec9-bae2-f08b87dfd32f"), 2L, null, "امین شریفی-فروش مصرفی", null, 2L, "a.sharifi-FMCGSale", 2L },
                    { 3L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4510), false, 1L, new Guid("d0a73f6a-c7b1-43df-8016-9e3b2918ad31"), 3L, null, "محمد شریفی-فروش دارویی", null, 3L, "m.sharifi-DrugSale", 1L },
                    { 4L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4517), false, 1L, new Guid("851996d4-7a31-41e8-984a-e1c819e7a286"), 4L, null, "محمد شریفی-فروش مصرفی", null, 4L, "m.sharifi-FMCGSale", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4353), false, 1L, new Guid("46594f69-da16-4bd1-80ff-5139499e3158"), 1L, null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(4367), false, 2L, new Guid("09169eef-6be5-43cf-9c79-745105326d87"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ParameterList",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PL_ParameterTypeId", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3199), false, new Guid("05ed4dfb-63aa-41c6-95ca-37e72b98c0b8"), 100L, "عددی", "سهم شرکت", null, 100L, 1L, "OursShare", null },
                    { 101L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3211), false, new Guid("f159e571-b01d-4488-91f4-38d04bb80b31"), 101L, "عددی", "سهم دیگران", null, 101L, 1L, "OthersShare", null },
                    { 102L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3219), false, new Guid("7606dd58-1660-489e-a11f-ff25cf095ff9"), 102L, "دودویی", "مخدر/ یخچالی", null, 102L, 4L, "Refrigerator", null },
                    { 103L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3228), false, new Guid("00b7b60d-1884-4da0-ae28-081497d72b49"), 103L, "عددی", "مبلغ", null, 103L, 1L, "Price", null },
                    { 200L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3236), false, new Guid("55200d5a-25f0-4cd6-b46f-b580eaa2e03f"), 200L, "پارامتریک", "تایید", null, 200L, 5L, "Approve", null },
                    { 201L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3244), false, new Guid("18d6d93a-e48a-4c43-800f-cf6add1bbb58"), 201L, "پارامتریک", "عدم تایید", null, 201L, 5L, "Reject", null },
                    { 202L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3252), false, new Guid("10ecba13-8afc-44f9-ae86-b001a83abf98"), 202L, "پارامتریک", "بازنگری", null, 202L, 5L, "Revise", null },
                    { 301L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3260), false, new Guid("e1d85d51-f038-4682-9ebe-66a6a45f4c36"), 301L, "پارامتریک", "دارویی", null, 301L, 6L, "Med", null },
                    { 302L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3268), false, new Guid("94139fb3-17a2-450a-829d-98fc0ec3050e"), 302L, "پارامتریک", "مصرفی", null, 302L, 6L, "FMCG", null },
                    { 303L, new DateTime(2023, 4, 24, 16, 7, 10, 881, DateTimeKind.Local).AddTicks(3279), false, new Guid("7b3a55dd-8cae-4145-83c1-427b7a611f06"), 303L, "پارامتریک", "کل", null, 303L, 6L, "General", null }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_DsblRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PCode",
                schema: "Dimentions",
                table: "D_Area",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PERPCode",
                schema: "Dimentions",
                table: "D_Area",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PIndex",
                schema: "Dimentions",
                table: "D_Area",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PName",
                schema: "Dimentions",
                table: "D_Area",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_ED_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "ED_EndorsementPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_ED_RoleId",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "ED_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_PCode",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_PERPCode",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_PIndex",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Endorsement_PName",
                schema: "Dimentions",
                table: "D_Endorsement",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_DsblRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_Parent_Id",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PERPCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PIndex",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PName",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_DsblRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PIndex",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PName",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_DsblRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PCode",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PERPCode",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PIndex",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PName",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PIndex",
                schema: "Dimentions",
                table: "D_Location",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PName",
                schema: "Dimentions",
                table: "D_Location",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PIndex",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PName",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PIndex",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PName",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_DsblRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PERPCode",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PIndex",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PName",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PIndex",
                schema: "Dimentions",
                table: "D_Position",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PName",
                schema: "Dimentions",
                table: "D_Position",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PIndex",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PName",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_RT_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "RT_EndorsementPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PIndex",
                schema: "Dimentions",
                table: "D_Role",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PName",
                schema: "Dimentions",
                table: "D_Role",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_ROL_Independent",
                schema: "Dimentions",
                table: "D_Role",
                column: "ROL_Independent",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PIndex",
                schema: "Dimentions",
                table: "D_User",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PName",
                schema: "Dimentions",
                table: "D_User",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_BossUserId",
                schema: "Dimentions",
                table: "D_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User",
                column: "User_UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_DsblRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PIndex",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PName",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PERPCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PName",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_EndorsementId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_UserInChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PERPCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PName",
                schema: "Facts",
                table: "F_Approve",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_CreateTimeRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PIndex",
                schema: "Facts",
                table: "F_Attachment",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PName",
                schema: "Facts",
                table: "F_Attachment",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_EndorsementPatternId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_EndorsementPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_ParameterListId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_ParameterListId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CreateTimeRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_DsblRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_F_RequestInformationId",
                schema: "Facts",
                table: "F_Condition",
                column: "F_RequestInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_PCode",
                schema: "Facts",
                table: "F_Condition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_PERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_PIndex",
                schema: "Facts",
                table: "F_Condition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_PName",
                schema: "Facts",
                table: "F_Condition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PERPCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PName",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_ExpertUserId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ExpertUserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ProcessStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_CreateTimeRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_DsblRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FirstId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_LastUpdatedRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PIndex",
                schema: "Links",
                table: "L_RolePosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PName",
                schema: "Links",
                table: "L_RolePosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_SecondId",
                schema: "Links",
                table: "L_RolePosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_CreateTimeRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_DsblRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_FirstId",
                schema: "Links",
                table: "L_UserArea",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserArea",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PCode",
                schema: "Links",
                table: "L_UserArea",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PERPCode",
                schema: "Links",
                table: "L_UserArea",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PIndex",
                schema: "Links",
                table: "L_UserArea",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_PName",
                schema: "Links",
                table: "L_UserArea",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_SecondId",
                schema: "Links",
                table: "L_UserArea",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_CreateTimeRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_DsblRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FirstId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PIndex",
                schema: "Links",
                table: "L_UserLocation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PName",
                schema: "Links",
                table: "L_UserLocation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_SecondId",
                schema: "Links",
                table: "L_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_CreateTimeRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_DsblRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_FirstId",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PCode",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PERPCode",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PIndex",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_PName",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_SecondId",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_CreateTimeRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_D_PositionId",
                schema: "Links",
                table: "L_UserRole",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_DsblRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_FirstId",
                schema: "Links",
                table: "L_UserRole",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserRole",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PCode",
                schema: "Links",
                table: "L_UserRole",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PERPCode",
                schema: "Links",
                table: "L_UserRole",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PIndex",
                schema: "Links",
                table: "L_UserRole",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_PName",
                schema: "Links",
                table: "L_UserRole",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_SecondId",
                schema: "Links",
                table: "L_UserRole",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Endorsement_D_EndorsementPattern_ED_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Endorsement_D_Role_ED_RoleId",
                schema: "Dimentions",
                table: "D_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_UserInformation_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

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
                name: "F_Condition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "L_RolePosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserArea",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserRelatedLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserRole",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ParameterList",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_RequestInformation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Area",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Position",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ParameterType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_RequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_FieldType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_EndorsementPattern",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Approve",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Endorsement",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_AllApprove",
                schema: "Facts");
        }
    }
}
