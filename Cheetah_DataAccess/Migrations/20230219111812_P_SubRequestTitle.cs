using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PSubRequestTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PSE_SubRequestTitles",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_ValidOutput",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_ValidUserAction",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.AddColumn<long>(
                name: "PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_SubRequestTitleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_SubRequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_SubRequestTitle",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_SubRequestTitle_PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_SubRequestTitleIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.AddColumn<string>(
                name: "PSE_SubRequestTitles",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PSE_ValidOutput",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PSE_ValidUserAction",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
