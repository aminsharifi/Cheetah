using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_M_Approve_M_RequestInformation_M_RequestInformationIdRecord",
            //    schema: "Masters",
            //    table: "M_Approve");

            //migrationBuilder.DropIndex(
            //    name: "IX_M_Approve_M_RequestInformationIdRecord",
            //    schema: "Masters",
            //    table: "M_Approve");

            //migrationBuilder.DropColumn(
            //    name: "M_RequestInformationIdRecord",
            //    schema: "Masters",
            //    table: "M_Approve");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_M_RequestInformation_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "M_RequestInformationIdRecord",
                principalSchema: "Masters",
                principalTable: "M_RequestInformation",
                principalColumn: "IdRecord");
        }
    }
}
