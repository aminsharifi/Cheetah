using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCopyROLEToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CopyROLE",
                table: "CopyROLE");

            migrationBuilder.RenameTable(
                name: "CopyROLE",
                newName: "CopyROLEs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CopyROLEs",
                table: "CopyROLEs",
                column: "idRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CopyROLEs",
                table: "CopyROLEs");

            migrationBuilder.RenameTable(
                name: "CopyROLEs",
                newName: "CopyROLE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CopyROLE",
                table: "CopyROLE",
                column: "idRole");
        }
    }
}
