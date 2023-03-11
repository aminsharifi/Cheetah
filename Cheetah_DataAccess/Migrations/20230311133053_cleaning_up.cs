using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cleaningup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_RolePosition_L_RolePosition_Parent_Id",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserArea_L_UserArea_Parent_Id",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserLocation_L_UserLocation_Parent_Id",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRelatedLocation_L_UserRelatedLocation_Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_L_UserRole_Parent_Id",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserSkill_L_UserSkill_Parent_Id",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_L_UserSkill_Parent_Id",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_L_UserRole_Parent_Id",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_L_UserRelatedLocation_Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_UserLocation_Parent_Id",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_UserArea_Parent_Id",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropIndex(
                name: "IX_L_RolePosition_Parent_Id",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserSkill");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserArea");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Links",
                table: "L_RolePosition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserSkill",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserRole",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_UserArea",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserSkill_Parent_Id",
                schema: "Links",
                table: "L_UserSkill",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_Parent_Id",
                schema: "Links",
                table: "L_UserRole",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRelatedLocation_Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Parent_Id",
                schema: "Links",
                table: "L_UserLocation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserArea_Parent_Id",
                schema: "Links",
                table: "L_UserArea",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_Parent_Id",
                schema: "Links",
                table: "L_RolePosition",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_L_RolePosition_L_RolePosition_Parent_Id",
                schema: "Links",
                table: "L_RolePosition",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_RolePosition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserArea_L_UserArea_Parent_Id",
                schema: "Links",
                table: "L_UserArea",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_UserArea",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserLocation_L_UserLocation_Parent_Id",
                schema: "Links",
                table: "L_UserLocation",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_UserLocation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRelatedLocation_L_UserRelatedLocation_Parent_Id",
                schema: "Links",
                table: "L_UserRelatedLocation",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_UserRelatedLocation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_L_UserRole_Parent_Id",
                schema: "Links",
                table: "L_UserRole",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_UserRole",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserSkill_L_UserSkill_Parent_Id",
                schema: "Links",
                table: "L_UserSkill",
                column: "Parent_Id",
                principalSchema: "Links",
                principalTable: "L_UserSkill",
                principalColumn: "Id");
        }
    }
}
