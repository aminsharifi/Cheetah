using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_UserRelationship_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_Operand_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_UserRelationship_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Area_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Location_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_User_User_SecondApproverId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "P_UserRelationship",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_S_User_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_Int_P_FieldType",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_DistrictManager_RelatedL",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_Enabled",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_RelatedLocation",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_SubUsers",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "PSE_UserRelationshipIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.RenameColumn(
                name: "User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_P_OperandIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_SecondApproverId",
                schema: "Systems",
                table: "S_User",
                newName: "User_P_FieldTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_IsNeedUpperApprove",
                schema: "Systems",
                table: "S_User",
                newName: "User_Bool_P_FieldType");

            migrationBuilder.RenameColumn(
                name: "User_FirstApproverId",
                schema: "Systems",
                table: "S_User",
                newName: "User_Int_P_FieldType");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_P_OperandIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_SecondApproverId",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_P_FieldTypeIdRecord");

            migrationBuilder.RenameColumn(
                name: "PSE_Active",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_NeedApprove");

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSO_Independent_Location",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_Location_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_Location_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord1");

            migrationBuilder.CreateIndex(
                name: "IX_S_Area_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Default_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_UsersIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_S_Location_PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_Default_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_S_User_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_UsersIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Area_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location",
                column: "S_UserIdRecord1",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_FieldType_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_Operand_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_Location_PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_User_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Area_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Location_S_User_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_FieldType_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_Operand_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_Location_S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropIndex(
                name: "IX_S_Location_S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropIndex(
                name: "IX_S_Area_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord1",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "PSO_Default_LocationIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_Independent_Location",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.RenameColumn(
                name: "User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_UserRelationshipIdRecord");

            migrationBuilder.RenameColumn(
                name: "User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_SecondApproverId");

            migrationBuilder.RenameColumn(
                name: "User_Int_P_FieldType",
                schema: "Systems",
                table: "S_User",
                newName: "User_FirstApproverId");

            migrationBuilder.RenameColumn(
                name: "User_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User",
                newName: "User_IsNeedUpperApprove");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_UserRelationshipIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_SecondApproverId");

            migrationBuilder.RenameColumn(
                name: "PSE_NeedApprove",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                newName: "PSE_Active");

            migrationBuilder.AddColumn<long>(
                name: "CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PSE_Bool_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PSE_Int_P_FieldType",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_DistrictManager_RelatedL",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "User_Enabled",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_RelatedLocation",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_SubUsers",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

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
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_UserRelationship", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_User_CMA_S_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "CMA_S_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_CMA_S_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "CMA_S_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_OperandIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User",
                column: "User_FirstApproverId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_Operand_PT_P_OperandIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "PT_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_UserRelationship_User_UserRelationshipIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_UserRelationshipIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserRelationship",
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

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_FirstApproverId",
                schema: "Systems",
                table: "S_User",
                column: "User_FirstApproverId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_User_User_SecondApproverId",
                schema: "Systems",
                table: "S_User",
                column: "User_SecondApproverId",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }
    }
}
