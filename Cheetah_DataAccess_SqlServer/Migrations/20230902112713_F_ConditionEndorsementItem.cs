using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class F_ConditionEndorsementItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 109);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "EndorsementItemId",
                schema: "Facts",
                table: "F_Condition");
        }
    }
}
