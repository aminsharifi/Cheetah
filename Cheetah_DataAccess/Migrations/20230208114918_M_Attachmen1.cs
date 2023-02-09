using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MAttachmen1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "M_Attachment",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ATCData = table.Column<byte>(name: "ATC_Data", type: "tinyint", nullable: true),
                    ATCName = table.Column<byte>(name: "ATC_Name", type: "tinyint", nullable: true),
                    CreateTimeRecord = table.Column<long>(type: "bigint", nullable: false),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdatedRecord = table.Column<long>(type: "bigint", nullable: false),
                    MApproveIdRecord = table.Column<long>(name: "M_ApproveIdRecord", type: "bigint", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Attachment", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_Attachment_M_Approve_M_ApproveIdRecord",
                        column: x => x.MApproveIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_Approve",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_Attachment_M_ApproveIdRecord",
                schema: "Masters",
                table: "M_Attachment",
                column: "M_ApproveIdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
