using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
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

            migrationBuilder.EnsureSchema(
                name: "Virtuals");

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
                name: "D_Entity",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    Display = table.Column<bool>(type: "bit", nullable: true)
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ATC_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATC_Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "V_Location",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_Location", x => x.PERPCode);
                });

            migrationBuilder.CreateTable(
                name: "V_Position",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_Position", x => x.PERPCode);
                });

            migrationBuilder.CreateTable(
                name: "V_User",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    User_BossName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_User", x => x.PERPCode);
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true)
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "V_UserLocation",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_UserLocation", x => x.PERPCode);
                    table.ForeignKey(
                        name: "FK_V_UserLocation_V_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Virtuals",
                        principalTable: "V_Location",
                        principalColumn: "PERPCode");
                    table.ForeignKey(
                        name: "FK_V_UserLocation_V_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Virtuals",
                        principalTable: "V_User",
                        principalColumn: "PERPCode");
                });

            migrationBuilder.CreateTable(
                name: "V_UserPosition",
                schema: "Virtuals",
                columns: table => new
                {
                    PERPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_V_UserPosition", x => x.PERPCode);
                    table.ForeignKey(
                        name: "FK_V_UserPosition_V_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Virtuals",
                        principalTable: "V_Position",
                        principalColumn: "PERPCode");
                    table.ForeignKey(
                        name: "FK_V_UserPosition_V_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Virtuals",
                        principalTable: "V_User",
                        principalColumn: "PERPCode");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    IU_UserId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true)
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
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "F_Assignment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    PRM_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    PRM_RequestId = table.Column<long>(type: "bigint", nullable: true),
                    PRM_UserId = table.Column<long>(type: "bigint", nullable: true),
                    PRM_TagId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Assignment_D_Tag_PRM_TagId",
                        column: x => x.PRM_TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Assignment_D_User_PRM_UserId",
                        column: x => x.PRM_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
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
                name: "F_Request",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RQT_RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    RQT_ProcessId = table.Column<long>(type: "bigint", nullable: true),
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
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                        name: "FK_F_Condition_F_Request_CD_RequestId",
                        column: x => x.CD_RequestId,
                        principalSchema: "Facts",
                        principalTable: "F_Request",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Scenario_CD_ScenarioId",
                        column: x => x.CD_ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 101L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3152), false, false, new Guid("7dd47348-e44b-4f69-913c-d7b1171984d6"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3153), null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3231), false, false, new Guid("419c475b-90d6-4307-a3a1-34249daefcf7"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3232), null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3240), false, false, new Guid("0e96aeb8-a671-4b27-9d16-62bdfcb83f98"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3241), null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3246), false, false, new Guid("cd0081d6-bc31-4296-9278-a85f00ba2e3b"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3246), null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3252), true, false, new Guid("f02a4147-ba9e-4bc0-b25c-b48bc59381bb"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3253), null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3258), false, false, new Guid("f1f24e0f-89b6-4935-9e0a-f5f77ed11419"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3258), null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3264), true, false, new Guid("1722765f-de35-411b-abdf-e1d5151af7bc"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3265), null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3270), true, false, new Guid("43dc04fd-625f-4900-822b-fa7b20a669d3"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3270), null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3276), true, false, new Guid("8d286ca7-6319-4336-8561-58efcb810dfa"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3276), null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3314), false, false, new Guid("d04c0808-6aff-45e1-9d8e-fcbb8978a2f0"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3315), null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3322), false, false, new Guid("afd46c46-dac6-4b6d-ada1-017c453f86db"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3323), null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 202L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3331), false, false, new Guid("8d7801d6-b73a-4978-9b2c-46e968cdc998"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3331), null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3336), false, false, new Guid("ffb02b91-7b2d-4b30-9215-118d599cbb78"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3337), null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3343), false, false, new Guid("be089498-44b0-478b-8907-eb8b33ba26c9"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3343), null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3348), true, false, new Guid("a2257ecc-65f9-4ff4-9912-ea3ba3c2e2d5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3349), null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3363), true, false, new Guid("e8a12144-c49d-436f-9557-055a6c0fb995"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3363), null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3368), false, false, new Guid("71f5b857-6ab1-4c87-bf1b-145814c7d554"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3368), null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3373), false, false, new Guid("100ecbf3-7d39-41a4-a75b-3c95c538188f"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3374), null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3381), false, false, new Guid("5d3e6563-6bee-406c-8e4c-8a0f4dd005da"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3381), null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3387), false, false, new Guid("fd0e9272-bddc-49c5-a3d7-90af95e16fc3"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3387), null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2726), false, new Guid("05aed4b1-063a-41af-b96c-bd3528c71004"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2727), null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2733), false, new Guid("2fed3835-aa63-4d18-9c07-559a2a5cefd3"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2733), null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2735), false, new Guid("352c7078-c337-4f39-ba6d-b99b29afdffa"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2736), null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2756), false, new Guid("bb8e6278-7f7f-411c-9449-e6cc24570370"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2757), null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2760), false, new Guid("94168d3b-9151-402c-bfc2-14ea3ec216c2"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2760), null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2762), false, new Guid("de2ef45b-6b2f-4c0a-8d3e-f426068bb29d"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2762), null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2765), false, new Guid("9a68df6d-3a55-499a-ac02-546b7533a891"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2765), null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2770), false, new Guid("960966b3-0d3e-46be-bd0b-df6dfb9e6f1d"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2779), null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2800), false, new Guid("e5f9a85c-4d22-4e6b-8868-ec4a4e36e95d"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2800), null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3104), false, new Guid("57aae7d0-dbba-4a82-8421-11594a4b27f6"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3105), null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3110), false, new Guid("cebc7640-7b48-4d6e-93d7-817b6b1ec574"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3110), null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3113), false, new Guid("7fb964ac-feb5-4803-bc9b-e78f314208a5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3113), null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3115), false, new Guid("955efc96-cccb-4c6c-b2ff-d20628ffc44f"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3116), null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3118), false, new Guid("606ee680-6f40-4c92-b9d3-e04179b8faa5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3118), null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3121), false, new Guid("0d8ae5c9-fa3f-4c22-a53f-16df974668a0"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3121), null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3124), false, new Guid("6ecf0b5a-78f5-4874-b985-57924c3bf624"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3125), null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2454), false, new Guid("acd1a41c-85d0-4b9d-81ba-ffdacd7e837f"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2472), true, true, true, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2504), false, new Guid("449b960b-25f2-4da4-bbeb-f0d6162c8fe0"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2505), true, true, true, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2507), false, new Guid("36d30f49-ba19-42af-94b9-f063a215b0a0"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2508), true, true, true, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2679), false, new Guid("9f105231-4a5d-4335-bdc3-463ad3c7a653"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2680), null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2684), false, new Guid("2914984b-149b-4000-9af5-a8176bd8619e"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2684), null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2686), false, new Guid("8f2c5305-7f71-469e-9182-67efb7f5cf0a"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2687), null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2699), false, new Guid("61dcab47-e983-4c13-8a64-98168cfcd2eb"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2699), null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3031), false, new Guid("c44ef206-1df0-4adc-89af-1277a319e132"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3032), null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3036), false, new Guid("bc0f2200-ca2b-40a9-bbcd-8436c8532d47"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3036), null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3038), false, new Guid("3d0ad71a-72b5-4735-80c1-232787b9ef2c"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3039), null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3041), false, new Guid("3690eb4b-54bf-449a-9e1d-59bd5e5f7fe0"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3042), null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3044), false, new Guid("c752a3ed-4eb3-47a5-a3da-869fcdf7968b"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3044), null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2909), false, new Guid("e1cccdaa-9335-49f0-a92d-39a6a8d9b6fb"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2910), null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2913), false, new Guid("4d37a16b-4cf0-45e6-86a4-fe376e667868"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2913), null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2915), false, new Guid("199498c4-0274-4bdd-8653-eb2f82486ed1"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2916), null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2918), false, new Guid("48e19b46-873b-4a5f-9a9a-80b9cba6855a"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2918), null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3007), false, new Guid("72da26d7-40ba-4a38-9f83-e1de7ca2adcf"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3007), null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3010), false, new Guid("8b760814-63dd-4d2f-8ff8-52a87751d1e5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3011), null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3431), false, new Guid("92906f18-52b3-40ed-a095-249e3eb9ebdd"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3431), null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3437), false, new Guid("d3281b30-9ce1-4018-8665-788886f42fb7"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3438), null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3440), false, new Guid("a4210785-c9e4-48f5-b161-22eef71dd2cb"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3441), null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2940), false, new Guid("5a7903ca-6df0-4f6d-9fca-5d2fa2d6a1c6"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2940), "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2944), false, new Guid("b5b36914-17b5-49b6-ad92-c1de90b85d94"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2945), "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2950), false, new Guid("ea5490b0-f875-41ea-8838-1f2b0294d544"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2950), "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2953), false, new Guid("d1166063-d4f0-4b8f-b353-dd14bb90bed9"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2953), "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2955), false, new Guid("785ffe8e-5cdb-4d72-8283-ffa62f39f76f"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2956), "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2958), false, new Guid("4d37e295-ecb8-4716-b10d-cd9b94dea651"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2959), "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2961), false, new Guid("dbacd7c3-6916-4201-b125-6bb084071552"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2962), "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2964), false, new Guid("10ed8196-adf2-4a0f-b12f-ae7255cdd814"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2964), "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2968), false, new Guid("832dac77-9ad2-4ca6-a0fd-fd1efad1048b"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2968), "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2971), false, new Guid("088e8eea-c980-4717-9b29-b4d2f588830b"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(2971), "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3546), false, 5L, 3L, new Guid("181bcca3-25c3-429b-87ca-9a51721cc056"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3547), null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3550), false, 2L, 3L, new Guid("6ed72915-d8a6-4edb-84bb-abfbf6a63f04"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3551), null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3554), false, 1L, 2L, new Guid("6af88ca0-6421-4073-8a7c-6e035c2dbe06"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3554), null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3557), false, 2L, 1L, new Guid("195e08d5-3a0f-4846-9dd3-d095c10f8f0d"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3557), null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3690), false, 1L, new Guid("5dec6f87-694b-411c-af54-7c9ebed6f2e7"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3691), null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3693), false, 1L, new Guid("cdbd529d-0d8d-49f7-bea9-e4d46baefe84"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3694), null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3696), false, 2L, new Guid("9e947d0e-c366-4cf1-8f14-165311e3ef12"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3697), null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3699), false, 1L, new Guid("69b7d4db-af35-49f6-b382-6072a8605b24"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3700), null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3702), false, 2L, new Guid("0fdd3802-d275-4ec9-b3b7-bbdd5b62036a"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3702), null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3621), false, 1L, new Guid("910e79b2-5a9d-468f-8581-623cce6ae905"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3622), null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3625), false, 2L, new Guid("d370582c-fe7e-4a1c-a089-42217f14c8c7"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3626), null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3628), false, 3L, new Guid("dd15065d-a665-4bcf-a78e-f66ee92dbb66"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3628), null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3631), false, 3L, new Guid("d7bef644-4f20-4023-939a-e1cab0e2e039"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3631), null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3633), false, 4L, new Guid("e2dd4fd5-8904-4480-8376-a1fa3c777243"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3634), null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3636), false, 4L, new Guid("1968a567-ea47-479d-a7ce-673a78437dc2"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3636), null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3641), false, 5L, new Guid("b180d499-fe65-4655-a9ba-f6d119844926"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3641), null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3589), false, 1L, new Guid("ee8bddaa-2dde-48e6-9d82-76c999802f12"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3589), null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3592), false, 2L, new Guid("b6332ab0-0269-41b5-81d6-d50220e04c76"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3593), null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L },
                    { 3L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3597), false, 1L, new Guid("fce53046-9ebf-4f17-a8dc-237d36e4fa91"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3598), null, "محمد شریفی-فارس", null, 3L, "m.sharifi-Fars", 2L },
                    { 4L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3600), false, 2L, new Guid("7092483f-2783-41b9-a4bf-35a8b152df6e"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3600), null, "امین شریفی-تهران", null, 4L, "a.sharifi-Tehran", 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3758), false, 1L, new Guid("ac860689-4006-45dd-ad30-a45ebf419845"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3759), null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3762), false, 2L, new Guid("8ae90c4f-c941-4e6a-9b88-3f55b9084c58"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3762), null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3500), null, false, new Guid("e9a4d2bb-5996-40f9-b60a-0bc0adb26f31"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3501), null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3507), null, false, new Guid("331d5cab-a35d-4c1b-af82-b50b0f25ca83"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3508), null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3512), null, false, new Guid("4ea38ccd-7e17-4faf-9fee-17d6b4f5cec1"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3512), null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3517), null, false, new Guid("3026d4bb-7397-4112-8094-d554dab9a6b5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3517), null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3520), null, false, new Guid("16797041-de59-4371-8f83-62276600dfe5"), new DateTime(2023, 7, 8, 16, 43, 24, 480, DateTimeKind.Local).AddTicks(3521), null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
                name: "IX_D_Entity_PERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Location_PERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Operand_PERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Position_PERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Process_PERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_ProcessState_PERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Role_PERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_Tag_PERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_TagType_PERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_D_User_PERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_PName",
                schema: "Dimentions",
                table: "D_User",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

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
                name: "IX_D_UserInformation_PERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_Assignment_PERPCode",
                schema: "Facts",
                table: "F_Assignment",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_Assignment_PRM_TagId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PRM_UserId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_UserId");

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
                name: "IX_F_Attachment_PERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_Endorsement_PERPCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_F_Scenario_PERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_L_ProcessScenario_PERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_L_RolePosition_PERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_L_UserLocation_PERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "PERPCode",
                descending: new bool[0]);

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
                name: "IX_L_UserPosition_PERPCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "PERPCode",
                descending: new bool[0]);

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

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_DsblRecord",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_FirstId",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserLocation_SecondId",
                schema: "Virtuals",
                table: "V_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_DsblRecord",
                schema: "Virtuals",
                table: "V_UserPosition",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_FirstId",
                schema: "Virtuals",
                table: "V_UserPosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_V_UserPosition_SecondId",
                schema: "Virtuals",
                table: "V_UserPosition",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_D_User_PRM_UserId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Request_D_User_RQT_CreatorId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Request_D_User_RQT_RequestorId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_D_Tag_PRM_TagId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Endorsement_PRM_EndorsementId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Request_PRM_RequestId",
                schema: "Facts",
                table: "F_Assignment");

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
                name: "V_UserLocation",
                schema: "Virtuals");

            migrationBuilder.DropTable(
                name: "V_UserPosition",
                schema: "Virtuals");

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
                name: "V_Location",
                schema: "Virtuals");

            migrationBuilder.DropTable(
                name: "V_Position",
                schema: "Virtuals");

            migrationBuilder.DropTable(
                name: "V_User",
                schema: "Virtuals");

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
                name: "D_Tag",
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
                name: "F_Assignment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");
        }
    }
}
