using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CWS_WSResult_Code",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "CWS_WSResult_Desc",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.AddColumn<bool>(
                name: "CPE_Active",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PCode",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<decimal>(
                name: "PCost",
                schema: "Masters",
                table: "M_CallWebService",
                type: "numeric(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PDescription",
                schema: "Masters",
                table: "M_CallWebService",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PERPCode",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PIndex",
                schema: "Masters",
                table: "M_CallWebService",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                schema: "Masters",
                table: "M_CallWebService",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPE_Active",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "PCode",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "PCost",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "PDescription",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "PERPCode",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "PIndex",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "PName",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.AddColumn<int>(
                name: "CWS_WSResult_Code",
                schema: "Masters",
                table: "M_CallWebService",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CWS_WSResult_Desc",
                schema: "Masters",
                table: "M_CallWebService",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);
        }
    }
}
