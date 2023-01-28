using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ParameterType : Migration
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
                name: "ParameterType",
                columns: table => new
                {
                    idParameterType = table.Column<long>(type: "bigint", nullable: false),
                    finalEnt = table.Column<int>(type: "int", nullable: true),
                    guidParameterType = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dsblParameterType = table.Column<bool>(type: "bit", nullable: false),
                    dplyParameterType = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: true),
                    Dsc = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterType", x => x.idParameterType);
                });

            migrationBuilder.CreateTable(
                name: "ParameterList",
                columns: table => new
                {
                    idParameterList = table.Column<long>(type: "bigint", nullable: false),
                    finalEnt = table.Column<int>(type: "int", nullable: true),
                    guidParameterList = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dsblParameterList = table.Column<bool>(type: "bit", nullable: false),
                    dplyParameterList = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: true),
                    ParameterType = table.Column<long>(type: "bigint", nullable: true),
                    PValue = table.Column<long>(type: "bigint", nullable: true),
                    CodeStr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: true),
                    Dsc = table.Column<string>(type: "ntext", nullable: false),
                    ParameterType1idParameterType = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterList", x => x.idParameterList);
                    table.ForeignKey(
                        name: "FK_ParameterList_ParameterType_ParameterType1idParameterType",
                        column: x => x.ParameterType1idParameterType,
                        principalTable: "ParameterType",
                        principalColumn: "idParameterType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterList_ParameterType1idParameterType",
                table: "ParameterList",
                column: "ParameterType1idParameterType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CopyROLEs");

            migrationBuilder.DropTable(
                name: "ParameterList");

            migrationBuilder.DropTable(
                name: "ParameterType");
        }
    }
}
