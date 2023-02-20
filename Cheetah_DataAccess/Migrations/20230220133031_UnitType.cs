using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UnitType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "S_UnitType",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_UnitType", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_Area_Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "Area_S_UnitTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Area_S_UnitType_Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "Area_S_UnitTypeIdRecord",
                principalSchema: "Systems",
                principalTable: "S_UnitType",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Area_S_UnitType_Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropTable(
                name: "S_UnitType",
                schema: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_S_Area_Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "Area_S_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_Area");
        }
    }
}
