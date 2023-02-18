using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class skills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Role_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Role_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_Role_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_idTimeZone",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_idWorkingTimeSchema",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_language",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.CreateTable(
                name: "P_RolePosition",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UPRoleIdRecord = table.Column<long>(name: "UP_RoleIdRecord", type: "bigint", nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
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
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Skill", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "S_UserSkill",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USSkillIdRecord = table.Column<long>(name: "US_SkillIdRecord", type: "bigint", nullable: true),
                    USUserIdRecord = table.Column<long>(name: "US_UserIdRecord", type: "bigint", nullable: true),
                    PPositionOrgIdRecord = table.Column<long>(name: "P_PositionOrgIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_RolePosition",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "S_UserSkill",
                schema: "Systems");

            migrationBuilder.DropTable(
                name: "S_Skill",
                schema: "Systems");

            migrationBuilder.AddColumn<long>(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_idTimeZone",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_idWorkingTimeSchema",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User_language",
                schema: "Systems",
                table: "S_User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "P_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_RoleIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_Role_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role",
                column: "P_PositionOrgIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Role_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role",
                column: "P_PositionOrgIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "P_PositionOrgIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Role_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_RoleIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Role",
                principalColumn: "IdRecord");
        }
    }
}
