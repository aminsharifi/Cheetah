using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class L_EndorsementItemUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_User_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.CreateTable(
                name: "L_EndorsementItemUser",
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
                    table.PrimaryKey("PK_L_EndorsementItemUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemUser_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemUser_F_EndorsementItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_CreateTimeRecord",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_EnableRecord",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_ERPCode",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_FirstId",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_LastUpdatedRecord",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_Name",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemUser_SecondId",
                schema: "Links",
                table: "L_EndorsementItemUser",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_EndorsementItemUser",
                schema: "Links");

            migrationBuilder.AddColumn<long>(
                name: "EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 111);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                column: "EndorsementItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_User",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }
    }
}
