using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DBchanged2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_Role_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_Role_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                schema: "Systems",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrgPosition",
                schema: "Systems",
                table: "OrgPosition");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Systems",
                newName: "S_Role",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "OrgPosition",
                schema: "Systems",
                newName: "S_OrgPosition",
                newSchema: "Systems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Role",
                schema: "Systems",
                table: "S_Role",
                column: "IdRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_OrgPosition",
                schema: "Systems",
                table: "S_OrgPosition",
                column: "IdRecord");

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

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_DefaultPositionIdRecord",
                principalSchema: "Systems",
                principalTable: "S_OrgPosition",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_Role_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Role",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_OrgPosition",
                schema: "Systems",
                table: "S_OrgPosition");

            migrationBuilder.RenameTable(
                name: "S_Role",
                schema: "Systems",
                newName: "Role",
                newSchema: "Systems");

            migrationBuilder.RenameTable(
                name: "S_OrgPosition",
                schema: "Systems",
                newName: "OrgPosition",
                newSchema: "Systems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                schema: "Systems",
                table: "Role",
                column: "IdRecord");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrgPosition",
                schema: "Systems",
                table: "OrgPosition",
                column: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_Role_PSO_Role2IdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Role2IdRecord",
                principalSchema: "Systems",
                principalTable: "Role",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_Role_PSO_RoleIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_RoleIdRecord",
                principalSchema: "Systems",
                principalTable: "Role",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_DefaultPositionIdRecord",
                principalSchema: "Systems",
                principalTable: "OrgPosition",
                principalColumn: "IdRecord");
        }
    }
}
