using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Requestor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CheckValidation", "ColorId", "DisplayName", "ERPCode", "EnableRecord", "LastModified", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[] { -12L, null, null, "درخواست کننده", -12L, true, null, "Employees = Requestor", 1L, -12L, 7L, "Requestor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: -12L);
        }
    }
}
