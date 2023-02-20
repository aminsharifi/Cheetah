using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PRequestTitleName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RT_ConditionOccur",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_ConditionOccur2",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_ConditionOccur3",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_ConditionOccur4",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_ConditionOccur5",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_OutputVar1",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_OutputVar2",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_OutputVar3",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_OutputVar4",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_OutputVar5",
                schema: "Parameters",
                table: "P_RequestTitle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RT_ConditionOccur",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_ConditionOccur2",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_ConditionOccur3",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_ConditionOccur4",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_ConditionOccur5",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_OutputVar1",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_OutputVar2",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_OutputVar3",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_OutputVar4",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RT_OutputVar5",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
