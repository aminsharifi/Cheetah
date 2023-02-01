using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddToDB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrgPosition",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POSidOrg = table.Column<long>(name: "POS_idOrg", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgPosition", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_ProcessState",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ProcessState", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_RequestTitle",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTConditionOccur = table.Column<string>(name: "RT_ConditionOccur", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTConditionOccur2 = table.Column<string>(name: "RT_ConditionOccur2", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTConditionOccur3 = table.Column<string>(name: "RT_ConditionOccur3", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTConditionOccur4 = table.Column<string>(name: "RT_ConditionOccur4", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTConditionOccur5 = table.Column<string>(name: "RT_ConditionOccur5", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTOutputVar1 = table.Column<string>(name: "RT_OutputVar1", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTOutputVar2 = table.Column<string>(name: "RT_OutputVar2", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTOutputVar3 = table.Column<string>(name: "RT_OutputVar3", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTOutputVar4 = table.Column<string>(name: "RT_OutputVar4", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTOutputVar5 = table.Column<string>(name: "RT_OutputVar5", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RTShowSupport = table.Column<bool>(name: "RT_ShowSupport", type: "bit", nullable: true),
                    RTCheckList = table.Column<bool>(name: "RT_CheckList", type: "bit", nullable: true),
                    RTERP = table.Column<bool>(name: "RT_ERP", type: "bit", nullable: true),
                    RTAnotherRequester = table.Column<bool>(name: "RT_AnotherRequester", type: "bit", nullable: true),
                    RTRemoveRequestorApproval = table.Column<bool>(name: "RT_RemoveRequestorApproval", type: "bit", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_RequestTitle", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_RequestType",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_RequestType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_UserActionGroup",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UserActionGroup", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_Area",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Area", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_Location",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Location", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_SubRequestTitle",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SBTidRequestTitles = table.Column<long>(name: "SBT_idRequestTitles", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_SubRequestTitle", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_idRequestTitles",
                        column: x => x.SBTidRequestTitles,
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_UserAction",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UAValidActions = table.Column<string>(name: "UA_ValidActions", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UAAbbreviation = table.Column<string>(name: "UA_Abbreviation", type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UAidUserActionGroup = table.Column<long>(name: "UA_idUserActionGroup", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UserAction", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_UserAction_P_UserActionGroup_UA_idUserActionGroup",
                        column: x => x.UAidUserActionGroup,
                        principalTable: "P_UserActionGroup",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_PositionOrganization",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSOUser = table.Column<string>(name: "PSO_User", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOGroup = table.Column<bool>(name: "PSO_Group", type: "bit", nullable: true),
                    PSOFMCGRole = table.Column<string>(name: "PSO_FMCGRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOMedicineRole = table.Column<string>(name: "PSO_MedicineRole", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSOidRole = table.Column<long>(name: "PSO_idRole", type: "bigint", nullable: true),
                    PSOidRole2 = table.Column<long>(name: "PSO_idRole2", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_PositionOrganization", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_PositionOrganization_Role_PSO_idRole",
                        column: x => x.PSOidRole,
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_PositionOrganization_Role_PSO_idRole2",
                        column: x => x.PSOidRole2,
                        principalTable: "Role",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_User",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFullName = table.Column<string>(name: "User_FullName", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUserName = table.Column<string>(name: "User_UserName", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserDomain = table.Column<string>(name: "User_Domain", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserEnabled = table.Column<bool>(name: "User_Enabled", type: "bit", nullable: true),
                    UserEnabledForAssignation = table.Column<byte>(name: "User_EnabledForAssignation", type: "tinyint", nullable: true),
                    UserNotifByEmail = table.Column<bool>(name: "User_NotifByEmail", type: "bit", nullable: true),
                    UserNotifByMessenger = table.Column<bool>(name: "User_NotifByMessenger", type: "bit", nullable: true),
                    UserNotifByCell = table.Column<bool>(name: "User_NotifByCell", type: "bit", nullable: true),
                    UserContactEmail = table.Column<string>(name: "User_ContactEmail", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserContactMessenger = table.Column<string>(name: "User_ContactMessenger", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserContactCell = table.Column<string>(name: "User_ContactCell", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserDelegateEnabled = table.Column<byte>(name: "User_DelegateEnabled", type: "tinyint", nullable: true),
                    Userlanguage = table.Column<int>(name: "User_language", type: "int", nullable: true),
                    UserCreatedCasesSkipAssigRules = table.Column<bool>(name: "User_CreatedCasesSkipAssigRules", type: "bit", nullable: true),
                    UserUserPicture = table.Column<byte>(name: "User_UserPicture", type: "tinyint", nullable: true),
                    UserOfflineForms = table.Column<bool>(name: "User_OfflineForms", type: "bit", nullable: true),
                    UserOvertimeCost = table.Column<decimal>(name: "User_OvertimeCost", type: "money", nullable: true),
                    UserUserStartPage = table.Column<int>(name: "User_UserStartPage", type: "int", nullable: true),
                    UserFirstName = table.Column<string>(name: "User_FirstName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserLastName = table.Column<string>(name: "User_LastName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserIDPersonel = table.Column<string>(name: "User_IDPersonel", type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserNationalCode = table.Column<string>(name: "User_NationalCode", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserRelatedLocation = table.Column<string>(name: "User_RelatedLocation", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserSubUsers = table.Column<string>(name: "User_SubUsers", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserDistrictManagerRelatedL = table.Column<string>(name: "User_DistrictManager_RelatedL", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserIsNeedUpperApprove = table.Column<bool>(name: "User_IsNeedUpperApprove", type: "bit", nullable: true),
                    UserBirthdate = table.Column<DateTime>(name: "User_Birthdate", type: "datetime2", nullable: true),
                    UserInternalPhone = table.Column<string>(name: "User_InternalPhone", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserTempIDPersonel = table.Column<string>(name: "User_Temp_IDPersonel", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserLDAPDescription = table.Column<string>(name: "User_LDAPDescription", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UseridWorkingTimeSchema = table.Column<long>(name: "User_idWorkingTimeSchema", type: "bigint", nullable: true),
                    UseridTimeZone = table.Column<long>(name: "User_idTimeZone", type: "bigint", nullable: true),
                    UseridUnitType = table.Column<long>(name: "User_idUnitType", type: "bigint", nullable: true),
                    UseridFirstRoleUser = table.Column<long>(name: "User_idFirstRoleUser", type: "bigint", nullable: true),
                    UseridFirstApprover = table.Column<long>(name: "User_idFirstApprover", type: "bigint", nullable: true),
                    UseridSecondApprover = table.Column<long>(name: "User_idSecondApprover", type: "bigint", nullable: true),
                    UseridArea = table.Column<long>(name: "User_idArea", type: "bigint", nullable: true),
                    UseridLocation = table.Column<long>(name: "User_idLocation", type: "bigint", nullable: true),
                    UseridBossUser = table.Column<long>(name: "User_idBossUser", type: "bigint", nullable: true),
                    UseridDelegate = table.Column<long>(name: "User_idDelegate", type: "bigint", nullable: true),
                    UseridDefaultPosition = table.Column<long>(name: "User_idDefaultPosition", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_User", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_User_OrgPosition_User_idDefaultPosition",
                        column: x => x.UseridDefaultPosition,
                        principalTable: "OrgPosition",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_Area_User_idArea",
                        column: x => x.UseridArea,
                        principalTable: "S_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_Location_User_idLocation",
                        column: x => x.UseridLocation,
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_idBossUser",
                        column: x => x.UseridBossUser,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_idDelegate",
                        column: x => x.UseridDelegate,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_idFirstApprover",
                        column: x => x.UseridFirstApprover,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_idFirstRoleUser",
                        column: x => x.UseridFirstRoleUser,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_User_S_User_User_idSecondApprover",
                        column: x => x.UseridSecondApprover,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "P_ProcessEndorsement",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSEConditional = table.Column<bool>(name: "PSE_Conditional", type: "bit", nullable: true),
                    PSEConditional2 = table.Column<bool>(name: "PSE_Conditional2", type: "bit", nullable: true),
                    PSEConditional3 = table.Column<bool>(name: "PSE_Conditional3", type: "bit", nullable: true),
                    PSEConditional4 = table.Column<bool>(name: "PSE_Conditional4", type: "bit", nullable: true),
                    PSEConditional5 = table.Column<bool>(name: "PSE_Conditional5", type: "bit", nullable: true),
                    PSEConditionDrug = table.Column<bool>(name: "PSE_ConditionDrug", type: "bit", nullable: true),
                    PSEConditionFMCG = table.Column<bool>(name: "PSE_ConditionFMCG", type: "bit", nullable: true),
                    PSESupplierSHare = table.Column<bool>(name: "PSE_SupplierSHare", type: "bit", nullable: true),
                    PSECompanySHare = table.Column<bool>(name: "PSE_CompanySHare", type: "bit", nullable: true),
                    PSEMail = table.Column<bool>(name: "PSE_Mail", type: "bit", nullable: true),
                    PSEAutomation = table.Column<bool>(name: "PSE_Automation", type: "bit", nullable: true),
                    PSESMS = table.Column<bool>(name: "PSE_SMS", type: "bit", nullable: true),
                    PSETranscript = table.Column<bool>(name: "PSE_Transcript", type: "bit", nullable: true),
                    PSETaskName = table.Column<string>(name: "PSE_TaskName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSEValidUserAction = table.Column<string>(name: "PSE_ValidUserAction", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSEActive = table.Column<bool>(name: "PSE_Active", type: "bit", nullable: true),
                    PSESubRequestTitles = table.Column<string>(name: "PSE_SubRequestTitles", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSEValidOutput = table.Column<string>(name: "PSE_ValidOutput", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PSESendAll = table.Column<bool>(name: "PSE_SendAll", type: "bit", nullable: true),
                    PSEUserRelationship = table.Column<long>(name: "PSE_UserRelationship", type: "bigint", maxLength: 50, nullable: true),
                    PSEidExpertUser = table.Column<long>(name: "PSE_idExpertUser", type: "bigint", nullable: true),
                    PSEidPON = table.Column<long>(name: "PSE_idPON", type: "bigint", nullable: true),
                    PSEidRequestTitle = table.Column<long>(name: "PSE_idRequestTitle", type: "bigint", nullable: true),
                    PSEidProcessState = table.Column<long>(name: "PSE_idProcessState", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ProcessEndorsement", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_PositionOrganization_PSE_idPON",
                        column: x => x.PSEidPON,
                        principalTable: "P_PositionOrganization",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_ProcessState_PSE_idProcessState",
                        column: x => x.PSEidProcessState,
                        principalTable: "P_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_P_RequestTitle_PSE_idRequestTitle",
                        column: x => x.PSEidRequestTitle,
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_ProcessEndorsement_S_User_PSE_idExpertUser",
                        column: x => x.PSEidExpertUser,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_RequestInformation",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RIWSResult = table.Column<bool>(name: "RI_WS_Result", type: "bit", nullable: true),
                    RIWSResultDesc = table.Column<string>(name: "RI_WS_Result_Desc", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIWSTryNum = table.Column<int>(name: "RI_WS_TryNum", type: "int", nullable: true),
                    RIWSResultCode = table.Column<int>(name: "RI_WS_Result_Code", type: "int", nullable: true),
                    RIWSCurrentId = table.Column<long>(name: "RI_WS_CurrentId", type: "bigint", nullable: true),
                    RIRequestDate = table.Column<DateTime>(name: "RI_RequestDate", type: "datetime2", nullable: true),
                    RIRequestFinishDate = table.Column<DateTime>(name: "RI_RequestFinishDate", type: "datetime2", nullable: true),
                    RIOldDate = table.Column<DateTime>(name: "RI_OldDate", type: "datetime2", nullable: true),
                    RINewDate = table.Column<DateTime>(name: "RI_NewDate", type: "datetime2", nullable: true),
                    RILastTimeModify = table.Column<DateTime>(name: "RI_LastTimeModify", type: "datetime2", nullable: true),
                    RIConditionOccur1 = table.Column<bool>(name: "RI_ConditionOccur1", type: "bit", nullable: true),
                    RIConditionOccur2 = table.Column<bool>(name: "RI_ConditionOccur2", type: "bit", nullable: true),
                    RIConditionOccur3 = table.Column<bool>(name: "RI_ConditionOccur3", type: "bit", nullable: true),
                    RIConditionOccur4 = table.Column<bool>(name: "RI_ConditionOccur4", type: "bit", nullable: true),
                    RIConditionOccur5 = table.Column<bool>(name: "RI_ConditionOccur5", type: "bit", nullable: true),
                    RIConditionDrug = table.Column<bool>(name: "RI_ConditionDrug", type: "bit", nullable: true),
                    RIConditionFMCG = table.Column<bool>(name: "RI_ConditionFMCG", type: "bit", nullable: true),
                    RISupplierSHare = table.Column<bool>(name: "RI_SupplierSHare", type: "bit", nullable: true),
                    RIAlborzSHare = table.Column<bool>(name: "RI_AlborzSHare", type: "bit", nullable: true),
                    RIProcessVar1 = table.Column<string>(name: "RI_ProcessVar1", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIProcessVar2 = table.Column<string>(name: "RI_ProcessVar2", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIProcessVar3 = table.Column<string>(name: "RI_ProcessVar3", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIProcessVar4 = table.Column<string>(name: "RI_ProcessVar4", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIProcessVar5 = table.Column<string>(name: "RI_ProcessVar5", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    RIInputuser1 = table.Column<string>(name: "RI_Inputuser1", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RIOutputVar1 = table.Column<string>(name: "RI_OutputVar1", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIOutputVar2 = table.Column<string>(name: "RI_OutputVar2", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIOutputVar3 = table.Column<string>(name: "RI_OutputVar3", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIOutputVar4 = table.Column<string>(name: "RI_OutputVar4", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIOutputVar5 = table.Column<string>(name: "RI_OutputVar5", type: "nvarchar(2500)", maxLength: 2500, nullable: true),
                    RIERPID = table.Column<long>(name: "RI_ERPID", type: "bigint", nullable: true),
                    RIERPKindID = table.Column<string>(name: "RI_ERPKindID", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIERPBranchs = table.Column<string>(name: "RI_ERPBranchs", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIIsCancelled = table.Column<bool>(name: "RI_IsCancelled", type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RIRequestID = table.Column<long>(name: "RI_RequestID", type: "bigint", nullable: true),
                    RIRequestNumber = table.Column<string>(name: "RI_RequestNumber", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdWorkItem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RIAddress = table.Column<string>(name: "RI_Address", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RILastUserComment = table.Column<string>(name: "RI_LastUserComment", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIPELevel = table.Column<byte>(name: "RI_PE_Level", type: "tinyint", nullable: true),
                    RIAttachment = table.Column<byte>(name: "RI_Attachment", type: "tinyint", nullable: true),
                    RIRequestSubject = table.Column<string>(name: "RI_RequestSubject", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RITaskName = table.Column<string>(name: "RI_TaskName", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIUserNameCreator = table.Column<string>(name: "RI_UserNameCreator", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIValidUserAction = table.Column<string>(name: "RI_ValidUserAction", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIUserComment = table.Column<string>(name: "RI_UserComment", type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RILastTaskSentDate = table.Column<DateTime>(name: "RI_LastTaskSentDate", type: "datetime2", nullable: true),
                    RIPeople = table.Column<string>(name: "RI_People", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RICurrentUserNames = table.Column<string>(name: "RI_CurrentUserNames", type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RIidUnitType = table.Column<long>(name: "RI_idUnitType", type: "bigint", nullable: true),
                    RIPerson = table.Column<long>(name: "RI_Person", type: "bigint", nullable: true),
                    RIRejectReason = table.Column<long>(name: "RI_RejectReason", type: "bigint", nullable: true),
                    RIidExpertUser = table.Column<long>(name: "RI_idExpertUser", type: "bigint", nullable: true),
                    RIidLastUserInCharge = table.Column<long>(name: "RI_idLastUserInCharge", type: "bigint", nullable: true),
                    RIidRequestor = table.Column<long>(name: "RI_idRequestor", type: "bigint", nullable: true),
                    RIidCreator = table.Column<long>(name: "RI_idCreator", type: "bigint", nullable: true),
                    RIidLocation = table.Column<long>(name: "RI_idLocation", type: "bigint", nullable: true),
                    RIidRequestType = table.Column<long>(name: "RI_idRequestType", type: "bigint", nullable: true),
                    RIidRequestTitle = table.Column<long>(name: "RI_idRequestTitle", type: "bigint", nullable: true),
                    RIidSubRequestTitle = table.Column<long>(name: "RI_idSubRequestTitle", type: "bigint", nullable: true),
                    RIActiveidProcessEndorsement = table.Column<long>(name: "RI_ActiveidProcessEndorsement", type: "bigint", nullable: true),
                    RIidArea = table.Column<long>(name: "RI_idArea", type: "bigint", nullable: true),
                    RIidUserAction = table.Column<long>(name: "RI_idUserAction", type: "bigint", nullable: true),
                    RIidLastUserAction = table.Column<long>(name: "RI_idLastUserAction", type: "bigint", nullable: true),
                    RIidProcessState = table.Column<long>(name: "RI_idProcessState", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RequestInformation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_ProcessEndorsement_RI_ActiveidProcessEndorsement",
                        column: x => x.RIActiveidProcessEndorsement,
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_ProcessState_RI_idProcessState",
                        column: x => x.RIidProcessState,
                        principalTable: "P_ProcessState",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_RequestTitle_RI_idRequestTitle",
                        column: x => x.RIidRequestTitle,
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_RequestType_RI_idRequestType",
                        column: x => x.RIidRequestType,
                        principalTable: "P_RequestType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_SubRequestTitle_RI_idSubRequestTitle",
                        column: x => x.RIidSubRequestTitle,
                        principalTable: "P_SubRequestTitle",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_UserAction_RI_idLastUserAction",
                        column: x => x.RIidLastUserAction,
                        principalTable: "P_UserAction",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_P_UserAction_RI_idUserAction",
                        column: x => x.RIidUserAction,
                        principalTable: "P_UserAction",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_Area_RI_idArea",
                        column: x => x.RIidArea,
                        principalTable: "S_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_Location_RI_idLocation",
                        column: x => x.RIidLocation,
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_idCreator",
                        column: x => x.RIidCreator,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_idExpertUser",
                        column: x => x.RIidExpertUser,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_idLastUserInCharge",
                        column: x => x.RIidLastUserInCharge,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_RequestInformation_S_User_RI_idRequestor",
                        column: x => x.RIidRequestor,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_Approve",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APVTaskRecieveDate = table.Column<DateTime>(name: "APV_TaskRecieveDate", type: "datetime2", nullable: true),
                    APVTaskSentDate = table.Column<DateTime>(name: "APV_TaskSentDate", type: "datetime2", nullable: true),
                    APVUserDescription = table.Column<string>(name: "APV_UserDescription", type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    APVSubject = table.Column<string>(name: "APV_Subject", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APVNumber = table.Column<string>(name: "APV_Number", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    APVAttachment = table.Column<byte>(name: "APV_Attachment", type: "tinyint", nullable: true),
                    APVidRequestInformation = table.Column<long>(name: "APV_idRequestInformation", type: "bigint", nullable: true),
                    APVidUserAction = table.Column<long>(name: "APV_idUserAction", type: "bigint", nullable: true),
                    APVidUserInCharge = table.Column<long>(name: "APV_idUserInCharge", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Approve", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_Approve_M_RequestInformation_APV_idRequestInformation",
                        column: x => x.APVidRequestInformation,
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_Approve_P_UserAction_APV_idUserAction",
                        column: x => x.APVidUserAction,
                        principalTable: "P_UserAction",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_Approve_S_User_APV_idUserInCharge",
                        column: x => x.APVidUserInCharge,
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "M_CallWebService",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CWSURL = table.Column<string>(name: "CWS_URL", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CWSJsonInputBody = table.Column<string>(name: "CWS_JsonInputBody", type: "ntext", nullable: true),
                    CWSWSResult = table.Column<bool>(name: "CWS_WSResult", type: "bit", nullable: true),
                    CWSWSResultCode = table.Column<int>(name: "CWS_WSResult_Code", type: "int", nullable: true),
                    CWSWSResultDesc = table.Column<string>(name: "CWS_WSResult_Desc", type: "nvarchar(2500)", maxLength: 2500, nullable: true),
                    CWSidParameterList = table.Column<long>(name: "CWS_idParameterList", type: "bigint", nullable: false),
                    CWSRequestInformationIdRecord = table.Column<long>(name: "CWS_RequestInformationIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CallWebService", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_CallWebService_M_RequestInformation_CWS_RequestInformationIdRecord",
                        column: x => x.CWSRequestInformationIdRecord,
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CallWebService_P_ParameterList_CWS_idParameterList",
                        column: x => x.CWSidParameterList,
                        principalTable: "P_ParameterList",
                        principalColumn: "IdRecord",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_UserActionsProcess",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UAPAutomation = table.Column<bool>(name: "UAP_Automation", type: "bit", nullable: true),
                    UAPsenderinput = table.Column<string>(name: "UAP_sender_input", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UAPReceiverinput = table.Column<string>(name: "UAP_Receiver_input", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UAPSubjectinput = table.Column<string>(name: "UAP_Subject_input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UAPTextBodyinput = table.Column<string>(name: "UAP_TextBody_input", type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    UAPIdentificationCodeinput = table.Column<string>(name: "UAP_IdentificationCode_input", type: "nvarchar(215)", maxLength: 215, nullable: true),
                    UAPSendLetterResponse = table.Column<bool>(name: "UAP_SendLetterResponse", type: "bit", nullable: true),
                    UAPSendERP = table.Column<bool>(name: "UAP_SendERP", type: "bit", nullable: true),
                    UAPSendNotifyERP = table.Column<bool>(name: "UAP_SendNotifyERP", type: "bit", nullable: true),
                    UAPCreateDate = table.Column<DateTime>(name: "UAP_CreateDate", type: "datetime2", nullable: true),
                    UAPSMS = table.Column<bool>(name: "UAP_SMS", type: "bit", nullable: true),
                    UAPidCurrentPE = table.Column<long>(name: "UAP_idCurrentPE", type: "bigint", nullable: true),
                    UAPidRequestTitle = table.Column<long>(name: "UAP_idRequestTitle", type: "bigint", nullable: true),
                    idRequestInformation = table.Column<long>(type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_UserActionsProcess", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_M_RequestInformation_idRequestInformation",
                        column: x => x.idRequestInformation,
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_P_ProcessEndorsement_UAP_idCurrentPE",
                        column: x => x.UAPidCurrentPE,
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_UserActionsProcess_P_RequestTitle_UAP_idRequestTitle",
                        column: x => x.UAPidRequestTitle,
                        principalTable: "P_RequestTitle",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_idRequestInformation",
                table: "M_Approve",
                column: "APV_idRequestInformation");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_idUserAction",
                table: "M_Approve",
                column: "APV_idUserAction");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_APV_idUserInCharge",
                table: "M_Approve",
                column: "APV_idUserInCharge");

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_CWS_idParameterList",
                table: "M_CallWebService",
                column: "CWS_idParameterList");

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_CWS_RequestInformationIdRecord",
                table: "M_CallWebService",
                column: "CWS_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_ActiveidProcessEndorsement",
                table: "M_RequestInformation",
                column: "RI_ActiveidProcessEndorsement");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idArea",
                table: "M_RequestInformation",
                column: "RI_idArea");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idCreator",
                table: "M_RequestInformation",
                column: "RI_idCreator");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idExpertUser",
                table: "M_RequestInformation",
                column: "RI_idExpertUser");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idLastUserAction",
                table: "M_RequestInformation",
                column: "RI_idLastUserAction");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idLastUserInCharge",
                table: "M_RequestInformation",
                column: "RI_idLastUserInCharge");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idLocation",
                table: "M_RequestInformation",
                column: "RI_idLocation");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idProcessState",
                table: "M_RequestInformation",
                column: "RI_idProcessState");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idRequestor",
                table: "M_RequestInformation",
                column: "RI_idRequestor");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idRequestTitle",
                table: "M_RequestInformation",
                column: "RI_idRequestTitle");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idRequestType",
                table: "M_RequestInformation",
                column: "RI_idRequestType");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idSubRequestTitle",
                table: "M_RequestInformation",
                column: "RI_idSubRequestTitle");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idUserAction",
                table: "M_RequestInformation",
                column: "RI_idUserAction");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_idRequestInformation",
                table: "M_UserActionsProcess",
                column: "idRequestInformation");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_UAP_idCurrentPE",
                table: "M_UserActionsProcess",
                column: "UAP_idCurrentPE");

            migrationBuilder.CreateIndex(
                name: "IX_M_UserActionsProcess_UAP_idRequestTitle",
                table: "M_UserActionsProcess",
                column: "UAP_idRequestTitle");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrganization_PSO_idRole",
                table: "P_PositionOrganization",
                column: "PSO_idRole");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrganization_PSO_idRole2",
                table: "P_PositionOrganization",
                column: "PSO_idRole2");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_idExpertUser",
                table: "P_ProcessEndorsement",
                column: "PSE_idExpertUser");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_idPON",
                table: "P_ProcessEndorsement",
                column: "PSE_idPON");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_idProcessState",
                table: "P_ProcessEndorsement",
                column: "PSE_idProcessState");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_idRequestTitle",
                table: "P_ProcessEndorsement",
                column: "PSE_idRequestTitle");

            migrationBuilder.CreateIndex(
                name: "IX_P_SubRequestTitle_SBT_idRequestTitles",
                table: "P_SubRequestTitle",
                column: "SBT_idRequestTitles");

            migrationBuilder.CreateIndex(
                name: "IX_P_UserAction_UA_idUserActionGroup",
                table: "P_UserAction",
                column: "UA_idUserActionGroup");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idArea",
                table: "S_User",
                column: "User_idArea");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idBossUser",
                table: "S_User",
                column: "User_idBossUser");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idDefaultPosition",
                table: "S_User",
                column: "User_idDefaultPosition");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idDelegate",
                table: "S_User",
                column: "User_idDelegate");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idFirstApprover",
                table: "S_User",
                column: "User_idFirstApprover");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idFirstRoleUser",
                table: "S_User",
                column: "User_idFirstRoleUser");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idLocation",
                table: "S_User",
                column: "User_idLocation");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_idSecondApprover",
                table: "S_User",
                column: "User_idSecondApprover");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Approve");

            migrationBuilder.DropTable(
                name: "M_CallWebService");

            migrationBuilder.DropTable(
                name: "M_UserActionsProcess");

            migrationBuilder.DropTable(
                name: "M_RequestInformation");

            migrationBuilder.DropTable(
                name: "P_ProcessEndorsement");

            migrationBuilder.DropTable(
                name: "P_RequestType");

            migrationBuilder.DropTable(
                name: "P_SubRequestTitle");

            migrationBuilder.DropTable(
                name: "P_UserAction");

            migrationBuilder.DropTable(
                name: "P_PositionOrganization");

            migrationBuilder.DropTable(
                name: "P_ProcessState");

            migrationBuilder.DropTable(
                name: "S_User");

            migrationBuilder.DropTable(
                name: "P_RequestTitle");

            migrationBuilder.DropTable(
                name: "P_UserActionGroup");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "OrgPosition");

            migrationBuilder.DropTable(
                name: "S_Area");

            migrationBuilder.DropTable(
                name: "S_Location");
        }
    }
}
