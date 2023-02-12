using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "S_UserRole",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URRoleIdRecord = table.Column<long>(name: "UR_RoleIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_UserRole",
                schema: "Systems");
        }
    }
}
