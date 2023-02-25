using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dimentions");

            migrationBuilder.EnsureSchema(
                name: "Facts");

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
                name: "D_FieldType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    AreaUnitTypeId = table.Column<long>(name: "Area_UnitTypeId", type: "bigint", nullable: true)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UserFullName = table.Column<string>(name: "User_FullName", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUserName = table.Column<string>(name: "User_UserName", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserDomain = table.Column<string>(name: "User_Domain", type: "nvarchar(25)", maxLength: 25, nullable: false),
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
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Facts",
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                name: "F_RolePosition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UPRoleId = table.Column<long>(name: "UP_RoleId", type: "bigint", nullable: true),
                    UPPositionOrgId = table.Column<long>(name: "UP_PositionOrgId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Position_UP_PositionOrgId",
                        column: x => x.UPPositionOrgId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Role_UP_RoleId",
                        column: x => x.UPRoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RolePosition_F_RolePosition_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_RolePosition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_ProcessEndorsement",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserArea",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    UAAreaId = table.Column<long>(name: "UA_AreaId", type: "bigint", nullable: true),
                    UAUserId = table.Column<long>(name: "UA_UserId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserArea_D_Area_UA_AreaId",
                        column: x => x.UAAreaId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserArea_D_User_UA_UserId",
                        column: x => x.UAUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserArea_F_UserArea_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserArea",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserLocation",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    ULUserLocationId = table.Column<long>(name: "UL_UserLocationId", type: "bigint", nullable: true),
                    ULRelatedUserLocationId = table.Column<long>(name: "UL_RelatedUserLocationId", type: "bigint", nullable: true),
                    ULLocationId = table.Column<long>(name: "UL_LocationId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_Location_UL_LocationId",
                        column: x => x.ULLocationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_User_UL_RelatedUserLocationId",
                        column: x => x.ULRelatedUserLocationId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_User_UL_UserLocationId",
                        column: x => x.ULUserLocationId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_F_UserLocation_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserLocation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserRole",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    URRoleId = table.Column<long>(name: "UR_RoleId", type: "bigint", nullable: true),
                    URUserId = table.Column<long>(name: "UR_UserId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserRole_D_Role_UR_RoleId",
                        column: x => x.URRoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserRole_D_User_UR_UserId",
                        column: x => x.URUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserRole_F_UserRole_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_UserSkill",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ParentId = table.Column<long>(name: "Parent_Id", type: "bigint", nullable: true),
                    USSkillId = table.Column<long>(name: "US_SkillId", type: "bigint", nullable: true),
                    USUserId = table.Column<long>(name: "US_UserId", type: "bigint", nullable: true),
                    DPositionId = table.Column<long>(name: "D_PositionId", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Position_D_PositionId",
                        column: x => x.DPositionId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Skill_US_SkillId",
                        column: x => x.USSkillId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_User_US_UserId",
                        column: x => x.USUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_F_UserSkill_Parent_Id",
                        column: x => x.ParentId,
                        principalSchema: "Facts",
                        principalTable: "F_UserSkill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_EndorsementPosition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                        principalSchema: "Facts",
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_ExpertUserId",
                        column: x => x.RIExpertUserId,
                        principalSchema: "Facts",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                        column: x => x.RIRequestorId,
                        principalSchema: "Facts",
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                        principalSchema: "Facts",
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
                name: "IX_D_Area_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Area",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_FieldType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterList",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeId",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ParameterType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeId",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PSO_Default_LocationId",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

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
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_RequestTitle",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_Skill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_Skill",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleId",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_UnitType_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Dimentions",
                table: "D_UnitType",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Facts",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "D_User",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_BossUserId",
                schema: "Facts",
                table: "D_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_DelegateId",
                schema: "Facts",
                table: "D_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_User_UserInformationId",
                schema: "Facts",
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
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

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
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementPosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_EndorsementPosition",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

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
                name: "IX_F_ListOfParameter_F_RequestInformationId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_RequestInformationId");

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
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_ListOfParameter",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PT_OperandId",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PT_OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

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
                name: "IX_F_RolePosition_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_RolePosition",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_PositionOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_UP_RoleId",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserArea",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_UA_AreaId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_UA_UserId",
                schema: "Facts",
                table: "F_UserArea",
                column: "UA_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserInformation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserInformation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserLocation",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_LocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_RelatedUserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_RelatedUserLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_UserLocationId",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_UserLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserRole",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_UR_RoleId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_UR_UserId",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_D_PositionId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_PCode_PIndex_PName_CreateTimeRecord_LastUpdatedRecord_DsblRecord_PERPCode_Parent_Id",
                schema: "Facts",
                table: "F_UserSkill",
                columns: new[] { "PCode", "PIndex", "PName", "CreateTimeRecord", "LastUpdatedRecord", "DsblRecord", "PERPCode", "Parent_Id" },
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL AND [CreateTimeRecord] IS NOT NULL AND [LastUpdatedRecord] IS NOT NULL AND [DsblRecord] IS NOT NULL AND [PERPCode] IS NOT NULL AND [Parent_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_US_SkillId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_US_UserId",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_UserId");

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
                name: "F_Attachment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_EndorsementPosition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_ListOfParameter",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_RolePosition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserArea",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserLocation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserRole",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserSkill",
                schema: "Facts");

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
                schema: "Facts");

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
