using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExtra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UnitType_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_P_UserRelationship_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_Area_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_UnitType_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Area_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_Location_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "User_AreaIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_LocationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_LastTaskSentDate",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RI_LastTaskSentDate",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_UnitTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_idUnitTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LocationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserRelationshipIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UnitType_RI_idUnitTypeIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_idUnitTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UnitType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_P_UserRelationship_RI_UserRelationshipIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_UserRelationshipIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UserRelationship",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_Area_RI_AreaIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AreaIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_Location_RI_LocationIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_UnitType_User_P_UnitTypeIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_P_UnitTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_UnitType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Area_User_AreaIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_AreaIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Area",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_Location_User_LocationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_LocationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_Location",
                principalColumn: "IdRecord");
        }
    }
}
