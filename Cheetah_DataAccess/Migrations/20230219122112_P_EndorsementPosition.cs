using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PEndorsementPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "P_EndorsementPosition",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UPProcessEndorsementIdRecord = table.Column<long>(name: "UP_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    UPPositionOrgIdRecord = table.Column<long>(name: "UP_PositionOrgIdRecord", type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_P_EndorsementPosition", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_P_EndorsementPosition_P_PositionOrg_UP_PositionOrgIdRecord",
                        column: x => x.UPPositionOrgIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_PositionOrg",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_P_EndorsementPosition_P_ProcessEndorsement_UP_ProcessEndorsementIdRecord",
                        column: x => x.UPProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_EndorsementPosition_UP_PositionOrgIdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                column: "UP_PositionOrgIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_EndorsementPosition_UP_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_EndorsementPosition",
                column: "UP_ProcessEndorsementIdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_EndorsementPosition",
                schema: "Parameters");
        }
    }
}
