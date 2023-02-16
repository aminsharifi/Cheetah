using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PSE_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSE_Int_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_OperandIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "S_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_S_User_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_Operand_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_S_User_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_Operand_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterList_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "PSE_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_Int_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");
        }
    }
}
