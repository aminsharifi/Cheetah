using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Locations_EndorsementItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 110);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Location_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Location_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropColumn(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location");
        }
    }
}
