using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CheetahDataAccess.Migrations
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
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Entity_D_Entity_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_FieldType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_FieldType_D_FieldType_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Location_D_Location_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Operand_D_Operand_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    RTShowSupport = table.Column<bool>(name: "RT_ShowSupport", type: "bit", nullable: true),
                    RTCheckList = table.Column<bool>(name: "RT_CheckList", type: "bit", nullable: true),
                    RTERP = table.Column<bool>(name: "RT_ERP", type: "bit", nullable: true),
                    RTAnotherRequester = table.Column<bool>(name: "RT_AnotherRequester", type: "bit", nullable: true),
                    RTRemoveRequestorApproval = table.Column<bool>(name: "RT_RemoveRequestorApproval", type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_RequestTitle_D_RequestTitle_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Role_D_Role_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Skill",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Skill_D_Skill_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_UnitType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UnitType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_UnitType_D_UnitType_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UnitType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserInformation",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UIFirstName = table.Column<string>(name: "UI_FirstName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UILastName = table.Column<string>(name: "UI_LastName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UINotifByEmail = table.Column<bool>(name: "UI_NotifByEmail", type: "bit", nullable: true),
                    UINotifByMessenger = table.Column<bool>(name: "UI_NotifByMessenger", type: "bit", nullable: true),
                    UINotifByCell = table.Column<bool>(name: "UI_NotifByCell", type: "bit", nullable: true),
                    UIContactEmail = table.Column<string>(name: "UI_ContactEmail", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UIContactMessenger = table.Column<string>(name: "UI_ContactMessenger", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UIContactCell = table.Column<string>(name: "UI_ContactCell", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UIUserPicture = table.Column<byte[]>(name: "UI_UserPicture", type: "varbinary(max)", nullable: true),
                    UINationalCode = table.Column<string>(name: "UI_NationalCode", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UIBirthdate = table.Column<DateTime>(name: "UI_Birthdate", type: "datetime2", nullable: true),
                    UIInternalPhone = table.Column<string>(name: "UI_InternalPhone", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UIAddress = table.Column<string>(name: "UI_Address", type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UIRegistrationNumber = table.Column<string>(name: "UI_RegistrationNumber", type: "nvarchar(215)", maxLength: 215, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserInformation_F_UserInformation_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserInformation",
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
                name: "D_ParameterType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    PTPFieldTypeId = table.Column<long>(name: "PT_P_FieldTypeId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeId",
                        column: x => x.PTPFieldTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_FieldType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ParameterType_D_ParameterType_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    PSOIndependentLocation = table.Column<bool>(name: "PSO_Independent_Location", type: "bit", nullable: true),
                    PSODefaultLocationId = table.Column<long>(name: "PSO_Default_LocationId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Position_D_Location_PSO_Default_LocationId",
                        column: x => x.PSODefaultLocationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_Position_D_Position_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_SubRequestTitle",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    DRequestTitleId = table.Column<long>(name: "D_RequestTitleId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_SubRequestTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId",
                        column: x => x.DRequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_SubRequestTitle_D_SubRequestTitle_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_SubRequestTitle",
                        principalColumn: "Id");
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    AreaUnitTypeId = table.Column<long>(name: "Area_UnitTypeId", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Area_D_Area_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_Area_D_UnitType_Area_UnitTypeId",
                        column: x => x.AreaUnitTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UnitType",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UserDomain = table.Column<string>(name: "User_Domain", type: "nvarchar(25)", maxLength: 25, nullable: true),
                    UserEnabledForAssignation = table.Column<bool>(name: "User_EnabledForAssignation", type: "bit", nullable: true),
                    UserDelegateEnabled = table.Column<bool>(name: "User_DelegateEnabled", type: "bit", nullable: true),
                    UserCreatedCasesSkipAssigRules = table.Column<bool>(name: "User_CreatedCasesSkipAssigRules", type: "bit", nullable: true),
                    UserIDPersonel = table.Column<string>(name: "User_IDPersonel", type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserLDAPDescription = table.Column<string>(name: "User_LDAPDescription", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserBossUserId = table.Column<long>(name: "User_BossUserId", type: "bigint", nullable: true),
                    UserDelegateId = table.Column<long>(name: "User_DelegateId", type: "bigint", nullable: true),
                    UserUserInformationId = table.Column<long>(name: "User_UserInformationId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_F_UserInformation_User_UserInformationId",
                        column: x => x.UserUserInformationId,
                        principalSchema: "Facts",
                        principalTable: "F_UserInformation",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    PLParameterTypeId = table.Column<long>(name: "PL_ParameterTypeId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ParameterList_D_ParameterList_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeId",
                        column: x => x.PLParameterTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "D_ProcessEndorsement",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    PSEMail = table.Column<bool>(name: "PSE_Mail", type: "bit", nullable: true),
                    PSEAutomation = table.Column<bool>(name: "PSE_Automation", type: "bit", nullable: true),
                    PSESMS = table.Column<bool>(name: "PSE_SMS", type: "bit", nullable: true),
                    PSETranscript = table.Column<bool>(name: "PSE_Transcript", type: "bit", nullable: true),
                    PSENeedApprove = table.Column<bool>(name: "PSE_NeedApprove", type: "bit", nullable: true),
                    PSESendAll = table.Column<bool>(name: "PSE_SendAll", type: "bit", nullable: true),
                    PSESubRequestTitleId = table.Column<long>(name: "PSE_SubRequestTitleId", type: "bigint", nullable: true),
                    PSEExpertUserId = table.Column<long>(name: "PSE_ExpertUserId", type: "bigint", nullable: true),
                    PSERequestTitleId = table.Column<long>(name: "PSE_RequestTitleId", type: "bigint", nullable: true),
                    PSEProcessStateId = table.Column<long>(name: "PSE_ProcessStateId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessEndorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_ProcessEndorsement_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                        column: x => x.PSEProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                        column: x => x.PSERequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                        column: x => x.PSESubRequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_SubRequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_User_PSE_ExpertUserId",
                        column: x => x.PSEExpertUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_L_UserRole", x => x.Id);
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
                name: "L_UserSkill",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false),
                    DPositionId = table.Column<long>(name: "D_PositionId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_Position_D_PositionId",
                        column: x => x.DPositionId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_Skill_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserSkill_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "F_EndorsementPosition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UPProcessEndorsementId = table.Column<long>(name: "UP_ProcessEndorsementId", type: "bigint", nullable: true),
                    UPPositionOrgId = table.Column<long>(name: "UP_PositionOrgId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_D_Position_UP_PositionOrgId",
                        column: x => x.UPPositionOrgId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_D_ProcessEndorsement_UP_ProcessEndorsementId",
                        column: x => x.UPProcessEndorsementId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementPosition_F_EndorsementPosition_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementPosition",
                        principalColumn: "Id");
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    AAPCurrentApproveId = table.Column<long>(name: "AAP_Current_ApproveId", type: "bigint", nullable: true),
                    AAPLastApproveId = table.Column<long>(name: "AAP_Last_ApproveId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_AllApprove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_AllApprove_F_AllApprove_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    APVSubject = table.Column<string>(name: "APV_Subject", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APVUserInChargeId = table.Column<long>(name: "APV_UserInChargeId", type: "bigint", nullable: true),
                    APVProcessEndorsementId = table.Column<long>(name: "APV_ProcessEndorsementId", type: "bigint", nullable: true),
                    APVNeedApproveId = table.Column<long>(name: "APV_NeedApproveId", type: "bigint", nullable: true),
                    APVApproveId = table.Column<long>(name: "APV_ApproveId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Approve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementId",
                        column: x => x.APVProcessEndorsementId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_D_User_APV_UserInChargeId",
                        column: x => x.APVUserInChargeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_ApproveId",
                        column: x => x.APVApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_NeedApproveId",
                        column: x => x.APVNeedApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_Approve_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    RIERPID = table.Column<long>(name: "RI_ERPID", type: "bigint", nullable: true),
                    RIIsCancelled = table.Column<bool>(name: "RI_IsCancelled", type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RIPELevel = table.Column<byte>(name: "RI_PE_Level", type: "tinyint", nullable: true),
                    RIRequestDate = table.Column<DateTime>(name: "RI_RequestDate", type: "datetime2", nullable: true),
                    RIRequestFinishDate = table.Column<DateTime>(name: "RI_RequestFinishDate", type: "datetime2", nullable: true),
                    RIExpertUserId = table.Column<long>(name: "RI_ExpertUserId", type: "bigint", nullable: true),
                    RIRequestorId = table.Column<long>(name: "RI_RequestorId", type: "bigint", nullable: true),
                    RICreatorId = table.Column<long>(name: "RI_CreatorId", type: "bigint", nullable: true),
                    RIAllApproveId = table.Column<long>(name: "RI_AllApproveId", type: "bigint", nullable: true),
                    RIProcessStateId = table.Column<long>(name: "RI_ProcessStateId", type: "bigint", nullable: true),
                    RIRequestTitleId = table.Column<long>(name: "RI_RequestTitleId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RequestInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateId",
                        column: x => x.RIProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleId",
                        column: x => x.RIRequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                        column: x => x.RICreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_ExpertUserId",
                        column: x => x.RIExpertUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                        column: x => x.RIRequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveId",
                        column: x => x.RIAllApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_RequestInformation_Parent_Id",
                        column: x => x.ParentId,
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    ATCName = table.Column<string>(name: "ATC_Name", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATCData = table.Column<byte[]>(name: "ATC_Data", type: "varbinary(max)", nullable: true),
                    FApproveId = table.Column<long>(name: "F_ApproveId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Attachment_F_Approve_F_ApproveId",
                        column: x => x.FApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_Approve",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Attachment_F_Attachment_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_Attachment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_ListOfParameter",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    LOPFloatValue = table.Column<float>(name: "LOP_FloatValue", type: "real", nullable: true),
                    LOPBooleanValue = table.Column<bool>(name: "LOP_BooleanValue", type: "bit", nullable: true),
                    LOPStringValue = table.Column<string>(name: "LOP_StringValue", type: "nvarchar(max)", nullable: true),
                    LOPParameterListId = table.Column<long>(name: "LOP_ParameterListId", type: "bigint", nullable: true),
                    LOPParameterTypeId = table.Column<long>(name: "LOP_ParameterTypeId", type: "bigint", nullable: true),
                    PTOperandId = table.Column<long>(name: "PT_OperandId", type: "bigint", nullable: true),
                    DProcessEndorsementId = table.Column<long>(name: "D_ProcessEndorsementId", type: "bigint", nullable: true),
                    DUserId = table.Column<long>(name: "D_UserId", type: "bigint", nullable: true),
                    FRequestInformationId = table.Column<long>(name: "F_RequestInformationId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_ListOfParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_Operand_PT_OperandId",
                        column: x => x.PTOperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListId",
                        column: x => x.LOPParameterListId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeId",
                        column: x => x.LOPParameterTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementId",
                        column: x => x.DProcessEndorsementId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_User_D_UserId",
                        column: x => x.DUserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_F_ListOfParameter_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_ListOfParameter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationId",
                        column: x => x.FRequestInformationId,
                        principalSchema: "Facts",
                        principalTable: "F_RequestInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9772), false, new Guid("a660f433-5828-4956-b9a4-65f598c61713"), 1L, null, "پارامتریک", null, 1L, "Parameter", null },
                    { 2L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9897), false, new Guid("5648141d-6a32-4d46-9a39-21af80b6b009"), 2L, null, "عددی", null, 2L, "Number", null },
                    { 3L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9935), false, new Guid("4cb60d1a-6982-4bea-bb02-d193bf6ceaf1"), 3L, null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9991), false, new Guid("0f5cf115-cb4c-4462-bef2-c21f88cb67c3"), 4L, null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(138), false, new Guid("38d9969a-8922-402d-8a45-621fad7fad10"), 1L, null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(148), false, new Guid("e2f81c46-0769-4de1-ae04-8da6b5bcaf3f"), 2L, null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(156), false, new Guid("4af3c481-0517-4d29-817b-2fbffe7efa91"), 3L, null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(172), false, new Guid("99fb4270-6d42-491e-bb02-8a8d4066bf07"), 4L, null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(180), false, new Guid("8b1ae490-81c9-4d51-9a37-1d84a720ae8d"), 5L, null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(187), false, new Guid("b184ff41-78c8-42d9-bfae-adb21ff357ec"), 6L, null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "PT_P_FieldTypeId", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(304), false, new Guid("5919e329-914a-49e2-96b0-3e57a9b713f2"), 1L, null, "سهم دیگران", null, 1L, "OthersShare", null, null },
                    { 2L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(316), false, new Guid("89f48784-a8b2-4fdd-9c67-0f811f9c0a02"), 2L, null, "سهم شرکت", null, 2L, "OursShare", null, null },
                    { 3L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(324), false, new Guid("840ab42a-373f-4ca6-86c7-e86d204c26c9"), 3L, null, "نوع واحد مرتبط", null, 3L, "AreaType", null, null },
                    { 4L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(332), false, new Guid("901aab6a-c620-4f74-b753-2bdfcfce020b"), 4L, null, "ستاد", null, 4L, "Staff", null, null },
                    { 5L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(339), false, new Guid("5a2a47d0-d771-4638-9fae-6f425377fa5b"), 5L, null, "مخدر/ یخچالی", null, 5L, "Refrigerator", null, null },
                    { 6L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(350), false, new Guid("0f2f965d-8722-4317-b98f-df12a86e3a83"), 6L, null, "مبلغ", null, 6L, "Price", null, null },
                    { 7L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(358), false, new Guid("f9f6362c-31cc-47ce-a275-374c32bd6742"), 7L, null, "متغیر فرآیندی", null, 7L, "ProcessVar", null, null },
                    { 8L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(366), false, new Guid("23de8749-2b3b-4d3e-9ece-30055b4b30e2"), 8L, null, "متغییر ورودی", null, 8L, "InputVar", null, null },
                    { 9L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(373), false, new Guid("766f536f-07be-4515-8fe9-3a38771cf79d"), 9L, null, "متغییر خروجی", null, 9L, "OutputVar", null, null },
                    { 10L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(381), false, new Guid("699f5d6a-e0c5-4378-8e02-25863b0e9e1c"), 10L, null, "اقدام های فرآیندی", null, 10L, "ProcessAction", null, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_UnitType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8076), false, new Guid("82fe32a1-7c64-4745-8427-7fb9dcda50b3"), 1L, null, "دارویی", null, 1L, "Med", null },
                    { 2L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8227), false, new Guid("715c312f-d990-44f3-a454-94a0c93362b6"), 2L, null, "مصرفی", null, 2L, "FMCG", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_BossUserId", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(451), false, new Guid("708a824d-0de1-40c2-87bc-7801d6f4f15b"), 1L, null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(461), false, new Guid("bc36613e-b83d-4a2e-a0cf-e16addf5c4dc"), 2L, null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "Id", "Area_UnitTypeId", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8717), false, new Guid("01d81f2b-3d02-4339-9495-c1a759a452b1"), 1L, null, "تهران", null, 1L, "Tehran", null },
                    { 2L, 2L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8761), false, new Guid("b191e89e-d860-4e82-a412-dea27f666e3f"), 2L, null, "فارس", null, 2L, "Fars", null },
                    { 3L, 1L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8790), false, new Guid("6d71eb02-6cad-41d2-bbc0-c0defe132688"), 3L, null, "اصفهان", null, 3L, "Esfahan", null }
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
                name: "IX_D_Area_Area_UnitTypeId",
                schema: "Dimentions",
                table: "D_Area",
                column: "Area_UnitTypeId");

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
                name: "IX_D_Position_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_DsblRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PIndex",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PName",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ExpertUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleId");

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
                name: "IX_D_Skill_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_DsblRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_Skill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PERPCode",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PIndex",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PName",
                schema: "Dimentions",
                table: "D_Skill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_DsblRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PERPCode",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PIndex",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PName",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_DsblRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PCode",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PERPCode",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PIndex",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PName",
                schema: "Dimentions",
                table: "D_UnitType",
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
                name: "IX_F_Approve_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ProcessEndorsementId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ProcessEndorsementId");

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
                name: "IX_F_EndorsementPosition_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_DsblRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PCode",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PERPCode",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PIndex",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PName",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_PositionOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_UP_ProcessEndorsementId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_ProcessEndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_CreateTimeRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_D_ProcessEndorsementId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_ProcessEndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_D_UserId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_DsblRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_RequestInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LastUpdatedRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterListId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterListId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterTypeId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PERPCode",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PIndex",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PName",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PT_OperandId");

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
                name: "IX_F_UserInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_DsblRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_UserInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PCode",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PERPCode",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PIndex",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PName",
                schema: "Facts",
                table: "F_UserInformation",
                column: "PName",
                unique: true,
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

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_CreateTimeRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_D_PositionId",
                schema: "Links",
                table: "L_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_DsblRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_FirstId",
                schema: "Links",
                table: "L_UserSkill",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserSkill",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PERPCode",
                schema: "Links",
                table: "L_UserSkill",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PIndex",
                schema: "Links",
                table: "L_UserSkill",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_PName",
                schema: "Links",
                table: "L_UserSkill",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_SecondId",
                schema: "Links",
                table: "L_UserSkill",
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
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_User_PSE_ExpertUserId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_D_User_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve");

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
                name: "F_EndorsementPosition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_ListOfParameter",
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
                name: "L_UserSkill",
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
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Position",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Skill",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ParameterType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_UnitType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_FieldType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_RequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_SubRequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_UserInformation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Approve",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_ProcessEndorsement",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_AllApprove",
                schema: "Facts");
        }
    }
}
