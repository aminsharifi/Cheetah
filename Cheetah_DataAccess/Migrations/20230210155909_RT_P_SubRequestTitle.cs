using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RTPSubRequestTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_RequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.AddColumn<long>(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_SubRequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "P_RequestTitleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "P_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_P_SubRequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.AddColumn<long>(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                column: "P_RequestTitleIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_RequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                column: "P_RequestTitleIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }
    }
}
