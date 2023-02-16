using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PPositionOrg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_FMCGRole",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_Group",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_MedicineRole",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_User",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.AddColumn<long>(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role",
                type: "bigint",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Role_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropIndex(
                name: "IX_S_Role_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.AddColumn<string>(
                name: "PSO_FMCGRole",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSO_Group",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PSO_MedicineRole",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PSO_User",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Role2IdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_RoleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Role2IdRecord",
                principalSchema: "Systems",
                principalTable: "S_Role",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_RoleIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Role",
                principalColumn: "IdRecord");
        }
    }
}
