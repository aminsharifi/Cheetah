using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class add_PageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_UserGuide",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");


            migrationBuilder.AddColumn<long>(
                name: "PageTableId",
                schema: "Facts",
                table: "F_UserGuide",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "F_PageTable",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Policy = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_PageTable", x => x.Id);
                },
                comment: "UserGuides for FAQ");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_PageTableId",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId");

            migrationBuilder.CreateIndex(
                name: "IX_F_UserGuide_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId1");

            migrationBuilder.CreateIndex(
                name: "IX_F_PageTable_Created",
                schema: "Facts",
                table: "F_PageTable",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_PageTable_EnableRecord",
                schema: "Facts",
                table: "F_PageTable",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_PageTable_ERPCode",
                schema: "Facts",
                table: "F_PageTable",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_PageTable_LastModified",
                schema: "Facts",
                table: "F_PageTable",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_PageTable_Name",
                schema: "Facts",
                table: "F_PageTable",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId",
                principalSchema: "Facts",
                principalTable: "F_PageTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide",
                column: "PageTableId1",
                principalSchema: "Facts",
                principalTable: "F_PageTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropForeignKey(
                name: "FK_F_UserGuide_F_PageTable_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropTable(
                name: "F_PageTable",
                schema: "Facts");

            migrationBuilder.DropIndex(
                name: "IX_F_UserGuide_PageTableId",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropIndex(
                name: "IX_F_UserGuide_PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropColumn(
                name: "PageTableId",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.DropColumn(
                name: "PageTableId1",
                schema: "Facts",
                table: "F_UserGuide");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Facts",
                table: "F_UserGuide",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                comment: "Additional description of each record",
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512,
                oldNullable: true,
                oldDefaultValue: "",
                oldComment: "Additional description of each record");

        }
    }
}
