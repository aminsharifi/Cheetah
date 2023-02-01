using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddToDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "P_ParameterListIdRecord",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_ParameterList",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_P_ParameterList", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_P_ParameterListIdRecord",
                table: "P_ParameterType",
                column: "P_ParameterListIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterType_P_ParameterList_P_ParameterListIdRecord",
                table: "P_ParameterType",
                column: "P_ParameterListIdRecord",
                principalTable: "P_ParameterList",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterType_P_ParameterList_P_ParameterListIdRecord",
                table: "P_ParameterType");

            migrationBuilder.DropTable(
                name: "P_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterType_P_ParameterListIdRecord",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "P_ParameterListIdRecord",
                table: "P_ParameterType");
        }
    }
}
