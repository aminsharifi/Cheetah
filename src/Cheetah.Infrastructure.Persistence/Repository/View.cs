namespace Cheetah.Infrastructure.Persistence.Repository;
public class View(ApplicationDbContext _db) : IView
{
    public async Task<Boolean> createViews()
    {
        #region V_UserLocation

        RemoveView("V_UserLocation");

        var V_UserLocation_Cmd2 = @"
            CREATE VIEW [Virtuals].[V_UserLocation]
            AS
            SELECT distinct
            cast((cast(UserId as varchar(50)) + cast(BranchId as varchar(50))) as bigint) as PERPCode,
            cast(UserId as bigint) FirstId, cast(BranchId as bigint) as SecondId, cast(0 as bit) EnableRecord
            FROM[192.168.10.66].[Alborz].[access].[GetUserBranchs_evw]
            ";

        _db.Database.ExecuteSqlRaw(V_UserLocation_Cmd2);
        #endregion

        #region V_UserPosition

        RemoveView("V_UserPosition");

        var V_UserPosition_Cmd2 = @"
            CREATE VIEW [Virtuals].[V_UserPosition]
            AS
            SELECT distinct
            cast((cast(Users.Id as varchar(50)) + cast(oj.Id as varchar(50))) as bigint) as PERPCode,
            cast(Users.Id as bigint) FirstId, cast(oj.Id as bigint) as SecondId,
            cast(iif(UR.EndDate > getdate(), 1, 0) as bit)  EnableRecord
            FROM
            [192.168.10.66].[Alborz].[access].[UserResponsibility] UR
            inner join[192.168.10.66].[Alborz].[dbo].[Users] on UR.UserId = Users.Id
            inner join[192.168.10.66].[Alborz].[dbo].[UserProfile] on UserProfile.UserId = Users.Id
            inner join[192.168.10.66].[Alborz].[access].[ChartPosition] cp on UR.positionid = cp.id
            inner join[192.168.10.66].[Alborz].access.ChartPost on ChartPost.Id = cp.PostId
            inner join[192.168.10.66].[Alborz].access.OrganizationJob oj on oj.Id = ChartPost.JobId
            where UR.EndDate > getdate() and UserProfile.FirstName is not null and UR.isenabled = 1
            ";
        _db.Database.ExecuteSqlRaw(V_UserPosition_Cmd2);
        #endregion

        #region V_Location

        RemoveView("V_Location");

        string V_Location_Cmd2 = @"                            
            CREATE VIEW [Virtuals].[V_Location]
            AS
            SELECT cast([Id] as bigint) PERPCode, cast([Id]
            as nvarchar(512)) as PName, [Name] as PDisplayName
            FROM [192.168.10.66].[Alborz].[Bizagi].[Branch]
            ";
        _db.Database.ExecuteSqlRaw(V_Location_Cmd2);
        #endregion

        #region V_Position

        RemoveView("V_Position");

        var V_Position_Cmd2 = @"
            CREATE VIEW [Virtuals].[V_Position]
            AS
            SELECT cast(oj.Id as bigint) PERPCode, cast(oj.Id as nvarchar(512)) as PName, oj.Title as PDisplayName
            FROM[192.168.10.66].[Alborz].access.OrganizationJob oj
            ";
        _db.Database.ExecuteSqlRaw(V_Position_Cmd2);
        #endregion

        #region V_User

        RemoveView("V_User");

        var V_User_Cmd2 = @"       
            CREATE VIEW [Virtuals].[V_User]
            AS
            SELECT
            CAST(Users.Id AS bigint) as PERPCode, Users.UserName PName, (FirstName + N' ' + LastName) PDisplayName,
            (
            SELECT top(1)
            PUsers.UserName
            FROM
            [192.168.10.66].[Alborz].[access].[UserResponsibility] UR
            left join[192.168.10.66].[Alborz].access.ChartPosition cp on UR.positionid = cp.id
            left join[192.168.10.66].[Alborz].[access].[UserResponsibility] Pur on cp.parentid = Pur.PositionId
            left join[192.168.10.66].[Alborz].[dbo].[Users] PUsers on Pur.UserId = PUsers.Id
            where Pur.EndDate > getdate() and UR.UserId = Users.Id
            )
            User_BossName,
            CAST((
            select top(1) iif(max(Dsbl_UR.EndDate) > getdate(), 1, 0)
            from[192.168.10.66].[Alborz].[access].[UserResponsibility] Dsbl_UR
            where Dsbl_UR.UserId = Users.Id
            ) as bit) EnableRecord
            FROM[192.168.10.66].[Alborz].[dbo].[UserProfile]
            left join[192.168.10.66].[Alborz].[dbo].[Users] on UserProfile.UserId = Users.Id
            where FirstName is not null
            ";
        _db.Database.ExecuteSqlRaw(V_User_Cmd2);
        #endregion

        return true;
    }
    public async Task<Boolean> RemoveView(string ViewName)
    {
        var DeleteQuery = $@"
            if exists(select 1 from sys.tables where name = '{ViewName}')
            DROP table [Virtuals].[{ViewName}]
            if exists(select 1 from sys.views where name = '{ViewName}')
            DROP view [Virtuals].[{ViewName}]
            ";
        _db.Database.ExecuteSqlRaw(DeleteQuery);
        return true;
    }
}