using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ResetIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropIndex(
                name: "IX_F_UserGuide_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropColumn(
                name: "PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId",
                principalSchema: "Facts",
                principalTable: "F_PageTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.AddColumn<long>(
                name: "PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId1");

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId",
                principalSchema: "Facts",
                principalTable: "F_PageTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId1",
                principalSchema: "Facts",
                principalTable: "F_PageTable",
                principalColumn: "Id");
        }
    }
}
