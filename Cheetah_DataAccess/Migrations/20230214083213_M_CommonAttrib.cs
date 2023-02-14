using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MCommonAttrib : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_CommonAttrib",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CMASAreaIdRecord = table.Column<long>(name: "CMA_S_AreaIdRecord", type: "bigint", nullable: true),
                    CMASLocationIdRecord = table.Column<long>(name: "CMA_S_LocationIdRecord", type: "bigint", nullable: true),
                    CMAPUnitTypeIdRecord = table.Column<long>(name: "CMA_P_UnitTypeIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CommonAttrib", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_CommonAttrib_P_UnitType_CMA_P_UnitTypeIdRecord",
                        column: x => x.CMAPUnitTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_UnitType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CommonAttrib_S_Area_CMA_S_AreaIdRecord",
                        column: x => x.CMASAreaIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CommonAttrib_S_Location_CMA_S_LocationIdRecord",
                        column: x => x.CMASLocationIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Location",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_CommonAttribIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonAttribIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CommonAttrib_CMA_P_UnitTypeIdRecord",
                schema: "Masters",
                table: "M_CommonAttrib",
                column: "CMA_P_UnitTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CommonAttrib_CMA_S_AreaIdRecord",
                schema: "Masters",
                table: "M_CommonAttrib",
                column: "CMA_S_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CommonAttrib_CMA_S_LocationIdRecord",
                schema: "Masters",
                table: "M_CommonAttrib",
                column: "CMA_S_LocationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_M_CommonAttrib_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonAttribIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonAttrib",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_M_CommonAttrib_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_CommonAttribIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonAttrib",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CommonAttrib_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_M_CommonAttrib_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "M_CommonAttrib",
                schema: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");
        }
    }
}
