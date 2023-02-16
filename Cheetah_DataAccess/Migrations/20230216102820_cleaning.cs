using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cleaning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropIndex(
                name: "IX_S_Location_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropIndex(
                name: "IX_S_Location_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.CreateTable(
                name: "S_UserLocation",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ULUserLocationIdRecord = table.Column<long>(name: "UL_UserLocationIdRecord", type: "bigint", nullable: true),
                    ULRelatedUserLocationIdRecord = table.Column<long>(name: "UL_RelatedUserLocationIdRecord", type: "bigint", nullable: true),
                    SLocationIdRecord = table.Column<long>(name: "S_LocationIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UserLocation", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_Location_S_LocationIdRecord",
                        column: x => x.SLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_User_UL_RelatedUserLocationIdRecord",
                        column: x => x.ULRelatedUserLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserLocation_S_User_UL_UserLocationIdRecord",
                        column: x => x.ULUserLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_S_LocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "S_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_UL_RelatedUserLocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "UL_RelatedUserLocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserLocation_UL_UserLocationIdRecord",
                schema: "Systems",
                table: "S_UserLocation",
                column: "UL_UserLocationIdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_UserLocation",
                schema: "Systems");

            migrationBuilder.AddColumn<long>(
                name: "Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_Location_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "Locations_S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_Location_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "RelatedLocations_S_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_Locations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "Locations_S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_RelatedLocations_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "RelatedLocations_S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
