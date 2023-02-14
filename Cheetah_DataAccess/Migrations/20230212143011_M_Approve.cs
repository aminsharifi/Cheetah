using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MApprove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
            name: "PCode",
            schema: "Masters",
            table: "M_Approve",
            type: "bigint",
            nullable: false,
            defaultValue: 0L);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Masters",
                table: "M_Approve",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_Approve",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PDescription",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PERPCode",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PIndex",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "PName",
                schema: "Masters",
                table: "M_Approve");
        }
    }
}
