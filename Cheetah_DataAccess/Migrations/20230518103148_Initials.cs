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
                    PRM_RequestId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "L_UserAssignment",
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
                    table.PrimaryKey("PK_L_UserAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserAssignment_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserAssignment_F_Assignment_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RQT_Current_ReviewId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_CurrentAssignmentId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_F_Request_F_Assignment_RQT_CurrentAssignmentId",
                        column: x => x.RQT_CurrentAssignmentId,
                        principalSchema: "Facts",
                        principalTable: "F_Assignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_F_Request_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Request",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_F_Scenario_RQT_SelectedScenarioId",
                        column: x => x.RQT_SelectedScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
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
                    { 101L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6401), false, null, new Guid("7f337e84-2210-4847-a322-88ccce277cd6"), 101L, null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6551), true, null, new Guid("7e20c783-5e2e-4e97-9ca3-65f67a0d1ca7"), 102L, null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6562), false, null, new Guid("22918ebf-7ff0-42e2-b4ea-f4009595aa20"), 103L, null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6570), true, null, new Guid("301fe2be-eac5-421e-b8f3-707d76bb8c5f"), 104L, null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6578), true, null, new Guid("783b3ecc-69bc-4435-a06d-9f121e161dad"), 105L, null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6589), false, null, new Guid("64afe918-6c40-45ec-ad5b-ef1b875c2916"), 106L, null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6597), true, null, new Guid("063e078b-7f1c-4437-a0cf-01848eaa31a1"), 107L, null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6606), true, null, new Guid("7caadc24-13ab-4263-a431-3353aa355967"), 108L, null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6613), true, null, new Guid("12608b03-3d21-4880-9a95-8ac4bab2eae8"), 109L, null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6620), false, null, new Guid("dd8dab2c-3619-4f1c-84ca-5d7ec3ca1aa8"), 112L, null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6627), false, null, new Guid("0b2f29c2-f4ef-4618-a5a0-393f0decde84"), 200L, null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6645), false, null, new Guid("6c779f5e-679d-4f15-b937-16d4df54ef86"), 201L, null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6653), false, null, new Guid("e919b6d7-c6ca-4d83-b5da-a55a228bcfd2"), 202L, null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6664), false, null, new Guid("3878086a-330a-455c-b122-ccf582322607"), 203L, null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6671), false, null, new Guid("0a3d6e3a-d84c-4cbd-bb50-bc239f931aa6"), 204L, null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6679), true, null, new Guid("e7b9f9d3-706a-4bd8-9df9-abdc4bc194ea"), 205L, null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6686), true, null, new Guid("acedf1ba-b1ef-4a9e-bd0c-899f1d454dd0"), 206L, null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6693), false, null, new Guid("c6ccc100-7a2b-473f-a78a-8891cc3dbc0f"), 300L, null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6700), false, null, new Guid("ff1367f4-6a93-47ab-906c-6d8a88dba273"), 301L, null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6708), false, null, new Guid("778f0609-4e03-4316-9015-cd27e6811141"), 302L, null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6717), false, null, new Guid("ba6e6c14-1c94-44ea-ad14-5c69a03bb8fe"), 303L, null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5992), null, new Guid("2e041318-1ca1-450b-86ac-1b9a5d1b9ae3"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6006), null, new Guid("0e91cccf-4820-4b71-9957-2ed56d19e5d4"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6014), null, new Guid("35afce6a-b537-4cd3-87e0-28486b2620ab"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6048), null, new Guid("cf92427c-a7df-40ba-8fa2-d2f187e8170d"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6054), null, new Guid("221246ea-3c09-46aa-80f9-d85eec3b4236"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6059), null, new Guid("ae469e88-2a6f-44c5-b42c-e72bd76a84b1"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6064), null, new Guid("5eb5e228-2f6e-46ec-ada8-9d927ea6ea53"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6068), null, new Guid("c6c27213-af4a-47ba-8dd3-83212795ad21"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6073), null, new Guid("f1676c25-a674-4d5d-8adb-e1180bb47d52"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6334), null, new Guid("f6d60597-2a39-4bdf-bf26-b1a64af9a671"), 1L, null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6340), null, new Guid("e11d3fb7-7ccc-4569-97fd-f5d9af893889"), 2L, null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6345), null, new Guid("9cae8b52-768f-44d2-9404-37d4ff7d1e6c"), 3L, null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6350), null, new Guid("5a37fb92-517e-4543-9137-c32a1c68da58"), 4L, null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6364), null, new Guid("a471435d-7c4f-4cf9-804c-5d1156e393ae"), 5L, null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6370), null, new Guid("6954fe6f-555b-4ffc-9371-34a33cb5eee6"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6374), null, new Guid("618d98c7-87a4-4d80-8611-4695c4d66332"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5397), null, new Guid("16bbe5e5-ee8c-4e30-83ec-f8ee3cb6b74f"), true, true, true, 1L, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5572), null, new Guid("97616aa7-6d70-4414-bc88-a0f80ac5cb72"), true, true, true, 2L, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5578), null, new Guid("a037a221-c915-4473-97a5-72c43d69457a"), true, true, true, 3L, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5865), null, new Guid("45b22767-8321-4dfa-bc15-ccd9e834cc7b"), 1L, null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5874), null, new Guid("c78cd4a9-24df-4914-ab7c-f691e515f911"), 2L, null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5878), null, new Guid("9aa362a2-ee36-45e9-9f92-da4855511d8d"), 3L, null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(5883), null, new Guid("d1e698c7-4ab0-4d8d-b39c-96b77e75d1c3"), 4L, null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6281), null, new Guid("17bdfc0c-ab41-485a-b354-cded6963749e"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6290), null, new Guid("a26523ec-279c-40d3-a09a-8ef34d397750"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6295), null, new Guid("99777af7-dae8-4d61-a4e8-449ff8b4d9dc"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6304), null, new Guid("31363f7c-f16c-4d95-8f03-6f0d82b7b3f0"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6309), null, new Guid("e137a6e9-a9f3-499c-adc5-2af52cbe90b6"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6110), null, new Guid("f9bae5d6-1429-4f87-b818-0bdfe73a3f4c"), 1L, null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6119), null, new Guid("76f687c7-638d-47e0-be0b-fe44efa08066"), 2L, null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6125), null, new Guid("3bff50bc-22d0-4703-85c8-83fe277d96c4"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6130), null, new Guid("158c744e-6a38-408f-bd8f-43ad50607c4a"), 4L, null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6247), null, new Guid("4302d7fb-3409-48d8-885d-d53b6c37b667"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6253), null, new Guid("9e9a1f13-0d5c-46c4-b8d5-5ee5428f2467"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6762), null, new Guid("7a06602e-29fa-4ba9-aa10-8b92b1186f2b"), 1L, null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6772), null, new Guid("1e0ca88a-996e-44dd-bba7-085a70ff8016"), 2L, null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6776), null, new Guid("e715f44d-367e-4d25-b756-068c460892e3"), 3L, null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6152), null, new Guid("cba56c28-cf21-40a7-a76d-90e29312abdf"), 100L, "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6159), null, new Guid("cc1d343d-ab60-4a07-9df8-3b7b669a0977"), 101L, "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6164), null, new Guid("acfaa046-19a3-42f7-985f-355df4b0cc4b"), 103L, "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6178), null, new Guid("ec0e3aa2-9bdd-4221-867e-1d4eb224e85d"), 200L, "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6183), null, new Guid("e2d8e4d4-1520-475b-803f-2d3aeec094d8"), 201L, "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6190), null, new Guid("4503c52a-8003-47d4-be66-f58c0e5f7eb5"), 202L, "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6197), null, new Guid("776109df-d151-47f5-a473-d3ca4daf1b42"), 203L, "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6203), null, new Guid("f1fe9ca5-be37-4816-b94b-a24b226740b7"), 204L, "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6207), null, new Guid("6bf46003-8e7f-4125-8058-f9907d15cd0c"), 205L, "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6212), null, new Guid("e6768e9a-2597-4af3-b15e-6a533fb741c3"), 206L, "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6878), null, 5L, 3L, new Guid("701cf756-03c7-4cd8-8983-bf454cd2307c"), 1L, null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6890), null, 2L, 3L, new Guid("e4455796-9422-44b2-9112-9048dcf97ae6"), 2L, null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6896), null, 1L, 2L, new Guid("11670b07-8335-4492-aafe-7f74cd6eae58"), 3L, null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6901), null, 2L, 1L, new Guid("a9219c27-d9af-462d-bbbb-82c5429ba592"), 4L, null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7030), null, 1L, new Guid("736f75b8-d56f-4409-9853-ce4b65e1c195"), 1L, null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7036), null, 1L, new Guid("414f289b-f210-4c1d-ab6a-393b5a1a4c21"), 2L, null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7042), null, 2L, new Guid("ac843896-0558-4f30-b457-2a4ef7eb60cc"), 3L, null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7048), null, 1L, new Guid("711b73d5-0773-4db9-8ce4-9341c768da1f"), 4L, null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7054), null, 2L, new Guid("d3aadb96-0f38-48ad-8a49-b3ec3db4be6c"), 5L, null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6966), null, 1L, new Guid("fd21e6de-5d99-4bbc-9582-ca88f16fbbb5"), 1L, null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6972), null, 2L, new Guid("20096c32-9faf-4d49-91f0-f5d431c062c7"), 2L, null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6979), null, 3L, new Guid("86bd344c-e500-4d1a-aa5f-379e2ecfa985"), 3L, null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6984), null, 3L, new Guid("c3d6eab6-353b-4af0-8f6b-6ac4eef169e8"), 4L, null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6989), null, 4L, new Guid("3fc40d17-9bdb-44b6-b878-dde651889743"), 5L, null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6996), null, 4L, new Guid("563cbb29-3b36-44c2-8beb-da9ea1fe23e1"), 6L, null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7000), null, 5L, new Guid("85b6c2cc-502b-4c3f-8a5a-0352fe8cef2d"), 7L, null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6935), null, 1L, new Guid("ce8a0b9b-bea3-43dc-ac1e-0533221ce4a6"), 1L, null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6942), null, 2L, new Guid("b63ac42e-0589-4ad2-9d2c-d39e33f5e162"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7076), null, 1L, new Guid("65103cb2-d9aa-495b-b1fa-57ee98f36661"), 1L, null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(7090), null, 2L, new Guid("7dc9a1d8-433d-4c92-9b36-d4b1cc8f284f"), 2L, null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6816), null, null, new Guid("2cb905cf-87da-4ba5-960d-fcc5ff3509fc"), 1L, null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6826), null, null, new Guid("d755208c-d1f9-4aa6-aff4-54a3e98b1516"), 2L, null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6832), null, null, new Guid("8d27a4e7-c563-4296-86ce-6d13abda36da"), 3L, null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6838), null, null, new Guid("4548108a-da29-4216-88f6-e59de96c03c4"), 4L, null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 5, 18, 15, 1, 47, 501, DateTimeKind.Local).AddTicks(6843), null, null, new Guid("2e5b6d98-9e1b-45ce-9134-27f9f3f00182"), 5L, null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
                name: "IX_F_Assignment_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_RequestId");

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
                name: "IX_F_Request_RQT_CurrentAssignmentId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_CurrentAssignmentId");

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
                name: "IX_F_Request_RQT_SelectedScenarioId",
                schema: "Facts",
                table: "F_Request",
                column: "RQT_SelectedScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_AssignmentId",
                unique: true,
                filter: "[APV_AssignmentId] IS NOT NULL");

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
                name: "IX_L_UserAssignment_CreateTimeRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_DsblRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_FirstId",
                schema: "Links",
                table: "L_UserAssignment",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PCode",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PERPCode",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PIndex",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PName",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_SecondId",
                schema: "Links",
                table: "L_UserAssignment",
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
                name: "FK_F_Assignment_F_Request_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
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
                name: "FK_F_Assignment_F_Endorsement_PRM_EndorsementId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Request_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment");

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
                name: "L_UserAssignment",
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
                name: "F_Endorsement",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

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
                name: "F_Scenario",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Assignment",
                schema: "Facts");
        }
    }
}
