using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ParameterList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "PL_ParameterTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "PL_ParameterTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterType",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterList_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");
        }
    }
}
