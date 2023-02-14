using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MCommonCondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PSE_CompanySHare",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_ConditionDrug",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_ConditionFMCG",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Conditional",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Conditional2",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Conditional3",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Conditional4",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Conditional5",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_SupplierSHare",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "RI_AlborzSHare",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionDrug",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionFMCG",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionOccur1",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionOccur2",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionOccur3",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionOccur4",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ConditionOccur5",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_SupplierSHare",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.AddColumn<long>(
                name: "PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_CommonCondition",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCDConditional = table.Column<bool>(name: "CCD_Conditional", type: "bit", nullable: true),
                    CCDConditional2 = table.Column<bool>(name: "CCD_Conditional2", type: "bit", nullable: true),
                    CCDConditional3 = table.Column<bool>(name: "CCD_Conditional3", type: "bit", nullable: true),
                    CCDConditional4 = table.Column<bool>(name: "CCD_Conditional4", type: "bit", nullable: true),
                    CCDConditional5 = table.Column<bool>(name: "CCD_Conditional5", type: "bit", nullable: true),
                    CCDConditionDrug = table.Column<bool>(name: "CCD_ConditionDrug", type: "bit", nullable: true),
                    CCDConditionFMCG = table.Column<bool>(name: "CCD_ConditionFMCG", type: "bit", nullable: true),
                    CCDSupplierSHare = table.Column<bool>(name: "CCD_SupplierSHare", type: "bit", nullable: true),
                    CCDCompanySHare = table.Column<bool>(name: "CCD_CompanySHare", type: "bit", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CommonCondition", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_CommonConditionIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonConditionIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_M_CommonCondition_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonConditionIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonCondition",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_M_CommonCondition_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_CommonConditionIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonCondition",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CommonCondition_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_M_CommonCondition_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropTable(
                name: "M_CommonCondition",
                schema: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.AddColumn<bool>(
                name: "PSE_CompanySHare",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_ConditionDrug",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_ConditionFMCG",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Conditional",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Conditional2",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Conditional3",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Conditional4",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Conditional5",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_SupplierSHare",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_AlborzSHare",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionDrug",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionFMCG",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionOccur1",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionOccur2",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionOccur3",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionOccur4",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_ConditionOccur5",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_SupplierSHare",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);
        }
    }
}
