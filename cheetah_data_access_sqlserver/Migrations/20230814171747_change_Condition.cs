using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class change_Condition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.RenameColumn(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_UserId");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.AddColumn<long>(
                name: "CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AddColumn<long>(
                name: "ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "ToEndorsementId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_User_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Endorsement_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "ToEndorsementId",
                principalSchema: "Facts",
                principalTable: "F_Endorsement",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Endorsement_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "D_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_D_UserId");

            migrationBuilder.AlterColumn<long>(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 108);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");
        }
    }
}
