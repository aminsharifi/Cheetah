using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PSETaskName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PSE_TaskName",
                schema: "Parameters",
                table: "P_ProcessEndorsement");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PSE_TaskName",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
