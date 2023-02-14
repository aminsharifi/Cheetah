using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MAllApprove2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true);           

            migrationBuilder.CreateTable(
                name: "M_AllApprove",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentMApproveIdRecord = table.Column<long>(name: "Current_M_ApproveIdRecord", type: "bigint", nullable: true),
                    LastMApproveIdRecord = table.Column<long>(name: "Last_M_ApproveIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AllApprove", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_AllApprove_M_Approve_Current_M_ApproveIdRecord",
                        column: x => x.CurrentMApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_Approve",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_AllApprove_M_Approve_Last_M_ApproveIdRecord",
                        column: x => x.LastMApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_Approve",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_Approve_M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "M_AllApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_AllApprove_Current_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Current_M_ApproveIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_AllApprove_Last_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_AllApprove",
                column: "Last_M_ApproveIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve",
                column: "M_AllApproveIdRecord",
                principalSchema: "Masters",
                principalTable: "M_AllApprove",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_M_AllApprove_RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_AllApproveIdRecord",
                principalSchema: "Masters",
                principalTable: "M_AllApprove",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_Approve_M_AllApprove_M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_M_AllApprove_RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropTable(
                name: "M_AllApprove",
                schema: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropIndex(
                name: "IX_M_Approve_M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "RI_AllApproveIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "M_AllApproveIdRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PDescription",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PName",
                schema: "Masters",
                table: "M_Approve");
        }
    }
}
