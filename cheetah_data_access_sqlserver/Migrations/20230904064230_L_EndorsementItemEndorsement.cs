using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class L_EndorsementItemEndorsement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F_EndorsementSelector",
                schema: "Facts");

            migrationBuilder.CreateTable(
                name: "L_EndorsementItemEndorsement",
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
                    table.PrimaryKey("PK_L_EndorsementItemEndorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_EndorsementItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_Endorsement_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_CreateTimeRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_EnableRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_ERPCode",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_FirstId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_LastUpdatedRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_Name",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_SecondId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_EndorsementItemEndorsement",
                schema: "Links");

            migrationBuilder.CreateTable(
                name: "F_EndorsementSelector",
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
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementSelector", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementSelector_F_EndorsementItem_EndorsementItemId",
                        column: x => x.EndorsementItemId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementSelector_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_CreateTimeRecord",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_EnableRecord",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_EndorsementId",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_EndorsementItemId",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_ERPCode",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_LastUpdatedRecord",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementSelector_Name",
                schema: "Facts",
                table: "F_EndorsementSelector",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");
        }
    }
}
