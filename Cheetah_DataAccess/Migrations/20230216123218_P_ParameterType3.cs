using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PParameterType3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_S_User_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Area_S_User_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropTable(
                name: "P_Person",
                schema: "Parameters");

            migrationBuilder.DropIndex(
                name: "IX_S_Area_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterList_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "RI_Inputuser1",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ProcessVar1",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ProcessVar2",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ProcessVar3",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ProcessVar4",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ProcessVar5",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.AddColumn<string>(
                name: "User_Address",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_RegistrationNumber",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(215)",
                maxLength: 215,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "S_UserArea",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URAreaIdRecord = table.Column<long>(name: "UR_AreaIdRecord", type: "bigint", nullable: true),
                    URUserIdRecord = table.Column<long>(name: "UR_UserIdRecord", type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_S_UserArea", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_S_UserArea_S_Area_UR_AreaIdRecord",
                        column: x => x.URAreaIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_Area",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_S_UserArea_S_User_UR_UserIdRecord",
                        column: x => x.URUserIdRecord,
                        principalSchema: "Systems",
                        principalTable: "S_User",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserArea_UR_AreaIdRecord",
                schema: "Systems",
                table: "S_UserArea",
                column: "UR_AreaIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_S_UserArea_UR_UserIdRecord",
                schema: "Systems",
                table: "S_UserArea",
                column: "UR_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_ListOfParameter_S_User_S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "S_UserIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_ListOfParameter_S_User_S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter");

            migrationBuilder.DropTable(
                name: "S_UserArea",
                schema: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_M_ListOfParameter_S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter");

            migrationBuilder.DropColumn(
                name: "User_Address",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_RegistrationNumber",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "S_UserIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter");

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Systems",
                table: "S_Area",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_Inputuser1",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ProcessVar1",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ProcessVar2",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ProcessVar3",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ProcessVar4",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ProcessVar5",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_Person",
                schema: "Parameters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseNum = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Person", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_Area_S_UserIdRecord",
                schema: "Systems",
                table: "S_Area",
                column: "S_UserIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "S_UserIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_S_User_S_UserIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "S_UserIdRecord",
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
        }
    }
}
