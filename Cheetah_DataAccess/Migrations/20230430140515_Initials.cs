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
                name: "D_Process",
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
                    PN_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    PN_ERP = table.Column<bool>(type: "bit", nullable: true),
                    PN_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Process_D_Process_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
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
                name: "D_Strategy",
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
                    table.PrimaryKey("PK_D_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Strategy_D_Strategy_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_TagType",
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
                    table.PrimaryKey("PK_D_TagType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_TagType_D_TagType_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
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
                name: "F_Endorsement",
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
                    ED_RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ED_StrategyId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Endorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Endorsement_D_Role_ED_RoleId",
                        column: x => x.ED_RoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_D_Strategy_ED_StrategyId",
                        column: x => x.ED_StrategyId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Endorsement_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_Process_Strategy",
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
                    table.PrimaryKey("PK_L_Process_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_D_Strategy_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D_Tag",
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
                    TG_TagTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                        column: x => x.TG_TagTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_Tag_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
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
                name: "L_UserPosition",
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
                    table.PrimaryKey("PK_L_UserPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_User_FirstId",
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
                    table.ForeignKey(
                        name: "FK_F_Approve_F_Endorsement_APV_EndorsementId",
                        column: x => x.APV_EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
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
                        name: "FK_F_RequestInformation_D_Process_RI_RequestTitleId",
                        column: x => x.RI_RequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                        column: x => x.RI_CreatorId,
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
                    CD_TagId = table.Column<long>(type: "bigint", nullable: true),
                    CD_OperandId = table.Column<long>(type: "bigint", nullable: true),
                    CD_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_StrategyId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true),
                    F_RequestInformationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Operand_CD_OperandId",
                        column: x => x.CD_OperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Strategy_CD_StrategyId",
                        column: x => x.CD_StrategyId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Strategy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Tag_CD_TagId",
                        column: x => x.CD_TagId,
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
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 101L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2283), false, new Guid("38349e5f-1302-41f2-8235-81d0b6c79640"), 101L, null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2460), false, new Guid("3c2341e6-6109-48b9-a1de-b89ea09f1da2"), 102L, null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2473), false, new Guid("c743c86c-eb26-4ba3-beac-21777cc4ea8a"), 103L, null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2483), false, new Guid("2ba3265d-d918-453c-a5c5-9ab6d8950572"), 104L, null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2492), false, new Guid("6a9541d1-6cc6-42d7-8ae9-ecab540764eb"), 105L, null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2504), false, new Guid("ef706d7a-e9c3-4a8a-acec-bf326c204196"), 106L, null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2521), false, new Guid("643214d4-4d70-4cd4-ae37-24be508aad4e"), 107L, null, "نام فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2531), false, new Guid("035b3d57-a98e-4919-b132-6ce9a4e9901d"), 108L, null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2539), false, new Guid("05ff3451-554e-49b8-9690-a499f434d3c5"), 109L, null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 110L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2547), false, new Guid("a0337cf8-acca-4b42-9498-1562cdaf92d1"), 110L, null, "راهبردها(Dimentions)", null, 110L, "D_Strategy", null },
                    { 112L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2557), false, new Guid("5ee10e1b-87bb-4454-812c-fbe93ca7a6ea"), 112L, null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2567), false, new Guid("5437ef6e-a4f6-4199-a4ad-1baa6ebc56e1"), 200L, null, "تمام تاییدها(Facts)", null, 200L, "F_AllApprove", null },
                    { 201L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2575), false, new Guid("1739843b-6c3f-4713-80f5-d3b4f886e76c"), 201L, null, "تاییدهای جاری(Facts)", null, 201L, "F_Approve", null },
                    { 202L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2586), false, new Guid("bfaa1b92-0489-4a77-903f-d7614fb58939"), 202L, null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2594), false, new Guid("8516f347-5fef-4cc2-aa54-2b5942dfe6b9"), 203L, null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2610), false, new Guid("ba4b6cc0-3422-4826-8767-0e0dbaa5b868"), 204L, null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2619), false, new Guid("fec5399c-81d5-42a8-8b92-ea42e083bd1d"), 205L, null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_RequestInformation", null },
                    { 300L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2627), false, new Guid("9330a320-c23a-4d22-9f8b-836b115fa985"), 300L, null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2635), false, new Guid("35a2f0e2-f62e-407c-adc5-4464cb770752"), 301L, null, "فرآیند-راهبرد(Links)", null, 301L, "L_Process_Strategy", null },
                    { 302L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2645), false, new Guid("be7b14b2-2011-425c-a396-d0a067f65dba"), 302L, null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2653), false, new Guid("217b94fc-c582-49ae-a30b-5a47df35cdc7"), 303L, null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1532), false, new Guid("5dba8303-6211-4d05-a819-e02d49c2996d"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1539), false, new Guid("a91e6653-3f14-4ec8-950d-d3482c9e186d"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1548), false, new Guid("1a6bdaad-3812-4a4b-9b7c-efcbf3b38a9f"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1577), false, new Guid("6ca46102-0269-4d57-8d88-59322bb902ea"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1584), false, new Guid("41e08798-403b-44a4-b6a8-b04e2185db24"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1853), false, new Guid("7e8f7f65-e920-47e8-95dc-0f7f484cebd5"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1860), false, new Guid("ef210e7e-1c84-422f-a562-c8e139f51163"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1881), false, new Guid("b529ad6b-125a-49c2-a10c-223cd9bf86c8"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1886), false, new Guid("615bae8b-b0c0-4c9d-b5cc-8062742c8109"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2216), false, new Guid("abafbd13-ae08-48e4-8b2e-cf96e06755fc"), 1L, null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2222), false, new Guid("7ce5133d-a9e3-4755-929b-0e9081e0a9d3"), 2L, null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2227), false, new Guid("8788579a-518c-4b91-8e83-f7a0bbd33e1d"), 3L, null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2233), false, new Guid("5bd91579-9ffd-4c57-aa78-7b00bd74d981"), 4L, null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2240), false, new Guid("3131a8ab-b786-49ff-aa57-ce177f856fd4"), 5L, null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2245), false, new Guid("becb893e-fe1b-40f4-81d6-79e68ac25fcd"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2250), false, new Guid("27e2a6de-79c6-43ae-b834-90981c1c77d0"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PN_ERP", "PN_RemoveRequestorApproval", "PN_ShowSupport", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1403), false, new Guid("6b8f14c5-edd5-4623-86b9-86d80b451f31"), 1L, null, "تعریف/اصلاح مشتری", null, 1L, true, true, true, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1424), false, new Guid("a362b359-5fb7-4c86-aed0-e32ec4146c96"), 2L, null, "مجوزهای موردی", null, 2L, true, true, true, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1434), false, new Guid("d30969a9-b93f-4cbb-8cf2-a8b98637c121"), 3L, null, "اعتباردهی مالی مشتری", null, 3L, true, true, true, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1461), false, new Guid("65fe0b12-a528-4f06-bb53-1025f83cf0f1"), 1L, null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1467), false, new Guid("64c56bbc-2b7b-4dc9-9bba-6dd512813cc3"), 2L, null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1497), false, new Guid("14d1ed7b-b06b-4ea7-9e20-ce8ffd3fa48e"), 3L, null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1502), false, new Guid("4d244f82-7e18-40dd-b176-994adb722767"), 4L, null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2151), false, new Guid("2dcda9fa-f34a-460f-b4cb-b67aba05a3ec"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2160), false, new Guid("68be4474-9d20-426f-9218-4ef36dbee5a3"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2166), false, new Guid("3afa2ef0-a9b8-40bf-be8a-0fb17299f43c"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2182), false, new Guid("267ceb4a-8692-4461-8430-9f5beaf6afd2"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2188), false, new Guid("12361ee4-e2f4-42a7-98ce-d8331395bf04"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1012), false, new Guid("2a9fe47a-365f-43f5-93bc-ca5e58a39c56"), 1L, null, "راهبرد یک", null, 1L, "Strategy1", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1134), false, new Guid("4a224b32-a51f-457b-b3b2-02921dd8bf55"), 2L, null, "راهبرد دو", null, 2L, "Strategy2", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1142), false, new Guid("5276e936-0482-4e5a-8579-65dd609c765b"), 3L, null, "راهبرد سه", null, 3L, "Strategy3", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1964), false, new Guid("cc37f017-fe90-4593-b692-f14956b96edb"), 1L, null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1976), false, new Guid("7654bd43-6ee3-4110-a934-ff4dd6fa076e"), 2L, null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1981), false, new Guid("005eb50a-967e-4c66-9bf0-65c6798afb22"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(1986), false, new Guid("6a6dfe4f-e203-4ae9-8af5-92058d2215c6"), 4L, null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2117), false, new Guid("2ca39d48-94d5-4c38-abd8-78907d21d88b"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2124), false, new Guid("954efff4-81de-48a3-999e-a9aa4d5db469"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2012), false, new Guid("39018793-b9ef-42f0-97ac-77faf8e65f32"), 100L, "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2019), false, new Guid("20a4469b-2f1f-42af-9a52-ca687801d5ed"), 101L, "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2026), false, new Guid("36ea4520-fed7-401e-ae26-7069b63ef9f2"), 103L, "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2031), false, new Guid("160d2477-f2e0-4e87-affe-9c6888bab153"), 200L, "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2037), false, new Guid("d1462c0f-cb0a-434f-89e2-0a22c649e3f0"), 201L, "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2044), false, new Guid("56c94e5c-c28d-4708-95ee-4947a83e5254"), 202L, "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2056), false, new Guid("8d226d74-efa5-490d-8f4d-749de69f6dd6"), 203L, "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2076), false, new Guid("e7585613-4853-45b2-bbfd-ae9f4608f5b3"), 204L, "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2081), false, new Guid("80311685-96bd-465c-8dbe-8253212da4da"), 205L, "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2087), false, new Guid("c68403a7-87fc-4450-a1ce-dc453dc3234f"), 206L, "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_StrategyId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2759), false, 1L, 1L, new Guid("6e5a0fc6-1d10-4d11-a6c4-e8793866e8db"), 1L, null, "راهبرد یک,معاونت دارویی", null, 1L, "Strategy1,PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2766), false, 2L, 1L, new Guid("56b04a1c-bec1-4cf9-a758-6d3f9aad2e23"), 2L, null, "راهبرد یک,معاونت غذایی", null, 2L, "Strategy1,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2775), false, 1L, 2L, new Guid("13ff9de9-c97e-4320-9198-4fd77de3179c"), 3L, null, "راهبرد دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2781), false, 2L, 2L, new Guid("76cc8413-0059-4efd-83c1-40a21e829a18"), 4L, null, "راهبرد دو,معاونت غذایی", null, 4L, "Strategy2,FMCGDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_Process_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2908), false, 1L, new Guid("544853f0-42ee-48c2-a1fd-af0b13678d6f"), 1L, null, "تعریف/اصلاح مشتری-راهبرد سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2915), false, 1L, new Guid("b61a2102-7995-47a3-8d67-f5887cd852c7"), 2L, null, "تعریف/اصلاح مشتری-راهبرد یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2921), false, 2L, new Guid("46f57212-8bf5-42bf-81bc-b9d6e36df50e"), 3L, null, "مجوزهای موردی-راهبرد یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2930), false, 1L, new Guid("f6ba93df-c764-44a8-8a38-412db3b393b5"), 4L, null, "تعریف/اصلاح مشتری-راهبرد دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2936), false, 2L, new Guid("c8d74fe1-0faa-4137-925c-a6c9be50fd88"), 5L, null, "مجوزهای موردی-راهبرد دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2837), false, 1L, new Guid("3806431e-c3d2-4a23-9c21-25adf6184110"), 1L, null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2843), false, 2L, new Guid("11ed2870-81fa-437c-8bf8-2bd42439e306"), 2L, null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2848), false, 3L, new Guid("6b060b70-805a-400e-b488-e4470c2c73dd"), 3L, null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2853), false, 3L, new Guid("71c88325-a832-409a-bd1f-20ba5ce7b3cf"), 4L, null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2859), false, 4L, new Guid("7cd64e72-81da-4e30-8696-130db462db37"), 5L, null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2864), false, 4L, new Guid("c6c1097b-556b-4286-ad4c-4c54bbeb0811"), 6L, null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2872), false, 5L, new Guid("63800b08-3fd9-4900-af30-6624f0ff2af5"), 7L, null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2807), false, 1L, new Guid("aad59292-b672-4ad1-b22c-1c0a8180ad31"), 1L, null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2814), false, 2L, new Guid("a47a16c0-b402-4167-8c9c-ac348bb3247d"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_OperandId", "CD_StrategyId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "F_RequestInformationId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 3L, 1L, 100L, "0", new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2708), null, false, null, new Guid("2f0d3253-15f1-4c9c-a55b-a08fb799d2c6"), 1L, null, "راهبرد1,سهم شرکت,بزرگتر از,0", null, 1L, "Strategy1,OursShare,>,0", null },
                    { 2L, 3L, 1L, 103L, "1000", new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2720), null, false, null, new Guid("50f2d32c-c7b9-4625-80ea-68b1385ee063"), 2L, null, "راهبرد1,مبلغ,بزگتر از,1000", null, 2L, "Strategy1,Price,>,1000", null },
                    { 3L, 1L, 2L, 100L, "0", new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2727), null, false, null, new Guid("4097eda2-a42e-44ff-83a9-9301682d0ce3"), 3L, null, "راهبرد2,سهم شرکت,مساوی,0", null, 3L, "Strategy2,OursShare,=,0", null },
                    { 4L, 5L, 2L, 103L, "1000", new DateTime(2023, 4, 30, 18, 35, 15, 352, DateTimeKind.Local).AddTicks(2733), null, false, null, new Guid("3e86deae-fcf0-47ea-b7ba-334537982065"), 4L, null, "راهبرد2,مبلغ,کوچکتر از,1000", null, 4L, "Strategy2,Price,<,1000", null }
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
                name: "IX_D_Process_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_DsblRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PIndex",
                schema: "Dimentions",
                table: "D_Process",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PName",
                schema: "Dimentions",
                table: "D_Process",
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
                name: "IX_D_Strategy_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_DsblRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_Parent_Id",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PCode",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PERPCode",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PIndex",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Strategy_PName",
                schema: "Dimentions",
                table: "D_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_DsblRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PIndex",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PName",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TG_TagTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_DsblRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PIndex",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PName",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PName",
                unique: true,
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
                name: "IX_F_Condition_CD_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_StrategyId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_StrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_TagId");

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
                name: "IX_F_Endorsement_CreateTimeRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_DsblRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ED_RoleId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_StrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PERPCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PIndex",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PName",
                schema: "Facts",
                table: "F_Endorsement",
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
                name: "IX_L_Process_Strategy_CreateTimeRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_DsblRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_FirstId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_LastUpdatedRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PERPCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PIndex",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PName",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                descending: new bool[0]);

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
                name: "IX_L_UserPosition_CreateTimeRecord",
                schema: "Links",
                table: "L_UserPosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_DsblRecord",
                schema: "Links",
                table: "L_UserPosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FirstId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserPosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PERPCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PIndex",
                schema: "Links",
                table: "L_UserPosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PName",
                schema: "Links",
                table: "L_UserPosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_SecondId",
                schema: "Links",
                table: "L_UserPosition",
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
                name: "L_Process_Strategy",
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
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_RequestInformation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Position",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Approve",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_AllApprove",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Endorsement",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Strategy",
                schema: "Dimentions");
        }
    }
}
