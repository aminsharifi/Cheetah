using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations;

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
            name: "D_CaseState",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_CaseState", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_Entity",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                Display = table.Column<bool>(type: "bit", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Entity", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_Operand",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Operand", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_Position",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Position", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_Process",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                ShowSupport = table.Column<bool>(type: "bit", nullable: true),
                ERP = table.Column<bool>(type: "bit", nullable: true),
                RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Process", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_Role",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                Independent = table.Column<bool>(type: "bit", nullable: false),
                FixedRole = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Role", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_TagType",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_TagType", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "D_UserInformation",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
            });

        migrationBuilder.CreateTable(
            name: "D_WorkItemState",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_WorkItemState", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "F_Attachment",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_F_Attachment", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "F_Scenario",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_F_Scenario", x => x.Id);
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
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
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
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
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
            });

        migrationBuilder.CreateTable(
            name: "D_User",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
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
            name: "L_ProcessScenario",
            schema: "Links",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
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
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                RequestorId = table.Column<long>(type: "bigint", nullable: true),
                CreatorId = table.Column<long>(type: "bigint", nullable: true),
                CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                ProcessId = table.Column<long>(type: "bigint", nullable: true),
                SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_F_Case", x => x.Id);
                table.ForeignKey(
                    name: "FK_F_Case_D_CaseState_CaseStateId",
                    column: x => x.CaseStateId,
                    principalSchema: "Dimentions",
                    principalTable: "D_CaseState",
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
                    name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                    column: x => x.SelectedScenarioId,
                    principalSchema: "Facts",
                    principalTable: "F_Scenario",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "L_UserPosition",
            schema: "Links",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
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
            name: "D_Location",
            schema: "Dimentions",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                EndorsementItemId = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_D_Location", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "L_UserLocation",
            schema: "Links",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
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
            name: "F_Condition",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                TagId = table.Column<long>(type: "bigint", nullable: true),
                OperandId = table.Column<long>(type: "bigint", nullable: true),
                Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                CaseId = table.Column<long>(type: "bigint", nullable: true),
                EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
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
                    name: "FK_F_Condition_F_Scenario_ScenarioId",
                    column: x => x.ScenarioId,
                    principalSchema: "Facts",
                    principalTable: "F_Scenario",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "F_Endorsement",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                RoleId = table.Column<long>(type: "bigint", nullable: true),
                ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                ConditionId = table.Column<long>(type: "bigint", nullable: true)
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
                    name: "FK_F_Endorsement_F_Condition_ConditionId",
                    column: x => x.ConditionId,
                    principalSchema: "Facts",
                    principalTable: "F_Condition",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_F_Endorsement_F_Scenario_ScenarioId",
                    column: x => x.ScenarioId,
                    principalSchema: "Facts",
                    principalTable: "F_Scenario",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "F_EndorsementItem",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                EndorsementId = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_F_EndorsementItem", x => x.Id);
                table.ForeignKey(
                    name: "FK_F_EndorsementItem_D_CaseState_CaseStateId",
                    column: x => x.CaseStateId,
                    principalSchema: "Dimentions",
                    principalTable: "D_CaseState",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_F_EndorsementItem_F_Endorsement_EndorsementId",
                    column: x => x.EndorsementId,
                    principalSchema: "Facts",
                    principalTable: "F_Endorsement",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "F_WorkItem",
            schema: "Facts",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                UserId = table.Column<long>(type: "bigint", nullable: true),
                CaseId = table.Column<long>(type: "bigint", nullable: true),
                TagId = table.Column<long>(type: "bigint", nullable: true),
                WorkItemStateId = table.Column<long>(type: "bigint", nullable: true)
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
                    name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                    column: x => x.WorkItemStateId,
                    principalSchema: "Dimentions",
                    principalTable: "D_WorkItemState",
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
            });

        migrationBuilder.CreateTable(
            name: "L_EndorsementUser",
            schema: "Links",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                FirstId = table.Column<long>(type: "bigint", nullable: true),
                SecondId = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_L_EndorsementUser", x => x.Id);
                table.ForeignKey(
                    name: "FK_L_EndorsementUser_D_User_SecondId",
                    column: x => x.SecondId,
                    principalSchema: "Dimentions",
                    principalTable: "D_User",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_L_EndorsementUser_F_Endorsement_FirstId",
                    column: x => x.FirstId,
                    principalSchema: "Facts",
                    principalTable: "F_Endorsement",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "L_EndorsementItemEndorsement",
            schema: "Links",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SortIndex = table.Column<long>(type: "bigint", nullable: true),
                Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                ERPCode = table.Column<long>(type: "bigint", nullable: true),
                FirstId = table.Column<long>(type: "bigint", nullable: true),
                SecondId = table.Column<long>(type: "bigint", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_L_EndorsementItemEndorsement", x => x.Id);
                table.ForeignKey(
                    name: "FK_L_EndorsementItemEndorsement_F_EndorsementItem_FirstId",
                    column: x => x.FirstId,
                    principalSchema: "Facts",
                    principalTable: "F_EndorsementItem",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_L_EndorsementItemEndorsement_F_Endorsement_SecondId",
                    column: x => x.SecondId,
                    principalSchema: "Facts",
                    principalTable: "F_Endorsement",
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
            name: "IX_D_CaseState_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_CaseState",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_CaseState_EnableRecord",
            schema: "Dimentions",
            table: "D_CaseState",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_D_CaseState_ERPCode",
            schema: "Dimentions",
            table: "D_CaseState",
            column: "ERPCode",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_D_CaseState_LastUpdatedRecord",
            schema: "Dimentions",
            table: "D_CaseState",
            column: "LastUpdatedRecord",
            unique: true,
            descending: new bool[0],
            filter: "[LastUpdatedRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_CaseState_Name",
            schema: "Dimentions",
            table: "D_CaseState",
            column: "Name",
            unique: true,
            descending: new bool[0],
            filter: "[Name] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Entity_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Entity",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Entity_EnableRecord",
            schema: "Dimentions",
            table: "D_Entity",
            column: "EnableRecord",
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
            name: "IX_D_Location_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Location",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Location_EnableRecord",
            schema: "Dimentions",
            table: "D_Location",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_D_Location_EndorsementItemId",
            schema: "Dimentions",
            table: "D_Location",
            column: "EndorsementItemId");

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
            name: "IX_D_Operand_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Operand",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Operand_EnableRecord",
            schema: "Dimentions",
            table: "D_Operand",
            column: "EnableRecord",
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
            name: "IX_D_Position_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Position",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Position_EnableRecord",
            schema: "Dimentions",
            table: "D_Position",
            column: "EnableRecord",
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
            name: "IX_D_Process_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Process",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Process_EnableRecord",
            schema: "Dimentions",
            table: "D_Process",
            column: "EnableRecord",
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
            name: "IX_D_Role_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Role",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Role_EnableRecord",
            schema: "Dimentions",
            table: "D_Role",
            column: "EnableRecord",
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
            name: "IX_D_Tag_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_Tag",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_Tag_EnableRecord",
            schema: "Dimentions",
            table: "D_Tag",
            column: "EnableRecord",
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
            name: "IX_D_TagType_EnableRecord",
            schema: "Dimentions",
            table: "D_TagType",
            column: "EnableRecord",
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
            name: "IX_D_User_EnableRecord",
            schema: "Dimentions",
            table: "D_User",
            column: "EnableRecord",
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
            name: "IX_D_UserInformation_EnableRecord",
            schema: "Dimentions",
            table: "D_UserInformation",
            column: "EnableRecord",
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
            name: "IX_D_WorkItemState_CreateTimeRecord",
            schema: "Dimentions",
            table: "D_WorkItemState",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_WorkItemState_EnableRecord",
            schema: "Dimentions",
            table: "D_WorkItemState",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_D_WorkItemState_ERPCode",
            schema: "Dimentions",
            table: "D_WorkItemState",
            column: "ERPCode",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_D_WorkItemState_LastUpdatedRecord",
            schema: "Dimentions",
            table: "D_WorkItemState",
            column: "LastUpdatedRecord",
            unique: true,
            descending: new bool[0],
            filter: "[LastUpdatedRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_D_WorkItemState_Name",
            schema: "Dimentions",
            table: "D_WorkItemState",
            column: "Name",
            unique: true,
            descending: new bool[0],
            filter: "[Name] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_Attachment_CreateTimeRecord",
            schema: "Facts",
            table: "F_Attachment",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_Attachment_EnableRecord",
            schema: "Facts",
            table: "F_Attachment",
            column: "EnableRecord",
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
            name: "IX_F_Case_CaseStateId",
            schema: "Facts",
            table: "F_Case",
            column: "CaseStateId");

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
            name: "IX_F_Case_ProcessId",
            schema: "Facts",
            table: "F_Case",
            column: "ProcessId");

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
            name: "IX_F_Condition_EnableRecord",
            schema: "Facts",
            table: "F_Condition",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_F_Condition_EndorsementItemId",
            schema: "Facts",
            table: "F_Condition",
            column: "EndorsementItemId");

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
            name: "IX_F_Endorsement_ConditionId",
            schema: "Facts",
            table: "F_Endorsement",
            column: "ConditionId");

        migrationBuilder.CreateIndex(
            name: "IX_F_Endorsement_CreateTimeRecord",
            schema: "Facts",
            table: "F_Endorsement",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_Endorsement_EnableRecord",
            schema: "Facts",
            table: "F_Endorsement",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_F_Endorsement_EndorsementItemId",
            schema: "Facts",
            table: "F_Endorsement",
            column: "EndorsementItemId");

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
            name: "IX_F_EndorsementItem_CaseStateId",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "CaseStateId");

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_CreateTimeRecord",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_EnableRecord",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_EndorsementId",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "EndorsementId");

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_ERPCode",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "ERPCode",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_LastUpdatedRecord",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "LastUpdatedRecord",
            unique: true,
            descending: new bool[0],
            filter: "[LastUpdatedRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_EndorsementItem_Name",
            schema: "Facts",
            table: "F_EndorsementItem",
            column: "Name",
            unique: true,
            descending: new bool[0],
            filter: "[Name] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_Scenario_CreateTimeRecord",
            schema: "Facts",
            table: "F_Scenario",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_F_Scenario_EnableRecord",
            schema: "Facts",
            table: "F_Scenario",
            column: "EnableRecord",
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
            name: "IX_F_WorkItem_EnableRecord",
            schema: "Facts",
            table: "F_WorkItem",
            column: "EnableRecord",
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
            name: "IX_F_WorkItem_WorkItemStateId",
            schema: "Facts",
            table: "F_WorkItem",
            column: "WorkItemStateId");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_CreateTimeRecord",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_EnableRecord",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_ERPCode",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "ERPCode",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_FirstId",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "FirstId",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_LastUpdatedRecord",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "LastUpdatedRecord",
            unique: true,
            descending: new bool[0],
            filter: "[LastUpdatedRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_Name",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "Name",
            unique: true,
            descending: new bool[0],
            filter: "[Name] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementItemEndorsement_SecondId",
            schema: "Links",
            table: "L_EndorsementItemEndorsement",
            column: "SecondId",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_CreateTimeRecord",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_EnableRecord",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "EnableRecord",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_ERPCode",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "ERPCode",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_FirstId",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "FirstId",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_LastUpdatedRecord",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "LastUpdatedRecord",
            unique: true,
            descending: new bool[0],
            filter: "[LastUpdatedRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_Name",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "Name",
            unique: true,
            descending: new bool[0],
            filter: "[Name] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_EndorsementUser_SecondId",
            schema: "Links",
            table: "L_EndorsementUser",
            column: "SecondId",
            descending: new bool[0]);

        migrationBuilder.CreateIndex(
            name: "IX_L_ProcessScenario_CreateTimeRecord",
            schema: "Links",
            table: "L_ProcessScenario",
            column: "CreateTimeRecord",
            unique: true,
            descending: new bool[0],
            filter: "[CreateTimeRecord] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_L_ProcessScenario_EnableRecord",
            schema: "Links",
            table: "L_ProcessScenario",
            column: "EnableRecord",
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
            name: "IX_L_RolePosition_EnableRecord",
            schema: "Links",
            table: "L_RolePosition",
            column: "EnableRecord",
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
            name: "IX_L_UserLocation_EnableRecord",
            schema: "Links",
            table: "L_UserLocation",
            column: "EnableRecord",
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
            name: "IX_L_UserPosition_EnableRecord",
            schema: "Links",
            table: "L_UserPosition",
            column: "EnableRecord",
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

        migrationBuilder.AddForeignKey(
            name: "FK_D_Location_F_EndorsementItem_EndorsementItemId",
            schema: "Dimentions",
            table: "D_Location",
            column: "EndorsementItemId",
            principalSchema: "Facts",
            principalTable: "F_EndorsementItem",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
            schema: "Facts",
            table: "F_Condition",
            column: "EndorsementItemId",
            principalSchema: "Facts",
            principalTable: "F_EndorsementItem",
            principalColumn: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
            schema: "Facts",
            table: "F_Endorsement",
            column: "EndorsementItemId",
            principalSchema: "Facts",
            principalTable: "F_EndorsementItem",
            principalColumn: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_F_Case_D_User_CreatorId",
            schema: "Facts",
            table: "F_Case");

        migrationBuilder.DropForeignKey(
            name: "FK_F_Case_D_User_RequestorId",
            schema: "Facts",
            table: "F_Case");

        migrationBuilder.DropForeignKey(
            name: "FK_F_Condition_D_User_D_UserId",
            schema: "Facts",
            table: "F_Condition");

        migrationBuilder.DropForeignKey(
            name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
            schema: "Facts",
            table: "F_Condition");

        migrationBuilder.DropForeignKey(
            name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
            schema: "Facts",
            table: "F_Endorsement");

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
            name: "F_WorkItem",
            schema: "Facts");

        migrationBuilder.DropTable(
            name: "L_EndorsementItemEndorsement",
            schema: "Links");

        migrationBuilder.DropTable(
            name: "L_EndorsementUser",
            schema: "Links");

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
            name: "D_WorkItemState",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_Location",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_Position",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_User",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_UserInformation",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "F_EndorsementItem",
            schema: "Facts");

        migrationBuilder.DropTable(
            name: "F_Endorsement",
            schema: "Facts");

        migrationBuilder.DropTable(
            name: "D_Role",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "F_Condition",
            schema: "Facts");

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
            name: "D_TagType",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_CaseState",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "D_Process",
            schema: "Dimentions");

        migrationBuilder.DropTable(
            name: "F_Scenario",
            schema: "Facts");
    }
}

