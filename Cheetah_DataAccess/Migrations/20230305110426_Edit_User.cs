using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_FullName",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "User_UserName",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.AlterColumn<string>(
                name: "User_Domain",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User_Domain",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_FullName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 100);

            migrationBuilder.AddColumn<string>(
                name: "User_UserName",
                schema: "Dimentions",
                table: "D_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 101);
        }
    }
}
