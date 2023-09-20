using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_condition_To_Scenario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                      name: "ConditionId",
                      schema: "Facts",
                      table: "F_Endorsement",
                      type: "bigint",
                      nullable: true)
                      .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ConditionId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_Condition_ConditionId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ConditionId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_Condition_ConditionId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropIndex(
                name: "IX_F_Endorsement_ConditionId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropColumn(
                name: "ConditionId",
                schema: "Facts",
                table: "F_Endorsement");            
        }
    }
}
