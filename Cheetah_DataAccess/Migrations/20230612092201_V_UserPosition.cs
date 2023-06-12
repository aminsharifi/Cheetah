using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class V_UserPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    IF Not EXISTS (SELECT name FROM sys.schemas WHERE name = N'Virtuals')
                                    EXEC('CREATE SCHEMA Virtuals')
                                    go
                                    DROP VIEW IF EXISTS [Virtuals].[V_UserPosition];
                                    go
                                    CREATE VIEW [Virtuals].[V_UserPosition]
                                    AS
                                    SELECT
                                    cast((cast(UR.UserId as varchar(50)) + cast(oj.Id as varchar(50))) as bigint) as PERPCode,
                                    cast(UR.UserId as bigint) FirstId, cast(oj.Id as bigint) as SecondId,
                                    cast(iif( UR.EndDate < getdate() , 1,0) as bit)  DsblRecord
                                    FROM
                                    [192.168.10.66].[Alborz].[access].[UserResponsibility] UR
                                    left join [192.168.10.66].[Alborz].[access].[ChartPosition] cp on UR.positionid =  cp.id
                                    left join [192.168.10.66].[Alborz].access.ChartPost on ChartPost.Id = cp.PostId
                                    left join [192.168.10.66].[Alborz].access.OrganizationJob oj on oj.Id = ChartPost.JobId
                                    where UR.EndDate > getdate()
                                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) { }
    }
}
