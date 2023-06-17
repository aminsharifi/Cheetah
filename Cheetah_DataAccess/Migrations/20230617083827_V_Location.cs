using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class V_Location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                    IF Not EXISTS (SELECT name FROM sys.schemas WHERE name = N'Virtuals')
                    EXEC('CREATE SCHEMA Virtuals')
                    go
                    DROP VIEW IF EXISTS [Virtuals].[V_Location];
                    go
                    CREATE VIEW [Virtuals].[V_Location]
                    AS
	                SELECT cast([Id] as bigint) PERPCode, cast([Id] as nvarchar(512)) as PName, [Name] as PDisplayName
                    FROM [192.168.10.66].[Alborz].[Bizagi].[Branch]
                    "
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
