using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class V_Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" IF Not EXISTS (SELECT name FROM sys.schemas WHERE name = N'Virtuals')
                                    EXEC('CREATE SCHEMA Virtuals')
                                    go
                                    DROP VIEW IF EXISTS [Virtuals].[V_Position];
                                    go
                                    CREATE VIEW [Virtuals].[V_Position]
                                    AS
	                                SELECT 
	                                oj.Id as PERPCode, NULL as PName, oj.Title as PDisplayName
	                                FROM [192.168.10.66].[Alborz].access.OrganizationJob oj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) 
        {
        }
    }
}