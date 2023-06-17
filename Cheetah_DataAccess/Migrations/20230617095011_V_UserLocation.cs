using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class V_UserLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
          (
          @"
            IF Not EXISTS (SELECT name FROM sys.schemas WHERE name = N'Virtuals')
            EXEC('CREATE SCHEMA Virtuals')
            go
            DROP VIEW IF EXISTS [Virtuals].[V_UserLocation];
            go
            CREATE VIEW [Virtuals].[V_UserLocation]
            AS
            SELECT 
            cast((cast(UserId as varchar(50)) + cast(BranchId as varchar(50))) as bigint) as PERPCode,
            cast(UserId as bigint) FirstId, cast(BranchId as bigint) as SecondId, 0  DsblRecord
            FROM [192.168.10.66].[Alborz].[access].[GetUserBranchs_evw]
          "
          );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
