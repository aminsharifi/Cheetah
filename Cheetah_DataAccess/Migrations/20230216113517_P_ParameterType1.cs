using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PParameterType1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.RenameColumn(
                name: "P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "PL_P_ParameterTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ParameterList_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "IX_P_ParameterList_PL_P_ParameterTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "PL_P_ParameterTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterType",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.RenameColumn(
                name: "PL_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "P_ParameterTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ParameterList_PL_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "IX_P_ParameterList_P_ParameterTypeIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ParameterTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");
        }
    }
}
