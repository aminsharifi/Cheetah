using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                    ERP = table.Column<bool>(type: "bit", nullable: true),
                    RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true)
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    Independent = table.Column<bool>(type: "bit", nullable: false)
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
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
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true)
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    TagTypeId = table.Column<long>(type: "bigint", nullable: true)
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true),
                    DelegateEnabled = table.Column<bool>(type: "bit", nullable: true),
                    CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true),
                    IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    UserInformationId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "F_Endorsement",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Endorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Endorsement_D_Role_RoleId",
                        column: x => x.RoleId,
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
                        name: "FK_F_Endorsement_F_Scenario_ScenarioId",
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                name: "F_Case",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Case_D_ProcessState_ProcessStateId",
                        column: x => x.ProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
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
                        name: "FK_F_Case_F_Case_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true)
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
                        name: "FK_F_Condition_F_Condition_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Scenario_ScenarioId",
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
                    Index = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_WorkItem_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_WorkItem",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "Display", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 101L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9663), null, false, "نوع تگ‌ها(Dimentions)", false, null, new Guid("b8910922-220b-4d97-bc59-d8e6939dca03"), 101L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9664), "D_TagType", null },
                    { 102L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9705), null, false, "موقعیت‌ها(Dimentions)", false, null, new Guid("8ec9b1d7-062d-4ccc-8cb1-ddbdace27d49"), 102L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9705), "D_Location", null },
                    { 103L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9713), null, false, "عملگرها(Dimentions)", false, null, new Guid("381dcf9c-fd0e-41fd-ad77-3d8cac8980b5"), 103L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9713), "D_Operand", null },
                    { 104L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9718), null, false, "تگ‌ها(Dimentions)", false, null, new Guid("3085b02f-edbd-43fc-9fd8-c83cb4837003"), 104L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9718), "D_Tag", null },
                    { 105L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9724), null, true, "سمت‌ها(Dimentions)", false, null, new Guid("902fdcb5-26ee-4a0e-91e3-9c7b64712f11"), 105L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9725), "D_Position", null },
                    { 106L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9729), null, false, "وضعیت فرآیندها(Dimentions)", false, null, new Guid("c571634d-c071-4415-aca7-79df36e7b075"), 106L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9730), "D_ProcessState", null },
                    { 107L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9735), null, true, "فرآیند‌ها(Dimentions)", false, null, new Guid("8a76ce11-3130-4b95-ae84-97e51b74e89a"), 107L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9735), "D_Process", null },
                    { 108L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9741), null, true, "نقش‌ها(Dimentions)", false, null, new Guid("6e9b30b9-5728-4dde-9c1d-a47619805447"), 108L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9741), "D_Role", null },
                    { 109L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9746), null, true, "کاربران(Dimentions)", false, null, new Guid("baf73738-181d-4acf-b9a2-0d6777d23e32"), 109L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9746), "D_User", null },
                    { 112L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9820), null, false, "اطلاعات کاربرها(Facts)", false, null, new Guid("7e884507-01e8-4f7b-9a03-9d75ee117645"), 112L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9820), "D_UserInformation", null },
                    { 200L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9829), null, false, "تمام تاییدها(Facts)", false, null, new Guid("2a96b0cd-bfcc-46a3-88c3-25a6439ae47d"), 200L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9830), "F_WorkItem", null },
                    { 202L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9835), null, false, "ضمیمه‌ها(Facts)", false, null, new Guid("1b95bfe6-b6ca-43c5-bbe5-3fb9b46708a6"), 202L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9836), "F_Attachment", null },
                    { 203L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9841), null, false, "لیست تخصیص‌ها(Facts)", false, null, new Guid("bd940954-9eb7-4f5b-96e9-893a662fa79e"), 203L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9841), "F_Endorsement", null },
                    { 204L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9847), null, false, "لیست شرط‌ها(Facts)", false, null, new Guid("51403b46-5083-4d79-881b-06c90a04e61e"), 204L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9847), "F_Condition", null },
                    { 205L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9852), null, true, "اطلاعات درخواست‌ها(Facts)", false, null, new Guid("2bb30bff-a29c-4b4b-9408-d8fe3ec97063"), 205L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9853), "F_Case", null },
                    { 206L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9858), null, true, "سناریوها(Facts)", false, null, new Guid("7569fc2b-bae0-4b7a-8336-c230e9476f82"), 206L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9858), "F_Scenario", null },
                    { 300L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9864), null, false, "نقش-سمت(Links)", false, null, new Guid("423f4dc9-09d4-4a9e-9f1f-0abe8ee4de85"), 300L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9864), "L_RolePosition", null },
                    { 301L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9869), null, false, "فرآیند-سناریو(Links)", false, null, new Guid("d24349bc-ec18-436a-8a4a-245f9e410884"), 301L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9869), "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9876), null, false, "کاربر-موقعیت(Links)", false, null, new Guid("87062b49-0b4e-48c8-af11-3d4a89a298e2"), 302L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9877), "L_UserLocation", null },
                    { 303L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9883), null, false, "کاربر-سمت(Links)", false, null, new Guid("39d8c7b8-1a17-4f43-afc8-463bc6e87983"), 303L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9883), "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9327), null, "تهران", false, null, new Guid("1bc63788-b515-48ca-9abf-22f4e6e32297"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9328), "Tehran", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9331), null, "فارس", false, null, new Guid("67aba493-5c7a-42dc-a1bc-fd423a5e85c3"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9331), "Fars", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9333), null, "اصفهان", false, null, new Guid("bfd6f1e2-46dc-4529-b271-4ccf8bb818e6"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9333), "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9353), null, "مساوی", false, null, new Guid("5d0a8494-9582-4dbe-9d62-4195f0f3645f"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9354), "=", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9356), null, "مخالف", false, null, new Guid("154e7ac3-8dc3-46bc-beb8-46e70d067392"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9357), "!=", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9359), null, "بزگتر از", false, null, new Guid("48741a86-e704-4ad3-b7c0-b59b731bb819"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9359), ">", null },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9361), null, "بزرگتر و مساوی", false, null, new Guid("970eec3b-3b8d-47f6-b4df-f4dc7c22386a"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9362), ">=", null },
                    { 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9367), null, " کوچکتر از", false, null, new Guid("308e2b47-1d4f-485b-b192-24409e8b3128"), 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9367), "<", null },
                    { 6L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9369), null, "کوچکتر و مساوی", false, null, new Guid("3541c9a6-cbdd-4774-a56b-8be7e09aa12a"), 6L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9369), "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9619), null, "معاون دارویی", false, null, new Guid("f2ffaa23-dae1-4cfa-aabe-948b22531989"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9620), "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9625), null, "معاون غذایی", false, null, new Guid("c3f36fc7-404f-42f9-8637-af1c720672ad"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9625), "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9628), null, "کارشناس ارشد بازرگانی", false, null, new Guid("a8e8c549-dce7-4872-954a-e6c41669ccf1"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9628), "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9630), null, "کارشناس بازرگانی", false, null, new Guid("4f347b32-b16c-429d-a997-e4c6f9c1ef1f"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9631), "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9633), null, "کارشناس ارشد فروش", false, null, new Guid("e3f39d0f-464b-4d46-8219-bec3a6fb0d9a"), 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9633), "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9636), null, "کارشناس فروش", false, null, new Guid("18ecadb7-4f13-4b50-9511-4aab275605da"), 6L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9636), "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9638), null, "مدیر مرکز توزیع", false, null, new Guid("08d5f135-258a-4382-a4c2-4d853b569e1d"), 7L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9639), "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERP", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id", "RemoveRequestorApproval", "ShowSupport" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9047), null, "تعریف/اصلاح مشتری", false, true, null, new Guid("ae566910-6106-48ed-95af-f45a42551a5e"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9065), "CustomerDefinition", null, true, true },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9099), null, "مجوزهای موردی", false, true, null, new Guid("e4378415-cb88-48e6-b368-6d3777d2025a"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9100), "PolicyCenter", null, true, true },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9103), null, "اعتباردهی مالی مشتری", false, true, null, new Guid("a82ca5be-cd40-4b2c-8197-cf2dcbe796bf"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9103), "CustomerCredit", null, true, true }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9279), null, "در دست بررسی", false, null, new Guid("94330afc-fbaa-4664-a006-c956fff4327e"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9280), "Ongoing", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9284), null, "منتظر بازنگری", false, null, new Guid("607bf02b-e8cd-41d0-83e7-5832058129aa"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9284), "Editing", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9286), null, "کامل شده", false, null, new Guid("bcd539fa-0f7f-4552-b16b-3924f18a29fd"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9287), "Completed", null },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9300), null, "ابطال شده", false, null, new Guid("bf95aa44-f93e-4d5f-8f4c-f9b686aff11f"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9300), "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Independent", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9554), null, "معاونت دارویی", false, null, new Guid("19486405-9a1c-4c6c-90b2-bb80b26fe9e0"), true, 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9555), "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9558), null, "معاونت غذایی", false, null, new Guid("6545650a-2158-4488-89e8-d208d7bc4002"), true, 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9558), "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9561), null, "کارشناس بازرگانی", false, null, new Guid("e1e11d71-362f-44aa-84b5-7269dcdd55b0"), true, 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9561), "BusinessSpecialist", null },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9563), null, "کارشناس فروش", false, null, new Guid("a3ca601a-6618-4453-a51f-a4d4ef48e720"), true, 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9564), "SalesSpecialist", null },
                    { 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9566), null, "مدیریت مرکز توزیع", false, null, new Guid("34b8adb1-b395-4d15-9f81-75b5d0c24597"), false, 5L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9567), "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9442), null, "عددی", false, null, new Guid("5de3e563-68da-4d89-8d83-23532ee626ef"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9442), "Numberic", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9445), null, "دودویی", false, null, new Guid("be11743f-ca08-46cf-a26f-56d65d1a580d"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9445), "Boolean", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9447), null, "تاریخ", false, null, new Guid("8aa66d48-d13e-4622-898a-b136341b7145"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9448), "Date", null },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9450), null, "حروف", false, null, new Guid("666bd99b-c91a-4c56-b84a-8374e6745516"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9451), "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "CreatedCasesSkipAssigRules", "DelegateEnabled", "DelegateId", "Description", "DisplayName", "Domain", "DsblRecord", "ERPCode", "EnabledForAssignation", "GuidRecord", "IDPersonel", "Index", "LDAPDescription", "LastUpdatedRecord", "Name", "Parent_Id", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9530), null, null, null, null, "محمد شریفی", null, false, null, null, new Guid("0dabcb92-2080-4ce0-a74b-7246cbf2c2d5"), null, 1L, null, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9531), "m.sharifi", null, null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9534), null, null, null, null, "امین شریفی", null, false, null, null, new Guid("50f2f381-d289-40f3-900b-e9d2a10fc064"), null, 2L, null, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9534), "a.sharifi", null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9919), null, "سناریو ستاد", false, null, new Guid("7353dff8-ef99-443b-91ee-d06a35aaa4da"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9920), "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9923), null, "سناریو دارویی", false, null, new Guid("ec871abb-c12d-432b-a160-7da532f55e08"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9924), "Med_Scenario", null },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9926), null, "سناریو مصرفی", false, null, new Guid("0046d7fc-864a-4e29-ad60-197f052dd4b7"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9926), "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id", "TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9474), "عددی", "سهم شرکت", false, null, new Guid("d2ce5d55-6298-4754-aff9-4282a19f0cc2"), 100L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9475), "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9478), "عددی", "سهم دیگران", false, null, new Guid("05ebc9f0-288f-4cad-ae23-bb0f9d0f1358"), 101L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9479), "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9484), "عددی", "مبلغ", false, null, new Guid("b4332a39-787e-4d21-8ed6-cb3265dd2d6f"), 103L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9484), "Price", null, 1L },
                    { 200L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9486), "دودویی", "مخدر/ یخچالی", false, null, new Guid("6ae1e9e5-c9e4-4afe-9c8e-7405e082bff0"), 200L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9487), "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9489), "پارامتریک", "تایید", false, null, new Guid("22ef2651-4cc2-4f01-a567-0b7f5bb771da"), 201L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9490), "Approve", null, 2L },
                    { 202L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9493), "پارامتریک", "عدم تایید", false, null, new Guid("68d33742-4fb3-44c4-9231-50b5955b39b4"), 202L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9493), "Reject", null, 2L },
                    { 203L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9496), "پارامتریک", "بازنگری", false, null, new Guid("9cbff978-0ced-44d2-ab0b-ac9e02d133d6"), 203L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9496), "Revise", null, 2L },
                    { 204L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9499), "پارامتریک", "دارویی", false, null, new Guid("0162465f-897b-4ad8-9796-74ef467e8230"), 204L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9499), "Med", null, 2L },
                    { 205L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9501), "پارامتریک", "مصرفی", false, null, new Guid("97fdf2b0-841b-463f-a2c7-c2785c718c02"), 205L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9502), "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9504), "پارامتریک", "کل", false, null, new Guid("c6332e3f-f097-4186-8d70-1581f41c1d8d"), 206L, new DateTime(2023, 7, 9, 12, 20, 34, 489, DateTimeKind.Local).AddTicks(9504), "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "Parent_Id", "RoleId", "ScenarioId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(48), null, "سناریو سه,مدیریت مرکز توزیع", false, null, new Guid("d170193e-d197-45ea-bb63-41b275fb7d4b"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(48), "Med_Scenario,DistributionCenterManager", null, 5L, 3L },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(52), null, "سناریو سه,معاونت غذایی", false, null, new Guid("43cb972c-6d7b-4401-a05a-1983852f6300"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(52), "Strategy3,FMCGDeputy", null, 2L, 3L },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(55), null, "سناریو دو,معاونت دارویی", false, null, new Guid("2b3aaf51-7ac7-4aa4-81be-84ae484dd0e3"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(55), "Strategy2,PharmaceuticalDeputy", null, 1L, 2L },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(59), null, "سناریو دارویی,معاونت دارویی", false, null, new Guid("9842bcd6-11e9-45c4-be81-7af4da9f3b22"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(59), "Med_Scenario,PharmaceuticalDeputy", null, 2L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "FirstId", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(157), null, "تعریف/اصلاح مشتری-سناریو سه", false, null, 1L, new Guid("aa090c70-b950-4653-804b-43d2af78cfcd"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(158), "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(160), null, "تعریف/اصلاح مشتری-سناریو یک", false, null, 1L, new Guid("b41ea0e8-e728-441a-aaa7-0c347e624e7a"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(161), "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(163), null, "مجوزهای موردی-سناریو یک", false, null, 2L, new Guid("1f6eded9-11ff-45e1-817a-10d6ce933f8c"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(163), "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(165), null, "تعریف/اصلاح مشتری-سناریو دو", false, null, 1L, new Guid("7958d2b9-9688-49f0-92cf-871607d19471"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(166), "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(168), null, "مجوزهای موردی-سناریو دو", false, null, 2L, new Guid("c9832f47-b4eb-444f-92ae-5268f71507f3"), 5L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(168), "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "FirstId", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(117), null, "معاونت دارویی-معاون دارویی", false, null, 1L, new Guid("3e1d007a-4bbd-4290-83ab-68e6f53a9432"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(117), "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(120), null, "معاونت غذایی-معاون غذایی", false, null, 2L, new Guid("d8d9872d-dd37-41eb-b613-3e6e92bec199"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(120), "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(122), null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", false, null, 3L, new Guid("cb9048e6-dcdc-45c7-918b-55b6e92dbc4d"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(123), "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(125), null, "کارشناس بازرگانی-کارشناس بازرگانی", false, null, 3L, new Guid("caf22c12-47db-4dfd-8415-6bf4031601ff"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(125), "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(128), null, "کارشناس فروش-کارشناس ارشد فروش", false, null, 4L, new Guid("f510d51e-fc2f-4e75-a61a-f11dbed98fc0"), 5L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(128), "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(130), null, "کارشناس فروش-کارشناس فروش", false, null, 4L, new Guid("79c88483-2d8e-4a17-a2c8-56f04d071c3f"), 6L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(130), "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(135), null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", false, null, 5L, new Guid("93ecfbf5-cd07-4ab6-9ba4-8354a0f80c88"), 7L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(135), "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "FirstId", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(86), null, "محمد شریفی-تهران", false, null, 1L, new Guid("a0b454ee-dfe6-4d22-822e-a848255bee23"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(86), "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(89), null, "امین شریفی-فارس", false, null, 2L, new Guid("cd91d78c-d824-4cf6-a543-01a90f3e3615"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(89), "a.sharifi-Fars", 2L },
                    { 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(94), null, "محمد شریفی-فارس", false, null, 1L, new Guid("aab51036-c72c-42b6-b7ef-581c82a0708e"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(94), "m.sharifi-Fars", 2L },
                    { 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(96), null, "امین شریفی-تهران", false, null, 2L, new Guid("4c3e29cd-64c8-4895-85a5-72ab21214bbc"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(97), "a.sharifi-Tehran", 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "FirstId", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(222), null, "محمد شریفی-مدیر مرکز", false, null, 1L, new Guid("76f921c0-108e-4338-9c88-68c1c2034f81"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(223), "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(226), null, "امین شریفی-معاون غذایی", false, null, 2L, new Guid("3536d9a0-6b94-4b0e-ab89-acf6a25ece38"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(226), "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CaseId", "CreateTimeRecord", "D_UserId", "Description", "DisplayName", "DsblRecord", "ERPCode", "EndorsementId", "GuidRecord", "Index", "LastUpdatedRecord", "Name", "OperandId", "Parent_Id", "ScenarioId", "TagId", "Value" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(4), null, null, "سناریو ستاد,سهم شرکت,بزگتر از,0", false, null, 2L, new Guid("519d23bc-e542-4293-9895-248ca7a60cce"), 1L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(5), "Head_Scenario,OursShare,>,0", 3L, null, 1L, 100L, "0" },
                    { 2L, null, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(10), null, null, "سناریو دارویی,دارویی,مساوی,1", false, null, null, new Guid("0cdd1027-9cef-45fa-9463-061287a99d05"), 2L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(10), "Med_Scenario,Med,=,1", 1L, null, 2L, 204L, "1" },
                    { 3L, null, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(13), null, null, "سناریو دارویی,سهم شرکت,بزگتر از,0", false, null, null, new Guid("3fba6df1-d7e4-47ae-952b-3801385c757a"), 3L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(13), "Med_Scenario,OursShare,>,0", 3L, null, 2L, 100L, "0" },
                    { 4L, null, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(18), null, null, "سناریو مصرفی,مصرفی,مساوی,1", false, null, null, new Guid("7110dc9e-b55e-4313-8255-f1ac255333f3"), 4L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(19), "FMCG_Scenario,FMCG,=,1", 1L, null, 3L, 205L, "1" },
                    { 5L, null, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(21), null, null, "سناریو مصرفی,مبلغ,بزگتر از,0", false, null, null, new Guid("5f3144dd-5406-4135-9262-7e2a6f7b0dda"), 5L, new DateTime(2023, 7, 9, 12, 20, 34, 490, DateTimeKind.Local).AddTicks(22), "FMCG_Scenario,Price,>,0", 3L, null, 3L, 103L, "0" }
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
                name: "IX_D_Entity_ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "ERPCode",
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
                name: "IX_D_Entity_Name",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Parent_Id",
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
                name: "IX_D_Location_ERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "ERPCode",
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
                name: "IX_D_Location_Name",
                schema: "Dimentions",
                table: "D_Location",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
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
                name: "IX_D_Operand_ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "ERPCode",
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
                name: "IX_D_Operand_Name",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
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
                name: "IX_D_Position_ERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "ERPCode",
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
                name: "IX_D_Position_Name",
                schema: "Dimentions",
                table: "D_Position",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
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
                name: "IX_D_Process_ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "ERPCode",
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
                name: "IX_D_Process_Name",
                schema: "Dimentions",
                table: "D_Process",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                column: "Parent_Id",
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
                name: "IX_D_ProcessState_ERPCode",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "ERPCode",
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
                name: "IX_D_ProcessState_Name",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
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
                name: "IX_D_Role_ERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Independent",
                schema: "Dimentions",
                table: "D_Role",
                column: "Independent",
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
                name: "IX_D_Role_Name",
                schema: "Dimentions",
                table: "D_Role",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
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
                name: "IX_D_Tag_ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "ERPCode",
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
                name: "IX_D_Tag_Name",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId");

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
                name: "IX_D_TagType_ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "ERPCode",
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
                name: "IX_D_TagType_Name",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Parent_Id",
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
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_ERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "ERPCode",
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
                name: "IX_D_User_Name",
                schema: "Dimentions",
                table: "D_User",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User",
                column: "UserInformationId");

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
                name: "IX_D_UserInformation_ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "ERPCode",
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
                name: "IX_D_UserInformation_Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Parent_Id",
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
                name: "IX_F_Attachment_ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "ERPCode",
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
                name: "IX_F_Attachment_Name",
                schema: "Facts",
                table: "F_Attachment",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreateTimeRecord",
                schema: "Facts",
                table: "F_Case",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_DsblRecord",
                schema: "Facts",
                table: "F_Case",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ERPCode",
                schema: "Facts",
                table: "F_Case",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Case",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Parent_Id",
                schema: "Facts",
                table: "F_Case",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessStateId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessStateId");

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
                name: "IX_F_Condition_EndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "ERPCode",
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
                name: "IX_F_Condition_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition",
                column: "Parent_Id");

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
                name: "IX_F_Endorsement_ERPCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Name",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_RoleId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ScenarioId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ScenarioId");

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
                name: "IX_F_Scenario_ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "ERPCode",
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
                name: "IX_F_Scenario_Name",
                schema: "Facts",
                table: "F_Scenario",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CreateTimeRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_DsblRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EndorsementId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_LastUpdatedRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Name",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Parent_Id",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TagId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

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
                name: "IX_L_ProcessScenario_ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ERPCode",
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
                name: "IX_L_ProcessScenario_Name",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

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
                name: "IX_L_RolePosition_ERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "ERPCode",
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
                name: "IX_L_RolePosition_Name",
                schema: "Links",
                table: "L_RolePosition",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

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
                name: "IX_L_UserLocation_ERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "ERPCode",
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
                name: "IX_L_UserLocation_Name",
                schema: "Links",
                table: "L_UserLocation",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

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
                name: "IX_L_UserPosition_ERPCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "ERPCode",
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
                name: "IX_L_UserPosition_Name",
                schema: "Links",
                table: "L_UserPosition",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

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
                name: "F_Condition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
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
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Endorsement",
                schema: "Facts");

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
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Role",
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
