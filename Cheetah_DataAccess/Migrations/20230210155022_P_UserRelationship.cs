using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PSE_UserRelationship",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.AddColumn<long>(
                name: "PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_UserRelationship",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_P_UserRelationship", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_UserRelationshipIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_UserRelationship_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_UserRelationshipIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserRelationship",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_UserRelationship_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropTable(
                name: "P_UserRelationship",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.AddColumn<long>(
                name: "PSE_UserRelationship",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                maxLength: 50,
                nullable: true);
        }
    }
}
