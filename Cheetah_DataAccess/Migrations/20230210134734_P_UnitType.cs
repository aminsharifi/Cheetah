using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PUnitType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RI_idUnitType",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_idUnitTypeIdRecord");

            migrationBuilder.CreateTable(
                name: "P_UnitType",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UTKindID = table.Column<int>(name: "UT_KindID", type: "int", nullable: false),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UnitType", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_idUnitTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UnitType_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_idUnitTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UnitType",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UnitType_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropTable(
                name: "P_UnitType",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                newName: "RI_idUnitType");
        }
    }
}
