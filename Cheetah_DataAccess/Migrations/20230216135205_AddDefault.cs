using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_PositionOrg_S_User_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "M_CallWebService",
                schema: "Masters");

            migrationBuilder.DropTable(
                name: "S_OrgPosition",
                schema: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_P_PositionOrg_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "RI_WS_CurrentId",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_WS_Result",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_WS_Result_Code",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_WS_Result_Desc",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_WS_TryNum",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.RenameColumn(
                name: "User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "P_PositionOrgIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_P_PositionOrgIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "P_PositionOrgIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_PositionOrg",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_P_PositionOrg_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.RenameColumn(
                name: "P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "User_DefaultPositionIdRecord");

            migrationBuilder.RenameIndex(
                name: "IX_S_User_P_PositionOrgIdRecord",
                schema: "Systems",
                table: "S_User",
                newName: "IX_S_User_User_DefaultPositionIdRecord");

            migrationBuilder.AddColumn<long>(
                name: "PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_WS_CurrentId",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RI_WS_Result",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RI_WS_Result_Code",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_WS_Result_Desc",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RI_WS_TryNum",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_CallWebService",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CWSParameterListIdRecord = table.Column<long>(name: "CWS_ParameterListIdRecord", type: "bigint", nullable: true),
                    CWSJsonInputBody = table.Column<string>(name: "CWS_JsonInputBody", type: "ntext", nullable: true),
                    CWSURL = table.Column<string>(name: "CWS_URL", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CWSWSResult = table.Column<bool>(name: "CWS_WSResult", type: "bit", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MRequestInformationIdRecord = table.Column<long>(name: "M_RequestInformationIdRecord", type: "bigint", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CallWebService", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_CallWebService_M_RequestInformation_M_RequestInformationIdRecord",
                        column: x => x.MRequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_CallWebService_P_ParameterList_CWS_ParameterListIdRecord",
                        column: x => x.CWSParameterListIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterList",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateTable(
                name: "S_OrgPosition",
                schema: "Systems",
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
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    POSidOrg = table.Column<long>(name: "POS_idOrg", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_OrgPosition", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_PositionOrg_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_UsersIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_CWS_ParameterListIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "CWS_ParameterListIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_CallWebService_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_CallWebService",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_PositionOrg_S_User_PSO_UsersIdRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                column: "PSO_UsersIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_OrgPosition_User_DefaultPositionIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_DefaultPositionIdRecord",
                principalSchema: "Systems",
                principalTable: "S_OrgPosition",
                principalColumn: "IdRecord");
        }
    }
}
