using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CopyROLEs",
                columns: table => new
                {
                    idRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    guidRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CopyROLEs", x => x.idRole);
                });

            migrationBuilder.CreateTable(
                name: "P_ParameterType",
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
                    table.PrimaryKey("PK_P_ParameterType", x => x.IdRecord);
                });

            migrationBuilder.CreateTable(
                name: "CopyProducts",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CopyProducts", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_CopyProducts_CopyROLEs_idRole",
                        column: x => x.idRole,
                        principalTable: "CopyROLEs",
                        principalColumn: "idRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CopyProducts_idRole",
                table: "CopyProducts",
                column: "idRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CopyProducts");

            migrationBuilder.DropTable(
                name: "P_ParameterType");

            migrationBuilder.DropTable(
                name: "CopyROLEs");
        }
    }
}
