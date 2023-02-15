using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeApproval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CommonAttrib_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_CommonCondition_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_M_CommonCondition_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrg_PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_M_CommonAttrib_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "M_CommonAttrib",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "M_CommonCondition",
                schema: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "CMA_S_LocationIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_CommonAttribIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_CMA_S_LocationIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PT_P_OperandIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PT_P_FieldTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PT_P_OperandIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PT_P_FieldTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "P_ProcessEndorsementIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ParameterList_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "IX_P_ParameterList_P_ProcessEndorsementIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Bool_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSE_Int_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_FieldType",
                schema: "Parameters",
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
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_FieldType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "P_Operand",
                schema: "Parameters",
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
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Operand", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_User_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "CMA_S_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ParameterTypeIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ParameterTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "P_ProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_Operand_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Area_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "CMA_S_AreaIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Location_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "CMA_S_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_Operand_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Area_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Location_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "P_FieldType",
                schema: "Parameters");

            migrationBuilder.DropTable(
                name: "P_Operand",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_S_User_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterList_P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_Bool_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_Int_P_FieldType",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "P_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.RenameColumn(
                name: "CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_CommonAttribIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_CommonAttribIdRecord");

            migrationBuilder.RenameColumn(
                name: "PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_PONIdRecord");

            migrationBuilder.RenameColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_CommonConditionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_PONIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ProcessEndorsement_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "IX_P_ProcessEndorsement_PSE_CommonConditionIdRecord");

            migrationBuilder.RenameColumn(
                name: "P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "PL_ParameterTypeIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_P_ParameterList_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                newName: "IX_P_ParameterList_PL_ParameterTypeIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_CommonConditionIdRecord",
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
                    CMAPUnitTypeIdRecord = table.Column<long>(name: "CMA_P_UnitTypeIdRecord", type: "bigint", nullable: true),
                    CMASAreaIdRecord = table.Column<long>(name: "CMA_S_AreaIdRecord", type: "bigint", nullable: true),
                    CMASLocationIdRecord = table.Column<long>(name: "CMA_S_LocationIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "M_CommonCondition",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCDCompanySHare = table.Column<bool>(name: "CCD_CompanySHare", type: "bit", nullable: true),
                    CCDConditionDrug = table.Column<bool>(name: "CCD_ConditionDrug", type: "bit", nullable: true),
                    CCDConditionFMCG = table.Column<bool>(name: "CCD_ConditionFMCG", type: "bit", nullable: true),
                    CCDConditional = table.Column<bool>(name: "CCD_Conditional", type: "bit", nullable: true),
                    CCDConditional2 = table.Column<bool>(name: "CCD_Conditional2", type: "bit", nullable: true),
                    CCDConditional3 = table.Column<bool>(name: "CCD_Conditional3", type: "bit", nullable: true),
                    CCDConditional4 = table.Column<bool>(name: "CCD_Conditional4", type: "bit", nullable: true),
                    CCDConditional5 = table.Column<bool>(name: "CCD_Conditional5", type: "bit", nullable: true),
                    CCDSupplierSHare = table.Column<bool>(name: "CCD_SupplierSHare", type: "bit", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CommonCondition", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_CommonAttribIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonAttribIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonConditionIdRecord");

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
                name: "FK_M_RequestInformation_M_CommonCondition_RI_CommonConditionIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_CommonConditionIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonCondition",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ParameterType_PL_ParameterTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "PL_ParameterTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ParameterType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_M_CommonCondition_PSE_CommonConditionIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_CommonConditionIdRecord",
                principalSchema: "Masters",
                principalTable: "M_CommonCondition",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_PositionOrg_PSE_PONIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PSE_PONIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
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
    }
}
