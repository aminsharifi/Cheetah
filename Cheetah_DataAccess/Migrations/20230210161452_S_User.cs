using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.RenameColumn(
                name: "User_idUnitType",
                schema: "Systems",
                table: "S_User",
                newName: "User_S_RoleIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User",
                newName: "User_P_UnitTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_P_UnitTypeIdRecord");

            migrationBuilder.AlterColumn<byte[]>(
                name: "User_UserPicture",
                schema: "Systems",
                table: "S_User",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "User_EnabledForAssignation",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "User_DelegateEnabled",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_RoleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_UnitType_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_UnitTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UnitType",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_UnitType_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Role_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.RenameColumn(
                name: "User_S_RoleIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_idUnitType");

            migrationBuilder.RenameColumn(
                name: "User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_FirstRoleUserId");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_FirstRoleUserId");

            migrationBuilder.AlterColumn<byte>(
                name: "User_UserPicture",
                schema: "Systems",
                table: "S_User",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "User_EnabledForAssignation",
                schema: "Systems",
                table: "S_User",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "User_DelegateEnabled",
                schema: "Systems",
                table: "S_User",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_FirstRoleUserId",
                schema: "Systems",
                table: "S_User",
                column: "User_FirstRoleUserId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
