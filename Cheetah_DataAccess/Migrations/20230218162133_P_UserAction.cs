using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PUserAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CopyProducts");

            migrationBuilder.DropTable(
                name: "CopyROLEs");

            migrationBuilder.DropColumn(
                name: "UA_Abbreviation",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "UA_ValidActions",
                schema: "Parameters",
                table: "P_UserAction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UA_Abbreviation",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UA_ValidActions",
                schema: "Parameters",
                table: "P_UserAction",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CopyROLEs",
                columns: table => new
                {
                    idRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guidRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    roleName = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CopyROLEs", x => x.idRole);
                });

            migrationBuilder.CreateTable(
                name: "CopyProducts",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idRole = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
