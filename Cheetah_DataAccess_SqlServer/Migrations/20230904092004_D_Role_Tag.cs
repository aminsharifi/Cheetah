using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class D_Role_Tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastUpdatedRecord", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 9, 4, 12, 50, 3, 475, DateTimeKind.Local).AddTicks(3122), "عددی", "موقعیت", 1L, true, new Guid("29d81f4b-8f6a-4348-9063-f01acee1d6b1"), null, "D_Location", 1L, 1L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
