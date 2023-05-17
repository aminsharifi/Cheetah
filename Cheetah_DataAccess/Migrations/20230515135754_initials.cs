using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initials : Migration
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
                    { 101L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4700), false, null, new Guid("6f541730-e5e9-4bb9-a297-76a08db5ea0a"), 101L, null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4767), true, null, new Guid("9a2ed79e-9527-49ee-bcc2-b80af7916200"), 102L, null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4781), false, null, new Guid("6e955044-2b4e-4537-ba8e-a7cf8734c713"), 103L, null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4797), true, null, new Guid("fdd002c1-b2cf-4f00-9ee9-f6dbdd05f5a0"), 104L, null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4897), true, null, new Guid("081c33a1-ccff-48a0-b00b-042054e26a88"), 105L, null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4917), false, null, new Guid("c869500f-f88a-479f-9bc2-b41eec76346b"), 106L, null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4930), true, null, new Guid("59afddb0-e0e5-41e7-b0d9-5f801d3e0537"), 107L, null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4943), true, null, new Guid("4eff096a-690a-4f24-9b10-e8481928366f"), 108L, null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4955), true, null, new Guid("2f03defe-a320-4b1d-b710-745f00420855"), 109L, null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4970), false, null, new Guid("b659f356-53c1-4c0b-b877-6d825c1d142a"), 112L, null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4983), false, null, new Guid("62939f2b-5223-4e3b-b14d-f8a69fcde681"), 200L, null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5001), false, null, new Guid("7d53ce0c-f0be-4dab-bde5-1ad22b1c5013"), 201L, null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5012), false, null, new Guid("d57ffdc0-cf62-485e-9cb5-a31576954ee6"), 202L, null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5025), false, null, new Guid("eda901db-f780-484c-bdeb-005f40c6bba0"), 203L, null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5037), false, null, new Guid("631c2378-d0fb-482e-9a01-db98a072a445"), 204L, null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5058), true, null, new Guid("04a02718-f88d-4b52-ae97-7956ddbcd76f"), 205L, null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5071), true, null, new Guid("2200ea08-7630-46e5-a45c-805525c5ce52"), 206L, null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5084), false, null, new Guid("2f0cf5b4-de3e-4427-914f-2f19c2ea1bdc"), 300L, null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5096), false, null, new Guid("c454998b-1c0f-49cc-87cd-0b8b4df101a6"), 301L, null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5148), false, null, new Guid("1c5cb345-4364-4bee-9147-62c0ed811fc7"), 302L, null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5167), false, null, new Guid("3195fc0a-e600-46c4-b009-819f857487f5"), 303L, null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3884), null, new Guid("f68a3307-3b88-4802-8305-f2505c1f0687"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3922), null, new Guid("b56076a9-2e75-4a50-ba23-1ca3fcc36889"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3930), null, new Guid("f09eb99e-0f73-47ff-b162-1fd30681bb12"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4028), null, new Guid("348a5e16-27ce-4eef-b52c-1fcbf4d7dc9a"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4039), null, new Guid("779d4d55-3432-42a0-afb8-e6752622da6d"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4048), null, new Guid("a8b0381d-f3f5-4735-8899-7f6afbf5cfb1"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4062), null, new Guid("dc8d6053-808b-4aed-bf52-03d01e3cf8fe"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4070), null, new Guid("079ee751-6e38-4951-b027-01c807df7813"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4141), null, new Guid("2e3863a8-28b7-4aec-b594-6a47e4b8fccd"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4603), null, new Guid("3469a256-fa8b-45a3-b375-de9452f4c569"), 1L, null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4614), null, new Guid("5415fbd3-a33f-48f0-b789-8e890227f1d0"), 2L, null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4625), null, new Guid("2e50b7d4-aa18-42cd-9722-52fc8f3331e1"), 3L, null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4633), null, new Guid("e16d394c-b879-43fb-ad99-ce977961b402"), 4L, null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4643), null, new Guid("5ce2fb58-6190-42cb-a8da-772a047fe14e"), 5L, null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4651), null, new Guid("340e2a7c-fa23-4cd9-83ed-9e9724bcf23f"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4659), null, new Guid("d1ef36f7-49c0-4d4c-b211-6dc96990b07d"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3190), null, new Guid("1c250876-7391-40d5-a397-31005c9daf08"), true, true, true, 1L, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3329), null, new Guid("596062f0-71fd-4c35-b00c-0eeb8617aab7"), true, true, true, 2L, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3339), null, new Guid("76097811-7ec9-4815-91cf-1611753047ee"), true, true, true, 3L, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3773), null, new Guid("f087cdba-36a1-430a-9430-7224597b6abf"), 1L, null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3789), null, new Guid("e48e9d1d-0a71-4f28-a4e5-ef59c084682e"), 2L, null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3811), null, new Guid("decb3e8a-30e9-40bf-8b64-7870ad29bbcb"), 3L, null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3819), null, new Guid("48d33df7-20ed-4b2a-b562-e1c34ce3b775"), 4L, null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4530), null, new Guid("baa7cfe2-859e-49eb-80f7-2ebe399370ee"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4542), null, new Guid("832eb17f-2907-4e84-98f6-aaeba80aef55"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4551), null, new Guid("5d84d5d0-ffd4-4cb8-acda-973e1675c68d"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4559), null, new Guid("f6091525-1336-4038-865d-29e80216ec3e"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4567), null, new Guid("c21e564f-03df-475e-804c-c55ea6db32df"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4200), null, new Guid("91c09e7d-4fb6-4945-b4e1-a0cd96063cc5"), 1L, null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4210), null, new Guid("6e36fd2d-7cf5-4528-bd09-340033b2cd8a"), 2L, null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4217), null, new Guid("ba10db8e-1440-4143-98e2-48cc8e183d15"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4225), null, new Guid("2925afae-e1ac-421a-a857-3ea4aff15e27"), 4L, null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "F_AssignmentId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4405), null, null, new Guid("8b6d2b8e-77ba-4195-bd50-c4b2fcc42c62"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4418), null, null, new Guid("4a6740e6-5cb3-483f-bdce-a385c1fd4d94"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5232), null, new Guid("9779193b-752e-4382-8037-a2c6c013923e"), 1L, null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5243), null, new Guid("9caac6cd-ba50-4a4c-ac81-226e5928aada"), 2L, null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5252), null, new Guid("d61d4863-f452-4f50-bfb8-bacc11f32ec5"), 3L, null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4259), null, new Guid("06f50370-a840-43c0-8b38-e329f310fdc1"), 100L, "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4269), null, new Guid("eab959b6-a861-4b80-b5e6-ba4f1f150014"), 101L, "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4278), null, new Guid("addd2d07-c988-4b35-accf-af19207049b4"), 103L, "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4291), null, new Guid("6bbd680b-8bd0-4e95-9fed-d0c476d907ee"), 200L, "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4304), null, new Guid("75f4034f-dfc4-483a-a81a-85a6761047fc"), 201L, "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4313), null, new Guid("f62360cb-b4db-494b-bc9d-59f46740bf64"), 202L, "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4322), null, new Guid("71c1120d-9012-44c1-8031-8836ae476806"), 203L, "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4330), null, new Guid("6d260619-4efb-4366-9fb6-351f74c4d8bc"), 204L, "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4340), null, new Guid("3755f3b5-3e5b-46cb-aa30-d844be0fcd11"), 205L, "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4349), null, new Guid("8ca20c22-55af-4a27-b896-8be0b22e2805"), 206L, "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5370), null, 5L, 3L, new Guid("311d1027-0550-4acc-be42-c31887b97a8d"), 1L, null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5383), null, 2L, 3L, new Guid("0366b21d-81c9-4f95-ae45-a14aede4d8d3"), 2L, null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5392), null, 1L, 2L, new Guid("2667affc-eb14-4bb6-a8e6-dcb72180e65c"), 3L, null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5411), null, 2L, 1L, new Guid("65b399d0-9dd9-4f7a-8329-bb45ef52bc73"), 4L, null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5733), null, 1L, new Guid("0d434d09-915e-431e-be2f-1ecc7968dc6e"), 1L, null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5746), null, 1L, new Guid("3017e7ea-86ef-4ca7-88b4-5fcaf4dc17f7"), 2L, null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5756), null, 2L, new Guid("18a9b074-93fa-42af-b239-32a3666b3fc6"), 3L, null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5765), null, 1L, new Guid("085278ca-ff97-4aef-abbd-109cfea7d09b"), 4L, null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5773), null, 2L, new Guid("3da0f6e7-1af2-4aea-a336-f349145d8aac"), 5L, null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5617), null, 1L, new Guid("520a43e3-811c-4baf-9679-ac8fc4e08437"), 1L, null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5630), null, 2L, new Guid("aa48ca9d-f6d0-4651-ac5f-3038ae837db3"), 2L, null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5641), null, 3L, new Guid("1de90d60-f956-4c62-8c7d-5d90fa51d3f1"), 3L, null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5650), null, 3L, new Guid("90857bd9-9d33-4479-9d38-a4359a407449"), 4L, null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5658), null, 4L, new Guid("a7f69fa7-9786-481c-9e5d-8dadd031ccc4"), 5L, null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5666), null, 4L, new Guid("7251776d-4675-4a43-a7a8-c1568b773390"), 6L, null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5675), null, 5L, new Guid("0eed8bd6-fe7a-46a8-ae56-4129d6b2dd6c"), 7L, null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5520), null, 1L, new Guid("fe356d88-2a5c-4a53-9e4e-2131c9ca619a"), 1L, null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5570), null, 2L, new Guid("061e6a24-1bae-4893-91b5-0c43b30bb0ea"), 2L, null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5807), null, 1L, new Guid("253feeb0-ac50-42da-8d6a-2fabe2bd9b79"), 1L, null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5817), null, 2L, new Guid("e6df4da3-7807-40aa-ab30-9d067d5410c0"), 2L, null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5288), null, null, new Guid("177bd54d-ec9d-4034-ba45-50bc19d690c2"), 1L, null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5301), null, null, new Guid("43d96bb8-3885-4b30-8507-227136167afa"), 2L, null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5310), null, null, new Guid("21cc1ac7-2a97-4716-9698-b6ecc16e0899"), 3L, null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5322), null, null, new Guid("3a63ca2d-e782-4f5b-a1aa-ff0e619ee562"), 4L, null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5331), null, null, new Guid("2ff36702-ff30-4559-83d9-144bef48eaae"), 5L, null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
                name: "FK_F_Request_F_Assignment_RQT_CurrentAssignmentId",
                schema: "Facts",
                table: "F_Request");

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
        }
    }
}
