using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DimFact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_AllApprove_M_Approve_Current_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_M_AllApprove_M_Approve_Last_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove");

            migrationBuilder.DropTable(
                name: "M_Attachment",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "M_ListOfParameter",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "P_EndorsementPosition",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_RolePosition",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_UserArea",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_UserLocation",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_UserRole",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_UserSkill",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "M_RequestInformation",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "P_Operand",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_ParameterList",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_Area",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_Role",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "P_PositionOrg",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_Skill",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "P_RequestType",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_ParameterType",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_UnitType",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_Location",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "P_FieldType",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "M_Approve",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "M_AllApprove",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "P_ProcessEndorsement",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_ProcessState",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_SubRequestTitle",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_User",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "P_RequestTitle",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_UserInformation",
                schema: "Systems");

            migrationBuilder.EnsureSchema(
                name: "Dimentions");

            migrationBuilder.EnsureSchema(
                name: "Facts");

            migrationBuilder.CreateTable(
                name: "D_FieldType",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_FieldType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_Location",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_ProcessState",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessState", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_RequestTitle",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RTShowSupport = table.Column<bool>(name: "RT_ShowSupport", type: "bit", nullable: true),
                    RTCheckList = table.Column<bool>(name: "RT_CheckList", type: "bit", nullable: true),
                    RTERP = table.Column<bool>(name: "RT_ERP", type: "bit", nullable: true),
                    RTAnotherRequester = table.Column<bool>(name: "RT_AnotherRequester", type: "bit", nullable: true),
                    RTRemoveRequestorApproval = table.Column<bool>(name: "RT_RemoveRequestorApproval", type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestTitle", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_Role",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Role", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_Skill",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Skill", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_UnitType",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UnitType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "F_UserInformation",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_F_UserInformation", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "D_ParameterType",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PTPFieldTypeIdRecord = table.Column<long>(name: "PT_P_FieldTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterType", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_ParameterType_D_FieldType_PT_P_FieldTypeIdRecord",
                        column: x => x.PTPFieldTypeIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_FieldType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_RequestType",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RTRequestTitlesIdRecord = table.Column<long>(name: "RT_RequestTitlesIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RequestType", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_RequestType_D_RequestTitle_RT_RequestTitlesIdRecord",
                        column: x => x.RTRequestTitlesIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_SubRequestTitle",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DRequestTitleIdRecord = table.Column<long>(name: "D_RequestTitleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_SubRequestTitle", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleIdRecord",
                        column: x => x.DRequestTitleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_Area",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AreaUnitTypeIdRecord = table.Column<long>(name: "Area_UnitTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Area", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_Area_D_UnitType_Area_UnitTypeIdRecord",
                        column: x => x.AreaUnitTypeIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_UnitType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_User",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    UserUserInformationIdRecord = table.Column<long>(name: "User_UserInformationIdRecord", type: "bigint", nullable: true),
                    UserIdentityUserId = table.Column<string>(name: "User_IdentityUserId", type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_User", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_User_AspNetUsers_User_IdentityUserId",
                        column: x => x.UserIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_User_F_UserInformation_User_UserInformationIdRecord",
                        column: x => x.UserUserInformationIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_UserInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_User_F_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_User_F_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_ParameterList",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PLParameterTypeIdRecord = table.Column<long>(name: "PL_ParameterTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ParameterList", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_ParameterList_D_ParameterType_PL_ParameterTypeIdRecord",
                        column: x => x.PLParameterTypeIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_ProcessEndorsement",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PSEMail = table.Column<bool>(name: "PSE_Mail", type: "bit", nullable: true),
                    PSEAutomation = table.Column<bool>(name: "PSE_Automation", type: "bit", nullable: true),
                    PSESMS = table.Column<bool>(name: "PSE_SMS", type: "bit", nullable: true),
                    PSETranscript = table.Column<bool>(name: "PSE_Transcript", type: "bit", nullable: true),
                    PSENeedApprove = table.Column<bool>(name: "PSE_NeedApprove", type: "bit", nullable: true),
                    PSESendAll = table.Column<bool>(name: "PSE_SendAll", type: "bit", nullable: true),
                    PSESubRequestTitleIdRecord = table.Column<long>(name: "PSE_SubRequestTitleIdRecord", type: "bigint", nullable: true),
                    PSEExpertUserIdRecord = table.Column<long>(name: "PSE_ExpertUserIdRecord", type: "bigint", nullable: true),
                    PSERequestTitleIdRecord = table.Column<long>(name: "PSE_RequestTitleIdRecord", type: "bigint", nullable: true),
                    PSEProcessStateIdRecord = table.Column<long>(name: "PSE_ProcessStateIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_ProcessEndorsement", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateIdRecord",
                        column: x => x.PSEProcessStateIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleIdRecord",
                        column: x => x.PSERequestTitleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                        column: x => x.PSESubRequestTitleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_SubRequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_ProcessEndorsement_F_User_PSE_ExpertUserIdRecord",
                        column: x => x.PSEExpertUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_UserArea",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    URAreaIdRecord = table.Column<long>(name: "UR_AreaIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserArea", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_UserArea_D_Area_UR_AreaIdRecord",
                        column: x => x.URAreaIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserArea_F_User_UR_UserIdRecord",
                        column: x => x.URUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_UserLocation",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ULUserLocationIdRecord = table.Column<long>(name: "UL_UserLocationIdRecord", type: "bigint", nullable: true),
                    ULRelatedUserLocationIdRecord = table.Column<long>(name: "UL_RelatedUserLocationIdRecord", type: "bigint", nullable: true),
                    ULLocationIdRecord = table.Column<long>(name: "UL_LocationIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserLocation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_UserLocation_D_Location_UL_LocationIdRecord",
                        column: x => x.ULLocationIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_F_User_UL_RelatedUserLocationIdRecord",
                        column: x => x.ULRelatedUserLocationIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserLocation_F_User_UL_UserLocationIdRecord",
                        column: x => x.ULUserLocationIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_UserRole",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    URRoleIdRecord = table.Column<long>(name: "UR_RoleIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserRole", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_UserRole_D_Role_UR_RoleIdRecord",
                        column: x => x.URRoleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserRole_F_User_UR_UserIdRecord",
                        column: x => x.URUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_Position",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PSOIndependentLocation = table.Column<bool>(name: "PSO_Independent_Location", type: "bit", nullable: true),
                    PSODefaultLocationIdRecord = table.Column<long>(name: "PSO_Default_LocationIdRecord", type: "bigint", nullable: true),
                    DProcessEndorsementIdRecord = table.Column<long>(name: "D_ProcessEndorsementIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Position", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_Position_D_Location_PSO_Default_LocationIdRecord",
                        column: x => x.PSODefaultLocationIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_Position_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                        column: x => x.DProcessEndorsementIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "D_EndorsementPosition",
                schema: "Dimentions",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UPProcessEndorsementIdRecord = table.Column<long>(name: "UP_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_EndorsementPosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_D_EndorsementPosition_D_Position_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_D_EndorsementPosition_D_ProcessEndorsement_UP_ProcessEndorsementIdRecord",
                        column: x => x.UPProcessEndorsementIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_RolePosition",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UPRoleIdRecord = table.Column<long>(name: "UP_RoleIdRecord", type: "bigint", nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RolePosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Position_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RolePosition_D_Role_UP_RoleIdRecord",
                        column: x => x.UPRoleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_UserSkill",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    USSkillIdRecord = table.Column<long>(name: "US_SkillIdRecord", type: "bigint", nullable: true),
                    USUserIdRecord = table.Column<long>(name: "US_UserIdRecord", type: "bigint", nullable: true),
                    DPositionIdRecord = table.Column<long>(name: "D_PositionIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserSkill", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Position_D_PositionIdRecord",
                        column: x => x.DPositionIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_D_Skill_US_SkillIdRecord",
                        column: x => x.USSkillIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Skill",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_UserSkill_F_User_US_UserIdRecord",
                        column: x => x.USUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_AllApprove",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    AAPCurrentApproveIdRecord = table.Column<long>(name: "AAP_Current_ApproveIdRecord", type: "bigint", nullable: true),
                    AAPLastApproveIdRecord = table.Column<long>(name: "AAP_Last_ApproveIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_AllApprove", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "F_Approve",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    APVSubject = table.Column<string>(name: "APV_Subject", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APVUserInChargeIdRecord = table.Column<long>(name: "APV_UserInChargeIdRecord", type: "bigint", nullable: true),
                    APVProcessEndorsementIdRecord = table.Column<long>(name: "APV_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    APVNeedApproveIdRecord = table.Column<long>(name: "APV_NeedApproveIdRecord", type: "bigint", nullable: true),
                    APVApproveIdRecord = table.Column<long>(name: "APV_ApproveIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Approve", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementIdRecord",
                        column: x => x.APVProcessEndorsementIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_ApproveIdRecord",
                        column: x => x.APVApproveIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_NeedApproveIdRecord",
                        column: x => x.APVNeedApproveIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_User_APV_UserInChargeIdRecord",
                        column: x => x.APVUserInChargeIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_RequestInformation",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    RIERPID = table.Column<long>(name: "RI_ERPID", type: "bigint", nullable: true),
                    RIIsCancelled = table.Column<bool>(name: "RI_IsCancelled", type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RIPELevel = table.Column<byte>(name: "RI_PE_Level", type: "tinyint", nullable: true),
                    RIRequestDate = table.Column<DateTime>(name: "RI_RequestDate", type: "datetime2", nullable: true),
                    RIRequestFinishDate = table.Column<DateTime>(name: "RI_RequestFinishDate", type: "datetime2", nullable: true),
                    RIOldDate = table.Column<DateTime>(name: "RI_OldDate", type: "datetime2", nullable: true),
                    RINewDate = table.Column<DateTime>(name: "RI_NewDate", type: "datetime2", nullable: true),
                    RILastTimeModify = table.Column<DateTime>(name: "RI_LastTimeModify", type: "datetime2", nullable: true),
                    RIExpertUserIdRecord = table.Column<long>(name: "RI_ExpertUserIdRecord", type: "bigint", nullable: true),
                    RIRequestorIdRecord = table.Column<long>(name: "RI_RequestorIdRecord", type: "bigint", nullable: true),
                    RICreatorIdRecord = table.Column<long>(name: "RI_CreatorIdRecord", type: "bigint", nullable: true),
                    RIAllApproveIdRecord = table.Column<long>(name: "RI_AllApproveIdRecord", type: "bigint", nullable: true),
                    RIProcessStateIdRecord = table.Column<long>(name: "RI_ProcessStateIdRecord", type: "bigint", nullable: true),
                    RIRequestTypeIdRecord = table.Column<long>(name: "RI_RequestTypeIdRecord", type: "bigint", nullable: true),
                    RIRequestTitleIdRecord = table.Column<long>(name: "RI_RequestTitleIdRecord", type: "bigint", nullable: true),
                    RISubRequestTitleIdRecord = table.Column<long>(name: "RI_SubRequestTitleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RequestInformation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateIdRecord",
                        column: x => x.RIProcessStateIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_RequestTitle_RI_RequestTitleIdRecord",
                        column: x => x.RIRequestTitleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_RequestType_RI_RequestTypeIdRecord",
                        column: x => x.RIRequestTypeIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_RequestType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_SubRequestTitle_RI_SubRequestTitleIdRecord",
                        column: x => x.RISubRequestTitleIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_SubRequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveIdRecord",
                        column: x => x.RIAllApproveIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_User_RI_CreatorIdRecord",
                        column: x => x.RICreatorIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_User_RI_ExpertUserIdRecord",
                        column: x => x.RIExpertUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_User_RI_RequestorIdRecord",
                        column: x => x.RIRequestorIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ATCName = table.Column<string>(name: "ATC_Name", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATCData = table.Column<byte[]>(name: "ATC_Data", type: "varbinary(max)", nullable: true),
                    FApproveIdRecord = table.Column<long>(name: "F_ApproveIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_Attachment_F_Approve_F_ApproveIdRecord",
                        column: x => x.FApproveIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_Approve",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "F_ListOfParameter",
                schema: "Facts",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    LOPFloatValue = table.Column<float>(name: "LOP_FloatValue", type: "real", nullable: true),
                    LOPBooleanValue = table.Column<bool>(name: "LOP_BooleanValue", type: "bit", nullable: true),
                    LOPStringValue = table.Column<string>(name: "LOP_StringValue", type: "nvarchar(max)", nullable: true),
                    LOPParameterListIdRecord = table.Column<long>(name: "LOP_ParameterListIdRecord", type: "bigint", nullable: true),
                    LOPParameterTypeIdRecord = table.Column<long>(name: "LOP_ParameterTypeIdRecord", type: "bigint", nullable: true),
                    PTOperandIdRecord = table.Column<long>(name: "PT_OperandIdRecord", type: "bigint", nullable: true),
                    DProcessEndorsementIdRecord = table.Column<long>(name: "D_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    FRequestInformationIdRecord = table.Column<long>(name: "F_RequestInformationIdRecord", type: "bigint", nullable: true),
                    FUserIdRecord = table.Column<long>(name: "F_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_ListOfParameter", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_Operand_PT_OperandIdRecord",
                        column: x => x.PTOperandIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ParameterList_LOP_ParameterListIdRecord",
                        column: x => x.LOPParameterListIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterList",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ParameterType_LOP_ParameterTypeIdRecord",
                        column: x => x.LOPParameterTypeIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ParameterType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_D_ProcessEndorsement_D_ProcessEndorsementIdRecord",
                        column: x => x.DProcessEndorsementIdRecord,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_F_RequestInformation_F_RequestInformationIdRecord",
                        column: x => x.FRequestInformationIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_F_ListOfParameter_F_User_F_UserIdRecord",
                        column: x => x.FUserIdRecord,
                        principalSchema: "Facts",
                        principalTable: "F_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_Area_Area_UnitTypeIdRecord",
                schema: "Dimentions",
                table: "D_Area",
                column: "Area_UnitTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPosition_UP_PositionOrgIdRecord",
                schema: "Dimentions",
                table: "D_EndorsementPosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPosition_UP_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_EndorsementPosition",
                column: "UP_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterList_PL_ParameterTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterList",
                column: "PL_ParameterTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Dimentions",
                table: "D_ParameterType",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_D_ProcessEndorsementIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "D_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PSO_Default_LocationIdRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Default_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ExpertUserIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ExpertUserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_SubRequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_SubRequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_RequestType_RT_RequestTitlesIdRecord",
                schema: "Dimentions",
                table: "D_RequestType",
                column: "RT_RequestTitlesIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_D_SubRequestTitle_D_RequestTitleIdRecord",
                schema: "Dimentions",
                table: "D_SubRequestTitle",
                column: "D_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_NeedApproveIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_UserInChargeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_F_ApproveIdRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_D_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "D_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_F_RequestInformationIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_F_UserIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "F_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterListIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterListIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_LOP_ParameterTypeIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "LOP_ParameterTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_ListOfParameter_PT_OperandIdRecord",
                schema: "Facts",
                table: "F_ListOfParameter",
                column: "PT_OperandIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_AllApproveIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_CreatorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_CreatorIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_ExpertUserIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ExpertUserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_ProcessStateIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ProcessStateIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestorIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestorIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestTypeIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_SubRequestTitleIdRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_SubRequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_UP_PositionOrgIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_RolePosition_UP_RoleIdRecord",
                schema: "Facts",
                table: "F_RolePosition",
                column: "UP_RoleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_BossUserId",
                schema: "Facts",
                table: "F_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_DelegateId",
                schema: "Facts",
                table: "F_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_IdentityUserId",
                schema: "Facts",
                table: "F_User",
                column: "User_IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_User_User_UserInformationIdRecord",
                schema: "Facts",
                table: "F_User",
                column: "User_UserInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_UR_AreaIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "UR_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserArea_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserArea",
                column: "UR_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_LocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_RelatedUserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_RelatedUserLocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserLocation_UL_UserLocationIdRecord",
                schema: "Facts",
                table: "F_UserLocation",
                column: "UL_UserLocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_UR_RoleIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_RoleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserRole_UR_UserIdRecord",
                schema: "Facts",
                table: "F_UserRole",
                column: "UR_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_D_PositionIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "D_PositionIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_US_SkillIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_SkillIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserSkill_US_UserIdRecord",
                schema: "Facts",
                table: "F_UserSkill",
                column: "US_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveIdRecord",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Approve_F_User_APV_UserInChargeIdRecord",
                schema: "Facts",
                table: "F_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveIdRecord",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropTable(
                name: "D_EndorsementPosition",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Attachment",
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
                name: "D_RequestType",
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
                name: "D_ProcessEndorsement",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_ProcessState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_SubRequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_RequestTitle",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_User",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_UserInformation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Approve",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_AllApprove",
                schema: "Facts");

            migrationBuilder.EnsureSchema(
                name: "Masters");

            migrationBuilder.EnsureSchema(
                name: "Parameters");

            migrationBuilder.EnsureSchema(
                name: "Systems");

            migrationBuilder.CreateTable(
                name: "P_FieldType",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_FieldType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_Operand",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Operand", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_ProcessState",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ProcessState", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_RequestTitle",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RTShowSupport = table.Column<bool>(name: "RT_ShowSupport", type: "bit", nullable: true),
                    RTCheckList = table.Column<bool>(name: "RT_CheckList", type: "bit", nullable: true),
                    RTERP = table.Column<bool>(name: "RT_ERP", type: "bit", nullable: true),
                    RTAnotherRequester = table.Column<bool>(name: "RT_AnotherRequester", type: "bit", nullable: true),
                    RTRemoveRequestorApproval = table.Column<bool>(name: "RT_RemoveRequestorApproval", type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_RequestTitle", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_Location",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Location", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_Role",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Role", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_Skill",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Skill", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_UnitType",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UnitType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_UserInformation",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    table.PrimaryKey("PK_S_UserInformation", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_ParameterType",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PTPFieldTypeIdRecord = table.Column<long>(name: "PT_P_FieldTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ParameterType", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                        column: x => x.PTPFieldTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_FieldType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_RequestType",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SBTRequestTitlesIdRecord = table.Column<long>(name: "SBT_RequestTitlesIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_RequestType", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_RequestType_P_RequestTitle_SBT_RequestTitlesIdRecord",
                        column: x => x.SBTRequestTitlesIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_SubRequestTitle",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PRequestTitleIdRecord = table.Column<long>(name: "P_RequestTitleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_SubRequestTitle", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_SubRequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                        column: x => x.PRequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_Area",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AreaSUnitTypeIdRecord = table.Column<long>(name: "Area_S_UnitTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Area", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_Area_S_UnitType_Area_S_UnitTypeIdRecord",
                        column: x => x.AreaSUnitTypeIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_UnitType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_User",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
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
                    identityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserSUserInformationIdRecord = table.Column<long>(name: "User_S_UserInformationIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_User", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_User_AspNetUsers_identityUserId",
                        column: x => x.identityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_User_S_UserInformation_User_S_UserInformationIdRecord",
                        column: x => x.UserSUserInformationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_UserInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_BossUserId",
                        column: x => x.UserBossUserId,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_DelegateId",
                        column: x => x.UserDelegateId,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_ParameterList",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PLPParameterTypeIdRecord = table.Column<long>(name: "PL_P_ParameterTypeIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ParameterList", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_ParameterList_P_ParameterType_PL_P_ParameterTypeIdRecord",
                        column: x => x.PLPParameterTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterType",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_ProcessEndorsement",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PSEMail = table.Column<bool>(name: "PSE_Mail", type: "bit", nullable: true),
                    PSEAutomation = table.Column<bool>(name: "PSE_Automation", type: "bit", nullable: true),
                    PSESMS = table.Column<bool>(name: "PSE_SMS", type: "bit", nullable: true),
                    PSETranscript = table.Column<bool>(name: "PSE_Transcript", type: "bit", nullable: true),
                    PSENeedApprove = table.Column<bool>(name: "PSE_NeedApprove", type: "bit", nullable: true),
                    PSESendAll = table.Column<bool>(name: "PSE_SendAll", type: "bit", nullable: true),
                    PSEExpertUserIdRecord = table.Column<long>(name: "PSE_ExpertUserIdRecord", type: "bigint", nullable: true),
                    PSEProcessStateIdRecord = table.Column<long>(name: "PSE_ProcessStateIdRecord", type: "bigint", nullable: true),
                    PSERequestTitleIdRecord = table.Column<long>(name: "PSE_RequestTitleIdRecord", type: "bigint", nullable: true),
                    PSESubRequestTitleIdRecord = table.Column<long>(name: "PSE_SubRequestTitleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ProcessEndorsement", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_ProcessStateIdRecord",
                        column: x => x.PSEProcessStateIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_RequestTitleIdRecord",
                        column: x => x.PSERequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                        column: x => x.PSESubRequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_SubRequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_S_User_PSE_ExpertUserIdRecord",
                        column: x => x.PSEExpertUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_UserArea",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    URAreaIdRecord = table.Column<long>(name: "UR_AreaIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserArea", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserArea_S_Area_UR_AreaIdRecord",
                        column: x => x.URAreaIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserArea_S_User_UR_UserIdRecord",
                        column: x => x.URUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_UserLocation",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    SLocationIdRecord = table.Column<long>(name: "S_LocationIdRecord", type: "bigint", nullable: true),
                    ULRelatedUserLocationIdRecord = table.Column<long>(name: "UL_RelatedUserLocationIdRecord", type: "bigint", nullable: true),
                    ULUserLocationIdRecord = table.Column<long>(name: "UL_UserLocationIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserLocation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_Location_S_LocationIdRecord",
                        column: x => x.SLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_User_UL_RelatedUserLocationIdRecord",
                        column: x => x.ULRelatedUserLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_User_UL_UserLocationIdRecord",
                        column: x => x.ULUserLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_UserRole",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    URRoleIdRecord = table.Column<long>(name: "UR_RoleIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserRole", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserRole_S_Role_UR_RoleIdRecord",
                        column: x => x.URRoleIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Role",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserRole_S_User_UR_UserIdRecord",
                        column: x => x.URUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_PositionOrg",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PSOIndependentLocation = table.Column<bool>(name: "PSO_Independent_Location", type: "bit", nullable: true),
                    PSODefaultLocationIdRecord = table.Column<long>(name: "PSO_Default_LocationIdRecord", type: "bigint", nullable: true),
                    PProcessEndorsementIdRecord = table.Column<long>(name: "P_ProcessEndorsementIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_PositionOrg", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_PositionOrg_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                        column: x => x.PProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_PositionOrg_S_Location_PSO_Default_LocationIdRecord",
                        column: x => x.PSODefaultLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_EndorsementPosition",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true),
                    UPProcessEndorsementIdRecord = table.Column<long>(name: "UP_ProcessEndorsementIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_EndorsementPosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_EndorsementPosition_P_PositionOrg_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_PositionOrg",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_EndorsementPosition_P_ProcessEndorsement_UP_ProcessEndorsementIdRecord",
                        column: x => x.UPProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_RolePosition",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true),
                    UPRoleIdRecord = table.Column<long>(name: "UP_RoleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_RolePosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_RolePosition_P_PositionOrg_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_PositionOrg",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_RolePosition_S_Role_UP_RoleIdRecord",
                        column: x => x.UPRoleIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Role",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_UserSkill",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    USSkillIdRecord = table.Column<long>(name: "US_SkillIdRecord", type: "bigint", nullable: true),
                    USUserIdRecord = table.Column<long>(name: "US_UserIdRecord", type: "bigint", nullable: true),
                    PPositionOrgIdRecord = table.Column<long>(name: "P_PositionOrgIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserSkill", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserSkill_P_PositionOrg_P_PositionOrgIdRecord",
                        column: x => x.PPositionOrgIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_PositionOrg",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserSkill_S_Skill_US_SkillIdRecord",
                        column: x => x.USSkillIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Skill",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserSkill_S_User_US_UserIdRecord",
                        column: x => x.USUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_AllApprove",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    CurrentMApproveIdRecord = table.Column<long>(name: "Current_M_ApproveIdRecord", type: "bigint", nullable: true),
                    LastMApproveIdRecord = table.Column<long>(name: "Last_M_ApproveIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AllApprove", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "M_Approve",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    APVSubject = table.Column<string>(name: "APV_Subject", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APVPProcessEndorsementIdRecord = table.Column<long>(name: "APV_P_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    APVUserInChargeIdRecord = table.Column<long>(name: "APV_UserInChargeIdRecord", type: "bigint", nullable: true),
                    MAllApproveIdRecord = table.Column<long>(name: "M_AllApproveIdRecord", type: "bigint", nullable: true),
                    MAllApproveIdRecord1 = table.Column<long>(name: "M_AllApproveIdRecord1", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Approve", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord",
                        column: x => x.MAllApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord1",
                        column: x => x.MAllApproveIdRecord1,
                        principalSchema: "Masters",
                        principalTable: "M_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_Approve_P_ProcessEndorsement_APV_P_ProcessEndorsementIdRecord",
                        column: x => x.APVPProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_Approve_S_User_APV_UserInChargeIdRecord",
                        column: x => x.APVUserInChargeIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_RequestInformation",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    RIERPID = table.Column<long>(name: "RI_ERPID", type: "bigint", nullable: true),
                    RIIsCancelled = table.Column<bool>(name: "RI_IsCancelled", type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RIPELevel = table.Column<byte>(name: "RI_PE_Level", type: "tinyint", nullable: true),
                    RIRequestDate = table.Column<DateTime>(name: "RI_RequestDate", type: "datetime2", nullable: true),
                    RIRequestFinishDate = table.Column<DateTime>(name: "RI_RequestFinishDate", type: "datetime2", nullable: true),
                    RIOldDate = table.Column<DateTime>(name: "RI_OldDate", type: "datetime2", nullable: true),
                    RINewDate = table.Column<DateTime>(name: "RI_NewDate", type: "datetime2", nullable: true),
                    RILastTimeModify = table.Column<DateTime>(name: "RI_LastTimeModify", type: "datetime2", nullable: true),
                    RIAllApproveIdRecord = table.Column<long>(name: "RI_AllApproveIdRecord", type: "bigint", nullable: true),
                    RICreatorIdRecord = table.Column<long>(name: "RI_CreatorIdRecord", type: "bigint", nullable: true),
                    RIExpertUserIdRecord = table.Column<long>(name: "RI_ExpertUserIdRecord", type: "bigint", nullable: true),
                    RIProcessStateIdRecord = table.Column<long>(name: "RI_ProcessStateIdRecord", type: "bigint", nullable: true),
                    RIRequestorIdRecord = table.Column<long>(name: "RI_RequestorIdRecord", type: "bigint", nullable: true),
                    RIRequestTitleIdRecord = table.Column<long>(name: "RI_RequestTitleIdRecord", type: "bigint", nullable: true),
                    RIRequestTypeIdRecord = table.Column<long>(name: "RI_RequestTypeIdRecord", type: "bigint", nullable: true),
                    RISubRequestTitleIdRecord = table.Column<long>(name: "RI_SubRequestTitleIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RequestInformation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_M_AllApprove_RI_AllApproveIdRecord",
                        column: x => x.RIAllApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_AllApprove",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_ProcessState_RI_ProcessStateIdRecord",
                        column: x => x.RIProcessStateIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_RequestTitle_RI_RequestTitleIdRecord",
                        column: x => x.RIRequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_RequestType_RI_RequestTypeIdRecord",
                        column: x => x.RIRequestTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_RequestType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_SubRequestTitle_RI_SubRequestTitleIdRecord",
                        column: x => x.RISubRequestTitleIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_SubRequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_CreatorIdRecord",
                        column: x => x.RICreatorIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_ExpertUserIdRecord",
                        column: x => x.RIExpertUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_RequestorIdRecord",
                        column: x => x.RIRequestorIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_Attachment",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ATCName = table.Column<string>(name: "ATC_Name", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ATCData = table.Column<byte[]>(name: "ATC_Data", type: "varbinary(max)", nullable: true),
                    MApproveIdRecord = table.Column<long>(name: "M_ApproveIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Attachment", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_Attachment_M_Approve_M_ApproveIdRecord",
                        column: x => x.MApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_Approve",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_ListOfParameter",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FloatValue = table.Column<float>(type: "real", nullable: true),
                    BooleanValue = table.Column<bool>(type: "bit", nullable: true),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOPPParameterListIdRecord = table.Column<long>(name: "LOP_P_ParameterListIdRecord", type: "bigint", nullable: true),
                    LOPPParameterTypeIdRecord = table.Column<long>(name: "LOP_P_ParameterTypeIdRecord", type: "bigint", nullable: true),
                    PTPOperandIdRecord = table.Column<long>(name: "PT_P_OperandIdRecord", type: "bigint", nullable: true),
                    MRequestInformationIdRecord = table.Column<long>(name: "M_RequestInformationIdRecord", type: "bigint", nullable: true),
                    PProcessEndorsementIdRecord = table.Column<long>(name: "P_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    SUserIdRecord = table.Column<long>(name: "S_UserIdRecord", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ListOfParameter", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_M_RequestInformation_M_RequestInformationIdRecord",
                        column: x => x.MRequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_Operand_PT_P_OperandIdRecord",
                        column: x => x.PTPOperandIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_Operand",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ParameterList_LOP_P_ParameterListIdRecord",
                        column: x => x.LOPPParameterListIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterList",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ParameterType_LOP_P_ParameterTypeIdRecord",
                        column: x => x.LOPPParameterTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                        column: x => x.PProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_S_User_S_UserIdRecord",
                        column: x => x.SUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_AllApprove_Current_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Current_M_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_AllApprove_Last_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Last_M_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_UserInChargeIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "APV_UserInChargeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "M_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_M_AllApproveIdRecord1",
                schema: "Masters",
                table: "M_Approve",
                column: "M_AllApproveIdRecord1");

            migrationBuilder.CreateIndex(
                name: "IX_M_Attachment_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_Attachment",
                column: "M_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_LOP_P_ParameterListIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "LOP_P_ParameterListIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_LOP_P_ParameterTypeIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "LOP_P_ParameterTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_PT_P_OperandIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "PT_P_OperandIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_CreatorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CreatorIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_ExpertUserIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ExpertUserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_ProcessStateIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_ProcessStateIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_RequestorIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestorIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_RequestTitleIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_RequestTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_RequestTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_SubRequestTitleIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_SubRequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_EndorsementPosition_UP_PositionOrgIdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_EndorsementPosition_UP_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                column: "UP_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_PL_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "PL_P_ParameterTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Default_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_ExpertUserIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_ExpertUserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_ProcessStateIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_ProcessStateIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_SubRequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_RequestType_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                column: "SBT_RequestTitlesIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_RolePosition_UP_PositionOrgIdRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_RolePosition_UP_RoleIdRecord",
                schema: "Parameters",
                table: "P_RolePosition",
                column: "UP_RoleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_SubRequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "P_RequestTitleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_Area_Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "Area_S_UnitTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_identityUserId",
                schema: "Systems",
                table: "S_User",
                column: "identityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_BossUserId",
                schema: "Systems",
                table: "S_User",
                column: "User_BossUserId");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_DelegateId",
                schema: "Systems",
                table: "S_User",
                column: "User_DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_UserInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserArea_UR_AreaIdRecord",
                schema: "Systems",
                table: "S_UserArea",
                column: "UR_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserArea_UR_UserIdRecord",
                schema: "Systems",
                table: "S_UserArea",
                column: "UR_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_S_LocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "S_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_UL_RelatedUserLocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "UL_RelatedUserLocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_UL_UserLocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "UL_UserLocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserRole_UR_RoleIdRecord",
                schema: "Systems",
                table: "S_UserRole",
                column: "UR_RoleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserRole_UR_UserIdRecord",
                schema: "Systems",
                table: "S_UserRole",
                column: "UR_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserSkill_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_UserSkill",
                column: "P_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserSkill_US_SkillIdRecord",
                schema: "Systems",
                table: "S_UserSkill",
                column: "US_SkillIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserSkill_US_UserIdRecord",
                schema: "Systems",
                table: "S_UserSkill",
                column: "US_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_AllApprove_M_Approve_Current_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Current_M_ApproveIdRecord",
                principalSchema: "Masters",
                principalTable: "M_Approve",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_AllApprove_M_Approve_Last_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Last_M_ApproveIdRecord",
                principalSchema: "Masters",
                principalTable: "M_Approve",
                principalColumn: "IdRecord");
        }
    }
}
