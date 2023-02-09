using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ATC_Data",
                schema: "Masters",
                table: "M_Attachment");

            migrationBuilder.DropColumn(
                name: "ATC_Name",
                schema: "Masters",
                table: "M_Attachment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ATC_Data",
                schema: "Masters",
                table: "M_Attachment",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ATC_Name",
                schema: "Masters",
                table: "M_Attachment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
