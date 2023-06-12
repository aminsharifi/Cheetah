using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
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
    }
    public async Task<Int32> AddLink(SimpleLinkClassDTO obj_DTO)
    {
        await _db.AddAsync(obj_DTO);

        return 1;
    }
    public async Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
    {
        simpleLinkClass.PDisplayName = new StringBuilder()
                 .Append(firstClass?.PDisplayName ?? String.Empty)
                 .Append("-")
                 .Append(SecondClass?.PDisplayName ?? String.Empty)
                 .ToString();

        simpleLinkClass.PName = new StringBuilder()
                          .Append(firstClass?.PName ?? String.Empty)
                          .Append("-")
                          .Append(SecondClass?.PName ?? String.Empty)
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

            if (Actual_Conditions.Any(x => x.CD_Tag.PName == Condition.CD_Tag.PName))
            {
                var Scenario_Value = float.Parse(Condition.CD_Value);
                var Current_Value = float.Parse(Actual_Conditions
                    .Single(x => x.CD_Tag.PName == Condition.CD_Tag.PName).CD_Value);

                var Operand_Name = Condition.CD_Operand.PName;

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
    public async Task<F_Request> SetCurrentAssignment(F_Request GeneralRequest)
    {
        var RQT_Assignment = GeneralRequest.RQT_Assignments
                   .Where(x => x.PRM_Review is null || !x.PRM_Review.APV_Tag.PName.Equals("Approve"));

        if (RQT_Assignment.Any())
            GeneralRequest.RQT_CurrentAssignment = RQT_Assignment.First();
        else
            GeneralRequest.RQT_ProcessStateId = 3;

        await _db.SaveChangesAsync();

        return GeneralRequest;
    }
    public async Task<D_User> GetUser(String PName)
    {
        var Cheetah_User = _db.D_Users.Where(x => x.PName == PName);

        var ERP_User = _db.V_Users.Where(x => x.PName == PName);

        D_User SelectedUser = new D_User();

        if (!await Cheetah_User.AnyAsync())
        {
            var v_Creator = await ERP_User.SingleAsync();

            var D_Creator = new D_User()
            {
                PERPCode = v_Creator.PERPCode,
                PName = v_Creator.PName,
                PDisplayName = v_Creator.PDisplayName,
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

                if (D_Creator.PDisplayName != v_Creator.PDisplayName)
                {
                    D_Creator.PDisplayName = v_Creator.PDisplayName;
                    changed = true;
                }

                if (D_Creator.DsblRecord != v_Creator.DsblRecord)
                {
                    D_Creator.DsblRecord = v_Creator.DsblRecord;
                    changed = true;
                }

                if (!String.IsNullOrEmpty(v_Creator.User_BossName) && v_Creator.User_BossName != v_Creator.PName)
                {
                    if (D_Creator.Parent is null || D_Creator.Parent?.PName != v_Creator.User_BossName)
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
        var D_Positions = _db.D_Positions.Where(x => x.PName == PName);
        var v_Position = await V_Positions.SingleAsync();
        var d_Position = new D_Position();

        if (!await V_Positions.AnyAsync())
        {
            d_Position = new D_Position()
            {
                PERPCode = v_Position.PERPCode,
                PName = v_Position.PName,
                PDisplayName = v_Position.PDisplayName,
                LastUpdatedRecord = DateTime.Now
            };

            await _db.D_Positions.AddAsync(d_Position);
        }
        else
        {
            d_Position = await D_Positions.SingleAsync();
            d_Position.PName = v_Position.PName;
            d_Position.PDisplayName = v_Position.PDisplayName;
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
    public async Task<F_Request> CreateRequestAsync(F_Request request)
    {
        F_Request GeneralRequest = request;

        try
        {
            //await SyncUser();
            var d_Users = await _db.D_Users.ToListAsync();
            var d_Positions = await _db.D_Positions.ToListAsync();
            var v_UserPositions = await _db.V_UserPositions.ToListAsync();

            foreach (var item in v_UserPositions)
            {
                var users = d_Users.Where(x => x.PERPCode == item.FirstId);
                var positions = d_Positions.Where(x => x.PERPCode == item.SecondId);
                if (!users.Any())
                {
                    var aa = 12;
                }
                if (!positions.Any())
                {
                    var aa = 12;
                }
                var user = users.Single();
                var position = positions.Single();

                var l_UserPosition = new L_UserPosition()
                {
                    FirstId = user.Id,
                    SecondId = position.Id,
                    PName = user.PName + "-" + position.PName,
                    PDisplayName = user.PDisplayName + "-" + position.PDisplayName,
                    DsblRecord = item.DsblRecord,
                    LastUpdatedRecord = DateTime.Now
                };
                await _db.L_UserPositions.AddAsync(l_UserPosition);
            }

            await _db.SaveChangesAsync();



            GeneralRequest.RQT_Creator = await GetUser(request.RQT_Creator.PName);

            GeneralRequest.RQT_Requestor = await GetUser(request.RQT_Requestor.PName);

            GeneralRequest.RQT_Process = await _db.D_Processes.SingleAsync(x => x.PName == request.RQT_Process.PName);

            GeneralRequest.CreateTimeRecord = DateTime.Now;

            GeneralRequest.Id = null;

            foreach (var item in GeneralRequest.RQT_Conditions)
            {
                item.Id = null;
                item.CD_Tag = await _db.D_Tags.SingleAsync(x => x.PName == item.CD_Tag.PName);
            }

            var pc_ProcessScenario = GeneralRequest.RQT_Process?.PC_ProcessScenario;

            foreach (var ProcessScenario in pc_ProcessScenario)
            {
                var Actual_Conditions = GeneralRequest.RQT_Conditions.ToList();

                var Expected_Conditions = ProcessScenario.PS_Scenario.EP_Conditions.ToList();

                if (CompareCondition(Actual_Conditions, Expected_Conditions))
                {
                    GeneralRequest.RQT_SelectedScenario = ProcessScenario.PS_Scenario;

                    break;
                }
            }

            if (GeneralRequest.RQT_Assignments is null)
            {
                GeneralRequest.RQT_Assignments = new HashSet<F_Assignment>();

                var eP_Endorsements = GeneralRequest.RQT_SelectedScenario?.EP_Endorsements.ToList();

                var userLocations = GeneralRequest.RQT_Requestor.User_UserLocations.Select(x => x.SecondId).ToList();

                foreach (var eP_Endorsement in eP_Endorsements)
                {
                    if (CompareCondition(GeneralRequest.RQT_Conditions, eP_Endorsement.ED_Conditions))
                    {
                        var Positions = await _db.L_RolePositions.Where(x => x.FirstId == eP_Endorsement.ED_RoleId).Select(x => x.SecondId).ToListAsync();

                        var Users = await _db.L_UserPositions.Where(x => Positions.Contains(x.SecondId)).Select(x => x.FirstId).ToListAsync();


                        var D_Users = await _db.D_Users.Where(x => Users.Contains(x.Id)).ToListAsync();

                        var Added_Users = new List<D_User>();

                        foreach (var D_User in D_Users)
                        {
                            if (D_User.User_UserLocations.Any(
                                x => (!eP_Endorsement.ED_Role.ROL_Independent && userLocations.Contains(x.Id)) || eP_Endorsement.ED_Role.ROL_Independent))
                            {
                                Added_Users.Add(D_User);
                            }
                        }
                        var new_Assignment = new F_Assignment()
                        {
                            PRM_Endorsement = eP_Endorsement
                        };

                        if (Added_Users.Count == 0)
                            throw new ArgumentNullException("There are'nt any users for this role");

                        foreach (var Added_User in Added_Users)
                        {
                            await _db.L_UserAssignments.AddAsync(
                                  new L_UserAssignment()
                                  {
                                      UA_User = Added_User,
                                      UA_Assignment = new_Assignment

                                  });
                        }

                        await _db.F_Assignments.AddAsync(new_Assignment);

                        GeneralRequest.RQT_Assignments.Add(new_Assignment);
                    }
                }

                var tmp = await _db.AddAsync(GeneralRequest);

                GeneralRequest = tmp.Entity;

                await _db.SaveChangesAsync();

                await SetCurrentAssignment(GeneralRequest);
            }
        }
        catch (Exception ex)
        {
            throw;
        }

        var ret_Requests = await _db.F_Requests
            .Include(x => x.RQT_ProcessState)
            .SingleAsync(x => x.Id == GeneralRequest.Id);

        return ret_Requests;
    }
    public async Task<F_Request> PerformRequestAsync(F_Request request)
    {
        var GeneralRequest = await Get(nameof(F_Request), request.Id) as F_Request;

        if (GeneralRequest.RQT_CurrentAssignment.Id != request.RQT_Current_Review.APV_AssignmentId)
            throw new ArgumentNullException("Id is incorrect");

        try
        {
            GeneralRequest.RQT_Current_Review = new F_Review();

            GeneralRequest.RQT_Current_Review.APV_Tag = await _db.D_Tags
                .SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Tag.PName);

            GeneralRequest.RQT_Current_Review.APV_Performer = await _db.D_Users
                .SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Performer.PName);

            GeneralRequest.RQT_Current_Review.APV_Assignment = GeneralRequest.RQT_CurrentAssignment;

            var tmp = _db.Update(GeneralRequest);

            GeneralRequest = tmp.Entity;

            await _db.SaveChangesAsync();

            GeneralRequest.RQT_Current_Review.APV_Request = GeneralRequest;

            await SetCurrentAssignment(GeneralRequest);

        }
        catch (Exception ex)
        {
            throw;
        }

        var ret_Requests = await _db.F_Requests
            .Include(x => x.RQT_ProcessState)
            .SingleAsync(x => x.Id == GeneralRequest.Id);

        return ret_Requests;
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
        instance.PCode = aa.Any() ? aa.Max(x => x.PCode) + 1 : 1;
        instance.PIndex = aa.Any() ? aa.Max(x => x.PIndex) + 1 : 1;
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
                instance.PCode = simpleLinkClass.Last().PCode + 1;
                instance.PIndex = simpleLinkClass.Last().PIndex + 1;
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
    public async Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO)
    {
        var username = cartableDTO.Username;

        return _db.L_UserAssignments
            .Where(x => x.UA_User.PName == username
            && x.UA_Assignment.PRM_Request.RQT_CurrentAssignment == x.UA_Assignment)
            .Select(x =>
            new CartableDTO()
            {
                ProcessName = x.UA_Assignment.PRM_Request.RQT_Process.PDisplayName,
                RadNumber = x.UA_Assignment.PRM_RequestId.ToString(),
                Requestor = x.UA_Assignment.PRM_Request.RQT_Requestor.PDisplayName,
                TaskName = x.UA_Assignment.PRM_Endorsement.PDisplayName,
                CreateDate = x.UA_Assignment.PRM_Request.CreateTimeRecord,
                RecieveDate = x.UA_Assignment.CreateTimeRecord,
                Summary = x.UA_Assignment.PRM_Request.PDisplayName
            }
            ).AsEnumerable();
    }
    public async Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO)
    {
        var username = cartableDTO.Username;

        return _db.L_UserAssignments
            .Where(x => x.UA_User.PName == username
            && x.UA_Assignment.PRM_Review.APV_Tag != null)
            .Select(x =>
            new CartableDTO()
            {
                ProcessName = x.UA_Assignment.PRM_Request.RQT_Process.PDisplayName,
                RadNumber = x.UA_Assignment.PRM_RequestId.ToString(),
                Requestor = x.UA_Assignment.PRM_Request.RQT_Requestor.PDisplayName,
                TaskName = x.UA_Assignment.PRM_Endorsement.PDisplayName,
                CreateDate = x.UA_Assignment.PRM_Request.CreateTimeRecord,
                RecieveDate = x.UA_Assignment.CreateTimeRecord,
                Summary = x.UA_Assignment.PRM_Request.PDisplayName
            }
            ).AsEnumerable();
    }
}