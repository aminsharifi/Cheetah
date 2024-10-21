using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class cleanup3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Core",
                schema: "Dimentions",
                table: "D_User",
                newName: "Domain");

            migrationBuilder.AddColumn<long>(
                name: "ManagerId",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 111);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ManagerId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ManagerId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_ManagerId",
                schema: "Dimentions",
                table: "D_User",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_D_User_ManagerId",
                schema: "Dimentions",
                table: "D_User",
                column: "ManagerId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_User_D_User_ManagerId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropIndex(
                name: "IX_D_User_ManagerId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.RenameColumn(
                name: "Domain",
                schema: "Dimentions",
                table: "D_User",
                newName: "Core");
        }
    }
}
