using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class DecoupleConditionsAndActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Endorsement_EndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Endorsement_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropTable(
                name: "L_TagEndorsement",
                schema: "Links");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_EndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "CaseStateId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "EndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "ToEndorsementId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "D_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_D_UserId");

            migrationBuilder.AddColumn<long>(
                name: "EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<long>(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 108);

            migrationBuilder.AddColumn<long>(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 111);

            migrationBuilder.CreateTable(
                name: "F_EndorsementItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_CaseStateId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EnableRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EndorsementId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_ERPCode",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_Name",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_User_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropTable(
                name: "F_EndorsementItem",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_F_Endorsement_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_User_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropColumn(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.RenameColumn(
                name: "D_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_UserId");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 108);

            migrationBuilder.AddColumn<long>(
                name: "CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 107);

            migrationBuilder.AddColumn<long>(
                name: "EndorsementId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AddColumn<long>(
                name: "ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 106);

            migrationBuilder.CreateTable(
                name: "L_TagEndorsement",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_TagEndorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TagEndorsement_D_Tag_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_TagEndorsement_F_Endorsement_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "ToEndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_CreateTimeRecord",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_EnableRecord",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_ERPCode",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_FirstId",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_LastUpdatedRecord",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_Name",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_TagEndorsement_SecondId",
                schema: "Links",
                table: "L_TagEndorsement",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_CaseState_CaseStateId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseStateId",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_D_User_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Endorsement_EndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementId",
                principalSchema: "Facts",
                principalTable: "F_Endorsement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Endorsement_ToEndorsementId",
                schema: "Facts",
                table: "F_Condition",
                column: "ToEndorsementId",
                principalSchema: "Facts",
                principalTable: "F_Endorsement",
                principalColumn: "Id");
        }
    }
}
