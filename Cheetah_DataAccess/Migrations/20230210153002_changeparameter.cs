using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeparameter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterType_P_ParameterList_P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterType_P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "P_ParameterListIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterType_P_ParameterList_P_ParameterListIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "P_ParameterListIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord");
        }
    }
}
