using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_FieldType_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_Operand_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_Int_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_Bool_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Int_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "User_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_Int_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Bool_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSE_Int_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_OperandIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_FieldType_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_Operand_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");
        }
    }
}
