using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatemiddle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_UserArea_D_Area_FirstId",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserArea_D_User_SecondId",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_D_Role_FirstId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_D_User_SecondId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_D_Skill_FirstId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_D_User_SecondId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserArea_D_Area_SecondId",
                schema: "Links",
                table: "L_UserArea",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserArea_D_User_FirstId",
                schema: "Links",
                table: "L_UserArea",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_D_Role_SecondId",
                schema: "Links",
                table: "L_UserRole",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_D_User_FirstId",
                schema: "Links",
                table: "L_UserRole",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_D_Skill_SecondId",
                schema: "Links",
                table: "L_UserSkill",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_D_User_FirstId",
                schema: "Links",
                table: "L_UserSkill",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_UserArea_D_Area_SecondId",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserArea_D_User_FirstId",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_D_Role_SecondId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_D_User_FirstId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_D_Skill_SecondId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_D_User_FirstId",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserArea_D_Area_FirstId",
                schema: "Links",
                table: "L_UserArea",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserArea_D_User_SecondId",
                schema: "Links",
                table: "L_UserArea",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_D_Role_FirstId",
                schema: "Links",
                table: "L_UserRole",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_D_User_SecondId",
                schema: "Links",
                table: "L_UserRole",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_D_Skill_FirstId",
                schema: "Links",
                table: "L_UserSkill",
                column: "FirstId",
                principalSchema: "Dimentions",
                principalTable: "D_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_D_User_SecondId",
                schema: "Links",
                table: "L_UserSkill",
                column: "SecondId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
