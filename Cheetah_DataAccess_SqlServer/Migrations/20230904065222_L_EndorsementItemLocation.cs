using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class L_EndorsementItemLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "L_EndorsementItemLocation",
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
                    table.PrimaryKey("PK_L_EndorsementItemLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemLocation_F_EndorsementItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_CreateTimeRecord",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_EnableRecord",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_ERPCode",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_FirstId",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_LastUpdatedRecord",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_Name",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemLocation_SecondId",
                schema: "Links",
                table: "L_EndorsementItemLocation",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_EndorsementItemLocation",
                schema: "Links");
        }
    }
}
