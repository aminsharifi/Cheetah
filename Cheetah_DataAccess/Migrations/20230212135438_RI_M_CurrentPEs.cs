using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RIMCurrentPEs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_CurrentPE_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_CurrentPE_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                column: "M_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_CurrentPE_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropIndex(
                name: "IX_M_CurrentPE_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CurrentPE");
        }
    }
}
