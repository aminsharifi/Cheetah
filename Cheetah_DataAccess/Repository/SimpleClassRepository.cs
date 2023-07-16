using AutoMapper;
using Azure.Core;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Cheetah_Business.Repository;
using Cheetah_Business.Virtuals;
using Cheetah_DataAccess.Data;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah_DataAccess.Repository;

public class SimpleClassRepository : ISimpleClassRepository
{
    protected ApplicationDbContext _db;
    protected IMapper _mapper;
    public SimpleClassRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
        CreateViews();
    }
    private void RemoveView(string ViewName)
    {
        var DeleteQuery = $@"
            if exists(select 1 from sys.tables where name = '{ViewName}')
            DROP table [Virtuals].[{ViewName}]
            if exists(select 1 from sys.views where name = '{ViewName}')
            DROP view [Virtuals].[{ViewName}]
        ";
        _db.Database.ExecuteSqlRaw(DeleteQuery);
    }
    private void CreateViews()
    {
        #region V_UserLocation

        RemoveView("V_UserLocation");

        var V_UserLocation_Cmd2 = @"
            CREATE VIEW [Virtuals].[V_UserLocation]
            AS
            SELECT distinct
            cast((cast(UserId as varchar(50)) + cast(BranchId as varchar(50))) as bigint) as PERPCode,
            cast(UserId as bigint) FirstId, cast(BranchId as bigint) as SecondId, cast(0 as bit) DsblRecord
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
            cast(iif(UR.EndDate < getdate(), 1, 0) as bit)  DsblRecord
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
            select top(1) iif(max(Dsbl_UR.EndDate) < getdate(), 1, 0)
            from[192.168.10.66].[Alborz].[access].[UserResponsibility] Dsbl_UR
            where Dsbl_UR.UserId = Users.Id
            ) as bit) DsblRecord
            FROM[192.168.10.66].[Alborz].[dbo].[UserProfile]
            left join[192.168.10.66].[Alborz].[dbo].[Users] on UserProfile.UserId = Users.Id
            where FirstName is not null
            ";
        _db.Database.ExecuteSqlRaw(V_User_Cmd2);
        #endregion



    }
    public async Task<Int32> AddLink(SimpleLinkClassDTO obj_DTO)
    {
        await _db.AddAsync(obj_DTO);

        return 1;
    }
    public async Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
    {
        simpleLinkClass.DisplayName = new StringBuilder()
                 .Append(firstClass?.DisplayName ?? String.Empty)
                 .Append("-")
                 .Append(SecondClass?.DisplayName ?? String.Empty)
                 .ToString();

        simpleLinkClass.Name = new StringBuilder()
                          .Append(firstClass?.Name ?? String.Empty)
                          .Append("-")
                          .Append(SecondClass?.Name ?? String.Empty)
                          .ToString();
        return simpleLinkClass;
    }
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions)
    {
        var cnt_con = Expected_Conditions.Count();

        var ConditionOccur = 0;

        for (int i = 0; i < cnt_con; i++)
        {
            var Condition = Expected_Conditions.ToArray()[i];

            if (Actual_Conditions.Any(x => x.Tag.Name == Condition.Tag.Name))
            {
                var Scenario_Value = float.Parse(Condition.Value);
                var Current_Value = float.Parse(Actual_Conditions
                    .Single(x => x.Tag.Name == Condition.Tag.Name).Value);

                var Operand_Name = Condition.Operand.Name;

                if (
                       (Operand_Name == ">" && Current_Value > Scenario_Value)
                    || (Operand_Name == ">=" && Current_Value >= Scenario_Value)
                    || (Operand_Name == "<" && Current_Value < Scenario_Value)
                    || (Operand_Name == "<=" && Current_Value <= Scenario_Value)
                    || (Operand_Name == "=" && Current_Value == Scenario_Value)
                    || (Operand_Name == "!=" && Current_Value != Scenario_Value)
                    )
                {
                    ConditionOccur++;
                }
            }
        }
        return (ConditionOccur == cnt_con);
    }
    public async Task<F_Case> SetInboxAndFuture(F_Case? f_Case, Int64? SortIndex)
    {
        f_Case.WorkItems.Where(x => x.Endorsement.SortIndex == (SortIndex + 1))
            .ToList().ForEach(x => x.WorkItemStateId = 1); // Inbox

        f_Case.WorkItems.Where(x => x.Endorsement.SortIndex > (SortIndex + 1))
            .ToList().ForEach(x => x.WorkItemStateId = 4); // Future

        return f_Case;
    }
    public async Task<F_Case> Exit(F_Case? f_Case, Int64? SortIndex)
    {
        f_Case.WorkItems.Where(x => x.Tag is null && x.Endorsement.SortIndex >= SortIndex)
                     .ToList().ForEach(x => x.WorkItemStateId = 3); // Exit

        return f_Case;
    }
    public async Task<F_Case> SetCurrentAssignment(F_WorkItem? f_WorkItem)
    {
        long EndorsementSortIndex = 0;

        if (f_WorkItem.Endorsement is not null)
        {
            EndorsementSortIndex = f_WorkItem.Endorsement.SortIndex.Value;
        }

        Exit(f_WorkItem.Case, EndorsementSortIndex).GetAwaiter().GetResult();

        if (f_WorkItem.IsRevise())
        {
            f_WorkItem.Case.SetEditing();
            f_WorkItem.Case = SetWorkItemsAsync(f_WorkItem.Case).GetAwaiter().GetResult();

        }
        else if (f_WorkItem.IsReject())
        {
            f_WorkItem.Case.SetAborted();
        }
        else if (f_WorkItem.IsApprove())
        {
            f_WorkItem.Case.SetOngoing();

            f_WorkItem.Case = SetInboxAndFuture(f_WorkItem.Case, EndorsementSortIndex).GetAwaiter().GetResult();

            if (!f_WorkItem.Case.WorkItems.Any(x => x.IsInbox()))
            {
                f_WorkItem.Case.SetCompleted();
            }
        }

        _db.UpdateRange(f_WorkItem);

        await _db.SaveChangesAsync();

        return f_WorkItem.Case;
    }
    public async Task<D_User> GetUser(String PName)
    {
        var Cheetah_User = _db.D_Users.Where(x => x.Name == PName);

        var ERP_User = _db.V_Users.Where(x => x.PName == PName);

        D_User SelectedUser = new D_User();

        if (!await Cheetah_User.AnyAsync())
        {
            var v_Creator = await ERP_User.SingleAsync();

            var D_Creator = new D_User()
            {
                ERPCode = v_Creator.PERPCode,
                Name = v_Creator.PName,
                DisplayName = v_Creator.PDisplayName,
                DsblRecord = v_Creator.DsblRecord,
                LastUpdatedRecord = DateTime.Now
            };

            if (!String.IsNullOrEmpty(v_Creator.User_BossName) && v_Creator.User_BossName != v_Creator.PName)
            {
                D_Creator.Parent = await GetUser(v_Creator.User_BossName);
            }

            await _db.D_Users.AddAsync(D_Creator);

            SelectedUser = D_Creator;

            await _db.SaveChangesAsync();
        }
        else
        {
            var D_Creator = await Cheetah_User.SingleAsync();

            if (D_Creator.LastUpdatedRecord < DateTime.Now.AddMinutes(-10))
            {
                var v_Creator = await ERP_User.SingleAsync();

                var changed = false;

                if (D_Creator.DisplayName != v_Creator.PDisplayName)
                {
                    D_Creator.DisplayName = v_Creator.PDisplayName;
                    changed = true;
                }

                if (D_Creator.DsblRecord != v_Creator.DsblRecord)
                {
                    D_Creator.DsblRecord = v_Creator.DsblRecord;
                    changed = true;
                }

                if (!String.IsNullOrEmpty(v_Creator.User_BossName) && v_Creator.User_BossName != v_Creator.PName)
                {
                    if (D_Creator.Parent is null || D_Creator.Parent?.Name != v_Creator.User_BossName)
                    {
                        D_Creator.Parent = await GetUser(v_Creator.User_BossName);

                        changed = true;
                    }
                }

                D_Creator.LastUpdatedRecord = DateTime.Now;

                if (changed)
                {
                    await _db.SaveChangesAsync();
                }
            }
            SelectedUser = D_Creator;
        }

        return SelectedUser;
    }
    public async Task<Boolean> SyncUser()
    {
        var Users = await _db.V_Users.ToListAsync();

        foreach (var item in Users)
        {
            await GetUser(item.PName);
        }

        return true;
    }
    public async Task<D_Position> GetPosition(String PName)
    {
        var V_Positions = _db.V_Positions.Where(x => x.PName == PName);
        var D_Positions = _db.D_Positions.Where(x => x.Name == PName);
        var v_Position = await V_Positions.SingleAsync();
        var d_Position = new D_Position();

        if (!await D_Positions.AnyAsync())
        {
            d_Position = new D_Position()
            {
                ERPCode = v_Position.PERPCode,
                Name = v_Position.PName,
                DisplayName = v_Position.PDisplayName,
                LastUpdatedRecord = DateTime.Now
            };

            await _db.D_Positions.AddAsync(d_Position);
        }
        else
        {
            d_Position = await D_Positions.SingleAsync();
            d_Position.Name = v_Position.PName;
            d_Position.DisplayName = v_Position.PDisplayName;
        }
        await _db.SaveChangesAsync();

        return d_Position;
    }
    public async Task<Boolean> SyncPosition()
    {
        var V_Positions = await _db.V_Positions.ToListAsync();

        foreach (var item in V_Positions)
        {
            await GetPosition(item.PName);
        }

        return true;
    }
    public async Task<D_Location> GetLocation(String PName)
    {
        var V_Locations = _db.V_Locations.Where(x => x.PName == PName);
        var D_Locations = _db.D_Locations.Where(x => x.Name == PName);
        var V_Location = await V_Locations.SingleAsync();
        var d_Location = new D_Location();

        if (!await D_Locations.AnyAsync())
        {
            d_Location = new D_Location()
            {
                ERPCode = V_Location.PERPCode,
                Name = V_Location.PName,
                DisplayName = V_Location.PDisplayName,
                LastUpdatedRecord = DateTime.Now
            };

            await _db.D_Locations.AddAsync(d_Location);
        }
        else
        {
            d_Location = await D_Locations.SingleAsync();
            d_Location.Name = V_Location.PName;
            d_Location.DisplayName = V_Location.PDisplayName;
        }
        await _db.SaveChangesAsync();

        return d_Location;
    }
    public async Task<Boolean> SyncLocation()
    {
        var v_Locations = await _db.V_Locations.ToListAsync();

        foreach (var item in v_Locations)
        {
            await GetLocation(item.PName);
        }

        return true;
    }
    public async Task<Boolean> Sync_UserPosition()
    {
        var d_Users = await _db.D_Users.ToListAsync();
        var d_Positions = await _db.D_Positions.ToListAsync();
        var v_UserPositions = await _db.V_UserPositions.ToListAsync();

        foreach (var item in v_UserPositions)
        {
            var users = d_Users.Where(x => x.ERPCode == item.FirstId);
            var positions = d_Positions.Where(x => x.ERPCode == item.SecondId);

            var MustAdd = true;

            if (!users.Any())
            {
                MustAdd = false;
            }

            if (!positions.Any())
            {
                MustAdd = false;
            }
            if (MustAdd)
            {
                var user = users.Single();
                var position = positions.Single();

                MustAdd = !await _db.L_UserPositions.AnyAsync(x => x.FirstId == user.Id && x.SecondId == position.Id);

                if (MustAdd)
                {
                    var l_UserPosition = new L_UserPosition()
                    {
                        FirstId = user.Id,
                        SecondId = position.Id,
                        Name = user.Name + "-" + position.Name,
                        DisplayName = user.DisplayName + "-" + position.DisplayName,
                        DsblRecord = item.DsblRecord,
                        LastUpdatedRecord = DateTime.Now
                    };
                    await _db.L_UserPositions.AddAsync(l_UserPosition);
                }
            }
        }

        await _db.SaveChangesAsync();

        return true;
    }
    public async Task<Boolean> Sync_UserLocation()
    {
        var d_Users = await _db.D_Users.ToListAsync();
        var d_Locations = await _db.D_Locations.ToListAsync();
        var v_UserLocations = await _db.V_UserLocations
            .ToListAsync();

        foreach (var item in v_UserLocations)
        {
            var d_User = d_Users.Where(x => x.ERPCode == item.FirstId);
            var d_Location = d_Locations.Where(x => x.ERPCode == item.SecondId);

            var MustAdd = true;

            if (!d_User.Any())
            {
                MustAdd = false;
            }
            if (!d_Location.Any())
            {
                MustAdd = false;
            }

            if (MustAdd)
            {
                var user = d_User.Single();

                var location = d_Location.Single();

                MustAdd = !await _db.L_UserLocations.AnyAsync(x => x.FirstId == user.Id && x.SecondId == location.Id);

                if (MustAdd)
                {
                    var l_UserLocation = new L_UserLocation()
                    {
                        FirstId = user.Id,
                        SecondId = location.Id,
                        Name = user.Name + "-" + location.Name,
                        DisplayName = user.DisplayName + "-" + location.DisplayName,
                        DsblRecord = item.DsblRecord,
                        LastUpdatedRecord = DateTime.Now
                    };
                    await _db.L_UserLocations.AddAsync(l_UserLocation);
                }
            }
        }

        await _db.SaveChangesAsync();

        return true;
    }
    public async Task<F_Case> SetWorkItemsAsync(F_Case GeneralRequest)
    {
        try
        {
            if (GeneralRequest.Conditions is not null
                && GeneralRequest.Conditions.Count > 0)
            {
                foreach (var item in GeneralRequest.Conditions)
                {
                    item.Id = null;
                    item.Tag = await _db.D_Tags.SingleAsync(x => x.Name == item.Tag.Name);
                }
            }

            var pc_ProcessScenario = GeneralRequest.Process?.ProcessScenario;

            foreach (var ProcessScenario in pc_ProcessScenario)
            {
                var ConditionOccures = false;

                if (GeneralRequest.Conditions is null || GeneralRequest.Conditions.Count() == 0)
                {
                    ConditionOccures = true;
                }
                else
                {
                    var Actual_Conditions = GeneralRequest.Conditions.ToList();

                    var Expected_Conditions = ProcessScenario.Scenario.Conditions.ToList();

                    ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions);
                }
                if (ConditionOccures)
                {
                    GeneralRequest.SelectedScenario = ProcessScenario.Scenario;
                    break;
                }
            }

            if (GeneralRequest.WorkItems is null || GeneralRequest.WorkItems.Count() == 0)
            {
                GeneralRequest.WorkItems = new HashSet<F_WorkItem>();
            }

            var eP_Endorsements = GeneralRequest.SelectedScenario?.Endorsements.ToList();

            foreach (var eP_Endorsement in eP_Endorsements)
            {
                if (eP_Endorsement.Role.FixedRole)
                {
                    F_WorkItem f_WorkItem = new()
                    {
                        EndorsementId = eP_Endorsement.Id
                    };

                    if (eP_Endorsement.IsRequestor())
                    {
                        f_WorkItem.UserId = GeneralRequest.RequestorId;
                    }
                    else if (eP_Endorsement.IsRequestorManager())
                    {
                        f_WorkItem.UserId = GeneralRequest.Requestor.Parent_Id;
                    }

                    GeneralRequest.WorkItems.Add(f_WorkItem);
                }
                else
                {
                    if (CompareCondition(GeneralRequest.Conditions, eP_Endorsement.Conditions))
                    {
                        var Positions = await _db.L_RolePositions.Where(x => x.FirstId == eP_Endorsement.RoleId).Select(x => x.SecondId).ToListAsync();

                        var Users = await _db.L_UserPositions.Where(x => Positions.Contains(x.SecondId)).Select(x => x.FirstId).ToListAsync();

                        var D_Users = await _db.D_Users.Where(x => Users.Contains(x.Id)).ToListAsync();

                        foreach (var D_User in D_Users)
                        {
                            var UserOccur = false;

                            if (eP_Endorsement.Role.Independent)
                            {
                                UserOccur = true;
                            }
                            else
                            {
                                var userLocations = GeneralRequest.Requestor.UserLocations.Select(x => x.SecondId).ToList();

                                if (D_User.UserLocations.Any(x => userLocations.Contains(x.SecondId)))
                                {
                                    UserOccur = true;
                                }
                            }
                            if (UserOccur)
                            {
                                F_WorkItem f_WorkItem = new()
                                {
                                    EndorsementId = eP_Endorsement.Id,
                                    UserId = D_User.Id
                                };

                                GeneralRequest.WorkItems.Add(f_WorkItem);
                            }
                        }
                    }
                }
            }

            var request = await SetCurrentAssignment(GeneralRequest.WorkItems.First());            

            var tmp = _db.Update(GeneralRequest);

            await _db.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw;
        }

        var ret_Requests = await _db.F_Cases
            .Include(x => x.CaseState)
            .SingleAsync(x => x.Id == GeneralRequest.Id);

        return ret_Requests;
    }
    public async Task<F_Case> CreateRequestAsync(F_Case request)
    {
        F_Case GeneralRequest = request;

        try
        {
            GeneralRequest.Creator = await GetUser(request.Creator.Name);

            GeneralRequest.Requestor = await GetUser(request.Requestor.Name);

            GeneralRequest.Process = await _db.D_Processes
                .SingleAsync(x => x.Name == request.Process.Name);

            GeneralRequest.CreateTimeRecord = DateTime.Now;

            GeneralRequest.Id = null;

            GeneralRequest = SetWorkItemsAsync(GeneralRequest).GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
            throw;
        }

        return GeneralRequest;
    }
    public async Task<F_Case> PerformWorkItemAsync(F_WorkItem f_WorkItem)
    {
        var request = await SetCurrentAssignment(f_WorkItem);

        return request;
    }
    public async Task<SimpleClass> Create(SimpleClass obj_DTO)
    {
        await _db.AddAsync(obj_DTO);
        await _db.SaveChangesAsync();
        return obj_DTO;
    }
    public async Task<Int32> delete(String type, Int64? id)
    {
        if (!String.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);
            var obj = await _db.FindAsync(gtype, id);

            if (obj != null)
            {
                _db.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }
        return -1;
    }
    public async Task<SimpleClass> Get(String type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll)
    {
        if (!String.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);

            if (!id.HasValue)
            {
                id = 0;
            }
            if (id == 0)
            {
                return await GetLast(type);
            }
            else
            {
                _db.ChangeTracker.QueryTrackingBehavior = Tracking;

                var _SimpleClass = await _db.FindAsync(gtype, id) as SimpleClass;

                return _SimpleClass;
            }
        }
        return null;

    }
    public async Task<IEnumerable<SimpleClass>> GetAllByName(String type)
    {
        if (!String.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
            var Result = await Task.FromResult(aa.ToList());
            return Result;
        }
        return new List<SimpleClass>();
    }
    public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, Int64? linkID)
    {
        if (!String.IsNullOrEmpty(type))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleLinkClass>;

            var Result = await Task.FromResult(
                aa.Where(x => (x.FirstId == linkID && sd_Status == nameof(LinkProperty.First)) ||
                (x.SecondId == linkID && sd_Status == nameof(LinkProperty.Second))).ToList());
            return Result;
        }
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return new List<SimpleLinkClass>();
    }
    public async Task<Dictionary<String, String>> GetAllTableName(String SchemaName)
    {
        if (!String.IsNullOrEmpty(SchemaName))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var Result = await Task.FromResult(
                _db.Model.GetEntityTypes()
                .ToDictionary(x => x.Name.Split('.').Last(),
                x => x.Name.Split('.').Last()));
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            return Result;
        }
        return new Dictionary<string, string>();
    }
    public async Task<SimpleClass> GetLast(String type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
        var instance = (SimpleClass)Activator.CreateInstance(gtype);
        instance.SortIndex = aa.Any() ? aa.Max(x => x.SortIndex) + 1 : 1;
        return instance;
    }
    public async Task<Int32> RemoveLink(SimpleLinkClassDTO obj_DTO)
    {
        _db.Remove(obj_DTO);

        return 1;
    }
    public async Task<SimpleClass> Update(SimpleClass obj_DTO)
    {
        _db.Update(obj_DTO);
        await _db.SaveChangesAsync();
        _db.ChangeTracker.Clear();
        return obj_DTO;
    }
    public async Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO)
    {
        var gtype = DatabaseClass.GetDBType(obj_DTO.linkType);

        var allLink = await GetAllLink
            (
                obj_DTO.linkType,
                obj_DTO.sd_Status,
                obj_DTO.fixedId
            );

        _db.RemoveRange(allLink);

        var simpleLinkClass = new List<SimpleLinkClass>();

        var fixedInstance = await Get(
            type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.firstType : obj_DTO.secondType,
            id: obj_DTO.fixedId, Tracking: QueryTrackingBehavior.NoTracking);

        foreach (var link in obj_DTO.floatState.Where(x => x.Value))
        {
            var instance = (SimpleLinkClass)Activator.CreateInstance(gtype);

            if (simpleLinkClass.Any())
            {
                instance.SortIndex = simpleLinkClass.Last().SortIndex + 1;
            }
            else
            {
                instance = await GetLast(obj_DTO.linkType) as SimpleLinkClass;
            }

            Type firstType, secondType;

            firstType = DatabaseClass.GetDBType(obj_DTO.firstType);

            secondType = DatabaseClass.GetDBType(obj_DTO.secondType);


            if (obj_DTO.sd_Status == nameof(LinkProperty.First))
            {
                instance.FirstId = obj_DTO.fixedId;
                instance.SecondId = link.Key.Item1;

            }
            else
            {
                instance.FirstId = link.Key.Item1;
                instance.SecondId = obj_DTO.fixedId;
            }

            var floatedInstance = await Get(
            type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.secondType : obj_DTO.firstType,
            id: link.Key.Item1, Tracking: QueryTrackingBehavior.NoTracking);

            if (obj_DTO.sd_Status == nameof(LinkProperty.First))
            {
                instance = await AddLinkName(instance, fixedInstance, floatedInstance);
            }
            else
            {
                instance = await AddLinkName(instance, floatedInstance, fixedInstance);
            }

            simpleLinkClass.Add(instance);
        }

        await _db.AddRangeAsync(simpleLinkClass);

        return await _db.SaveChangesAsync();
    }
    public IQueryable<CartableDTO> GetCartable(CartableDTO cartableDTO,
        IQueryable<F_WorkItem> f_WorkItems)
    {
        if (!String.IsNullOrEmpty(cartableDTO.Username))
        {
            var username = cartableDTO.Username;
            f_WorkItems = f_WorkItems.Where(x => x.User.Name == username);
        }

        if (!String.IsNullOrEmpty(cartableDTO.ProcessName))
        {
            var processName = cartableDTO.ProcessName;
            f_WorkItems = f_WorkItems
                .Where(x => x.Case.Process.Name == processName);
        }
        if (!String.IsNullOrEmpty(cartableDTO.RadNumber))
        {
            var radNumber = cartableDTO.RadNumber;
            f_WorkItems = f_WorkItems.Where(x => x.CaseId == Int64.Parse(radNumber));
        }

        var Inbox = f_WorkItems
        .Select(x =>
        new CartableDTO()
        {
            ProcessName = x.Case.Process.DisplayName,
            RadNumber = x.CaseId.ToString(),
            WorkItemId = x.Id.ToString(),
            Requestor = x.Case.Requestor.DisplayName,
            TaskName = x.Endorsement.DisplayName,
            CreateDate = x.Case.CreateTimeRecord,
            RecieveDate = x.CreateTimeRecord,
            Summary = String.Empty
        }
        );

        return Inbox;
    }
    public async Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO)
    {
        var inboxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 1);

        var inbox = GetCartable(cartableDTO, inboxQuery).AsEnumerable();

        return inbox.ToList();
    }
    public async Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO)
    {
        var outBoxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 2);

        var outBox = GetCartable(cartableDTO, outBoxQuery).AsEnumerable();

        return outBox.ToList();
    }
    public async Task<F_Case> GetCaseAsync(F_Case request)
    {
        F_Case GeneralRequest = await _db.F_Cases
            .Include(x => x.Creator)
            .Include(x => x.Requestor)
            .Include(x => x.Process)
            .Include(x => x.SelectedScenario)
            .Include(x => x.Conditions)
            .Include(x => x.CaseState)
            .Include(x => x.WorkItems).ThenInclude(x => x.WorkItemState)
            .Include(x => x.WorkItems).ThenInclude(x => x.User)
            .SingleAsync(x => (request.Id > 0) ? x.Id == request.Id :
            (x.Process.Name == request.Process.Name &&
            x.ERPCode == request.ERPCode));

        return GeneralRequest;
    }
    public async Task<int> Sync(String TableName)
    {
        switch (TableName)
        {
            case "User":
                await SyncUser();
                break;
            case "Location":
                await SyncLocation();
                break;
            case "Position":
                await SyncPosition();
                break;
            case "UserLocation":
                await Sync_UserLocation();
                break;
            case "UserPosition":
                await Sync_UserPosition();
                break;
            default:
                await SyncUser();
                await SyncLocation();
                await SyncPosition();
                await Sync_UserLocation();
                await Sync_UserPosition();
                break;
        }

        return 1;
    }
}