using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RTPRequestTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropIndex(
                name: "IX_P_SubRequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.AddColumn<long>(
                name: "SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_RequestType_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                column: "SBT_RequestTitlesIdRecord");

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

            migrationBuilder.AddForeignKey(
                name: "FK_P_RequestType_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType",
                column: "SBT_RequestTitlesIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_RequestTitle_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_P_RequestType_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropIndex(
                name: "IX_P_RequestType_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropIndex(
                name: "IX_P_RequestTitle_P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "P_RequestTitleIdRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.AddColumn<long>(
                name: "SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_SubRequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "SBT_RequestTitlesIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_SubRequestTitle_P_RequestTitle_SBT_RequestTitlesIdRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                column: "SBT_RequestTitlesIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_RequestTitle",
                principalColumn: "IdRecord");
        }
    }
}
