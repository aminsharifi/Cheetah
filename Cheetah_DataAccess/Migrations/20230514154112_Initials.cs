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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    Display = table.Column<bool>(type: "bit", nullable: false)
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PC_ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    PC_ERP = table.Column<bool>(type: "bit", nullable: true),
                    PC_RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true)
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                name: "D_TagType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Scenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Scenario_F_Scenario_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                name: "D_Tag",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    TG_TagTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                        column: x => x.TG_TagTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_Tag_D_Tag_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Endorsement",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ED_RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ED_ScenarioId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_F_Endorsement_F_Endorsement_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Scenario_ED_ScenarioId",
                        column: x => x.ED_ScenarioId,
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ProcessScenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    User_UserInformationId = table.Column<long>(type: "bigint", nullable: true),
                    F_AssignmentId = table.Column<long>(type: "bigint", nullable: true)
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
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
                name: "F_Assignment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PRM_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    PRM_ReviewId = table.Column<long>(type: "bigint", nullable: true),
                    F_RequestId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Assignment_F_Assignment_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Assignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Assignment_F_Endorsement_PRM_EndorsementId",
                        column: x => x.PRM_EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ATC_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATC_Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    F_ReviewId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
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
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    CD_TagId = table.Column<long>(type: "bigint", nullable: true),
                    CD_OperandId = table.Column<long>(type: "bigint", nullable: true),
                    CD_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CD_ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CD_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    CD_RequestId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_F_Condition_F_Endorsement_CD_EndorsementId",
                        column: x => x.CD_EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Scenario_CD_ScenarioId",
                        column: x => x.CD_ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Request",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RQT_ERPID = table.Column<long>(type: "bigint", nullable: true),
                    RQT_IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RQT_RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RQT_RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_Current_ReviewId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Request_D_ProcessState_RQT_ProcessStateId",
                        column: x => x.RQT_ProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_Process_RQT_ProcessId",
                        column: x => x.RQT_ProcessId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_User_RQT_CreatorId",
                        column: x => x.RQT_CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_User_RQT_RequestorId",
                        column: x => x.RQT_RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_F_Request_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Request",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Review",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    APV_PerformerId = table.Column<long>(type: "bigint", nullable: true),
                    APV_AssignmentId = table.Column<long>(type: "bigint", nullable: true),
                    APV_RequestId = table.Column<long>(type: "bigint", nullable: true),
                    APV_TagId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Review_D_Tag_APV_TagId",
                        column: x => x.APV_TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_D_User_APV_PerformerId",
                        column: x => x.APV_PerformerId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_Assignment_APV_AssignmentId",
                        column: x => x.APV_AssignmentId,
                        principalSchema: "Facts",
                        principalTable: "F_Assignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_Request_APV_RequestId",
                        column: x => x.APV_RequestId,
                        principalSchema: "Facts",
                        principalTable: "F_Request",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_Review_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Review",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 101L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4337), false, null, new Guid("225f325e-251e-4870-95d3-ddf1c9f03b91"), 101L, null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4403), true, null, new Guid("1cf878de-6c6b-4765-99c9-43d57138cfd2"), 102L, null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4410), false, null, new Guid("843bce16-b1d2-4b7a-8f36-abab43656c1e"), 103L, null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4419), true, null, new Guid("756b7b1d-603e-4bad-9dc5-82af9e165dfb"), 104L, null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4427), true, null, new Guid("e9025d14-40ef-4742-899c-b9fea6c1dd93"), 105L, null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4439), false, null, new Guid("522b8f7e-f073-48d8-9863-0dc31db9390c"), 106L, null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4446), true, null, new Guid("91e8566b-722d-4b8f-aab1-24045b848fbe"), 107L, null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4484), true, null, new Guid("a0f95a0c-ff39-438a-b87c-c8a91ad332b5"), 108L, null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4497), true, null, new Guid("3d6cbbe5-e022-40e9-a7ce-d717b34638bd"), 109L, null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4505), false, null, new Guid("2691e329-3903-4f03-aea8-678bd4bd8831"), 112L, null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4513), false, null, new Guid("080a8acd-4b78-4e4d-bf07-7f1912c23b0a"), 200L, null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4521), false, null, new Guid("824e2c27-eb03-46ad-89b1-c323c866a847"), 201L, null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4528), false, null, new Guid("832051a8-5aca-4aed-8884-48c3679c8ac8"), 202L, null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4536), false, null, new Guid("fdfcf70a-6ae2-455b-b0f0-fea99bb3edf6"), 203L, null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4545), false, null, new Guid("3f824fd1-97fd-4b0e-9f27-4377ee8f73c8"), 204L, null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4553), true, null, new Guid("827f1663-93c2-436f-8dc2-56d8ad6f516d"), 205L, null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4562), true, null, new Guid("fe21ffc6-c241-4c8f-bb0f-868edb5067e9"), 206L, null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4570), false, null, new Guid("6272a6fb-2766-45f9-9829-b7163d3bad82"), 300L, null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4577), false, null, new Guid("2bd0b6b3-f08b-4e94-8029-1d2b1d7f7979"), 301L, null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4585), false, null, new Guid("36c46f7b-bbbb-4388-a2ce-a3aa2984f843"), 302L, null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4597), false, null, new Guid("48982855-b452-456b-9619-4a5b6cb885e0"), 303L, null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3844), null, new Guid("637d8587-bd0f-4b25-aa66-533be78a492b"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3850), null, new Guid("15e1cf14-11cf-437c-8a2c-1219789957ec"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3856), null, new Guid("a21a7bc2-160d-4843-995e-3c6c020a18ea"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3885), null, new Guid("958fbfb5-470e-4e17-830b-4c9349a70309"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3890), null, new Guid("63a1b23c-5ade-4cd0-affa-c28383fd2b15"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3898), null, new Guid("5bac58cb-98b4-40be-9c65-9e2075abea28"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3903), null, new Guid("a7c95803-e923-4b61-8422-abe07802b6b6"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3907), null, new Guid("5200ad79-6d03-455c-b323-2b31cc8ea497"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3999), null, new Guid("29cc0c4b-b9b8-4ff4-82d5-6a7099e6d633"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4274), null, new Guid("c74fe3b4-db9b-40f1-88ef-0b4561d155dd"), 1L, null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4280), null, new Guid("5327f566-7793-4f13-9176-e08dd50a469b"), 2L, null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4284), null, new Guid("58c173ad-ce67-4d6d-b5e8-2c7c85730fd6"), 3L, null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4289), null, new Guid("9bbd903a-c223-4a4c-b276-6a0a570ffb41"), 4L, null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4294), null, new Guid("cf1a7cd3-c927-4acf-b73c-fd5ec495ab67"), 5L, null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4299), null, new Guid("3ac2e1ba-fce0-4e8b-82cc-406f1d2d1955"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4305), null, new Guid("06597bbe-6f0f-4c66-8c09-7df9e6bcde27"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3354), null, new Guid("8800a710-95b6-4da0-ad10-b5d4a7254ee4"), true, true, true, 1L, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3468), null, new Guid("945bf077-1d22-45f8-a9ce-2dc663f23467"), true, true, true, 2L, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3473), null, new Guid("fba40dc9-8578-45f9-97a7-8cedf1eddd96"), true, true, true, 3L, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3780), null, new Guid("3fa3d738-ced1-4deb-a91e-a78fccba4dd6"), 1L, null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3800), null, new Guid("5f9e5129-4bca-4128-b02e-d118d4669378"), 2L, null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3805), null, new Guid("e8db2308-43f3-4914-829d-9fd21b99a916"), 3L, null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(3809), null, new Guid("ded95a47-9a4a-434b-8f18-47bea07d1f4e"), 4L, null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4194), null, new Guid("db17e397-f01c-4c35-9fac-a0b32bf40704"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4200), null, new Guid("9e0a62d7-218a-48b1-aba5-1821bb3c3639"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4205), null, new Guid("fcced740-e14f-4c4d-a6d9-b965ca31122a"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4237), null, new Guid("2390bb56-893c-4aa4-9758-18202b842bee"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4246), null, new Guid("d023f25b-9324-4403-a21c-2364a8b4db80"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4043), null, new Guid("94b56019-81ff-4b29-ba06-fc7405431570"), 1L, null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4049), null, new Guid("6bd07c58-1cea-43c1-99bf-d9a8b66a28b3"), 2L, null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4054), null, new Guid("0a9b23bd-8d77-45a5-ac80-a74ec9d6ebf0"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4060), null, new Guid("3baa4ee6-7b84-428f-8ff2-a666828ea29d"), 4L, null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "F_AssignmentId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4160), null, null, new Guid("753cc48f-580e-41ba-bd91-d5ca3928e710"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4166), null, null, new Guid("c4587440-a093-4ba1-a2c6-7d1094f166f7"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4665), null, new Guid("c5091d81-f3a8-4196-8afe-c41120172f3e"), 1L, null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4676), null, new Guid("645b1876-ea9a-431b-ab01-5653976f88f1"), 2L, null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4682), null, new Guid("fbf88567-5b35-443f-b19a-d0b2212d4edf"), 3L, null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4083), null, new Guid("6b248940-a7eb-4f8c-b18d-cb04925c0881"), 100L, "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4088), null, new Guid("9564b685-ee68-4e84-81b8-8f8c6d28fd07"), 101L, "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4094), null, new Guid("19f88cfe-0839-417d-bca5-7e0029ca2337"), 103L, "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4099), null, new Guid("14cf511d-71e7-49a5-ad69-3b8ef7d635ea"), 200L, "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4104), null, new Guid("91362dc2-dbba-44c5-b8ac-3808fe3f62e6"), 201L, "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4109), null, new Guid("fb43be81-46c2-4183-b3d7-86212f540984"), 202L, "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4114), null, new Guid("ce38a65b-6fd7-47f7-a691-d6a7db03c983"), 203L, "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4120), null, new Guid("4722c6d7-66ab-4f35-b51a-6c3a9db83775"), 204L, "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4127), null, new Guid("d36f0183-ff42-4e81-b2e1-8cf7ac0c106a"), 205L, "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4132), null, new Guid("0fde4180-6bab-4ff8-bc2f-d73dd47057aa"), 206L, "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4765), null, 5L, 1L, new Guid("0ac981f0-0dfb-4710-b78f-b570297775e0"), 1L, null, "سناریو دارویی,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4773), null, 2L, 1L, new Guid("c4cd2cb7-4ff5-498e-b938-2639941c0406"), 2L, null, "سناریو دارویی,معاونت دارویی", null, 2L, "Med_Scenario,PharmaceuticalDeputy", null },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4778), null, 1L, 2L, new Guid("e50695cf-f387-4f97-9408-5d39edb702a5"), 3L, null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4786), null, 2L, 2L, new Guid("39c7281a-d519-4fac-b668-53e779a9cf2a"), 4L, null, "سناریو دو,معاونت غذایی", null, 4L, "Strategy2,FMCGDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4941), null, 1L, new Guid("4c4f1776-1be1-419e-9979-264a3aa65b9f"), 1L, null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4947), null, 1L, new Guid("b8e1e736-bfa3-40b2-9845-1dcbb7639348"), 2L, null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4952), null, 2L, new Guid("ef9c4726-33a7-4f23-9108-870ba5f45aa4"), 3L, null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4957), null, 1L, new Guid("a506721d-4066-4169-a83e-a712cc047887"), 4L, null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4961), null, 2L, new Guid("3050f8a0-7deb-4697-b94a-859bb69c4489"), 5L, null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4846), null, 1L, new Guid("820cfd3a-5d4d-4705-b5b8-72acfde7c071"), 1L, null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4852), null, 2L, new Guid("874dc1c5-98df-4207-97a3-5c3d5e795f02"), 2L, null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4857), null, 3L, new Guid("11d42488-ce06-43d5-8c85-8930ad9d3b6e"), 3L, null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4862), null, 3L, new Guid("687c9a4a-0052-4c93-9a57-acc28c31572f"), 4L, null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4868), null, 4L, new Guid("3fda2126-e735-4f6b-b064-3981784cff11"), 5L, null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4903), null, 4L, new Guid("0106a48b-81e1-4b15-8444-42af47682beb"), 6L, null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4911), null, 5L, new Guid("f51f3245-94de-46ba-995a-48218d0c1904"), 7L, null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4817), null, 1L, new Guid("376560a9-96fc-4331-9b69-40664112a6e5"), 1L, null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4824), null, 2L, new Guid("aed4d5e8-b1d5-41d0-8e90-32dc9cecfafc"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, null, 3L, null, 1L, 100L, "0", new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4712), null, null, new Guid("b2ee4175-175b-4350-80a4-824e9fd85c2c"), 1L, null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4721), null, null, new Guid("44450d9d-9749-453e-a003-06b8123625cb"), 2L, null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4727), null, null, new Guid("d544d10a-60d7-49fb-a018-7a7f3250a32e"), 3L, null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4734), null, null, new Guid("30fcfc61-6e32-4bc3-a8ca-71c5e8084f7f"), 4L, null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 5, 14, 20, 11, 11, 543, DateTimeKind.Local).AddTicks(4739), null, null, new Guid("bbfcf93f-8ee7-4519-85f6-1d19f31c8d36"), 5L, null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_PName",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PName",
                schema: "Dimentions",
                table: "D_Location",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PName",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PName",
                schema: "Dimentions",
                table: "D_Position",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_PName",
                schema: "Dimentions",
                table: "D_Process",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PName",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PName",
                schema: "Dimentions",
                table: "D_Role",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_ROL_Independent",
                schema: "Dimentions",
                table: "D_Role",
                column: "ROL_Independent",
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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_PName",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_PName",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                name: "IX_D_User_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User",
                column: "F_AssignmentId");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PName",
                schema: "Dimentions",
                table: "D_User",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_PName",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_CreateTimeRecord",
                schema: "Facts",
                table: "F_Assignment",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_DsblRecord",
                schema: "Facts",
                table: "F_Assignment",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "F_RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Assignment",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_Parent_Id",
                schema: "Facts",
                table: "F_Assignment",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PCode",
                schema: "Facts",
                table: "F_Assignment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PERPCode",
                schema: "Facts",
                table: "F_Assignment",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PIndex",
                schema: "Facts",
                table: "F_Assignment",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PName",
                schema: "Facts",
                table: "F_Assignment",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PRM_EndorsementId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_ReviewId");

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
                name: "IX_F_Attachment_F_ReviewId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ReviewId");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PName",
                schema: "Facts",
                table: "F_Attachment",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_EndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_RequestId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CD_ScenarioId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_ScenarioId");

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
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_PERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "PERPCode",
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
                name: "IX_F_Endorsement_ED_ScenarioId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_ScenarioId");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_PName",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_CreateTimeRecord",
                schema: "Facts",
                table: "F_Request",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_DsblRecord",
                schema: "Facts",
                table: "F_Request",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Request",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_Parent_Id",
                schema: "Facts",
                table: "F_Request",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_PERPCode",
                schema: "Facts",
                table: "F_Request",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_CreatorId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_Current_ReviewId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_Current_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_ProcessId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_ProcessStateId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_ProcessStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RQT_RequestorId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_PerformerId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_RequestId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_TagId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_CreateTimeRecord",
                schema: "Facts",
                table: "F_Review",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_DsblRecord",
                schema: "Facts",
                table: "F_Review",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Review",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_Parent_Id",
                schema: "Facts",
                table: "F_Review",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PCode",
                schema: "Facts",
                table: "F_Review",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PERPCode",
                schema: "Facts",
                table: "F_Review",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PIndex",
                schema: "Facts",
                table: "F_Review",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PName",
                schema: "Facts",
                table: "F_Review",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_CreateTimeRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_DsblRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PIndex",
                schema: "Facts",
                table: "F_Scenario",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_PName",
                schema: "Facts",
                table: "F_Scenario",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_CreateTimeRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_DsblRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_LastUpdatedRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PIndex",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PName",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_PName",
                schema: "Links",
                table: "L_RolePosition",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_PName",
                schema: "Links",
                table: "L_UserLocation",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

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
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_PName",
                schema: "Links",
                table: "L_UserPosition",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_SecondId",
                schema: "Links",
                table: "L_UserPosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_F_Assignment_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User",
                column: "F_AssignmentId",
                principalSchema: "Facts",
                principalTable: "F_Assignment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Assignment_F_Request_F_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "F_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Assignment_F_Review_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Review_F_ReviewId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Request_CD_RequestId",
                schema: "Facts",
                table: "F_Condition",
                column: "CD_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Request_F_Review_RQT_Current_ReviewId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_Current_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_UserInformation_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_D_User_F_Assignment_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Review_F_Assignment_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Review_F_Request_APV_RequestId",
                schema: "Facts",
                table: "F_Review");

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
                name: "D_Operand",
                schema: "Dimentions");

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
                name: "D_UserInformation",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Assignment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Endorsement",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Request",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Review",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");
        }
    }
}
