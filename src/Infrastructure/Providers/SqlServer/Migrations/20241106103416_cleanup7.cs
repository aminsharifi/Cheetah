using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class cleanup7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F_UserGuides");

            migrationBuilder.CreateTable(
                name: "F_UserGuide",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Subject = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserGuide", x => x.Id);
                },
                comment: "UserGuides for FAQ");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_Created",
                schema: "Facts",
                table: "F_UserGuide",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_EnableRecord",
                schema: "Facts",
                table: "F_UserGuide",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_ERPCode",
                schema: "Facts",
                table: "F_UserGuide",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_LastModified",
                schema: "Facts",
                table: "F_UserGuide",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_Name",
                schema: "Facts",
                table: "F_UserGuide",
                column: "Name",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F_UserGuide",
                schema: "Facts");

            migrationBuilder.CreateTable(
                name: "F_UserGuides",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_UserGuides", x => x.Id);
                },
                comment: "UserGuides for FAQ");
        }
    }
}
