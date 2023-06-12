using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class V_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    IF Not EXISTS (SELECT name FROM sys.schemas WHERE name = N'Virtuals')
                                    EXEC('CREATE SCHEMA Virtuals')
                                    go
                                    DROP VIEW IF EXISTS [Virtuals].[V_User];
                                    go
                                    CREATE VIEW [Virtuals].[V_User]
                                    AS
                                    SELECT 
                                    CAST(Users.Id AS bigint) as PERPCode, Users.UserName PName, (FirstName + N' '+ LastName) PDisplayName,
                                    (
                                    SELECT top(1)
                                    PUsers.UserName
                                    FROM
                                    [192.168.10.66].[Alborz].[access].[UserResponsibility] UR	
                                    inner join [192.168.10.66].[Alborz].access.ChartPosition cp on UR.positionid =  cp.id	
                                    inner join [192.168.10.66].[Alborz].[access].[UserResponsibility] Pur on cp.parentid = Pur.PositionId
                                    inner join [192.168.10.66].[Alborz].[dbo].[Users] PUsers on Pur.UserId = PUsers.Id
                                    inner Pur.EndDate > getdate() and UR.UserId = Users.Id
                                    )
                                    User_BossName,
                                    CAST((
                                    select top(1) iif(max(Dsbl_UR.EndDate) < getdate(), 1,0) 
                                    from [192.168.10.66].[Alborz].[access].[UserResponsibility] Dsbl_UR
                                    where Dsbl_UR.UserId = Users.Id
                                    ) as bit) DsblRecord
                                    FROM [192.168.10.66].[Alborz].[dbo].[UserProfile]
                                    inner join [192.168.10.66].[Alborz].[dbo].[Users] on UserProfile.UserId = Users.Id
                                    where FirstName is not null
                                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"");
        }
    }
}
