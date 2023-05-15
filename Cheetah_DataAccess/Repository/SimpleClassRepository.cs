using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah_DataAccess.Repository
{

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

        public async Task<F_Request> PerformRequestAsync(F_Request request)
        {
            F_Request GeneralRequest = request;

            CrudOperation crudOperation = (GeneralRequest.Id > 0) ? CrudOperation.Update : CrudOperation.Create;

            try
            {
                GeneralRequest.RQT_Creator = await _db.D_Users.SingleAsync(x => x.PName == request.RQT_Creator.PName);

                GeneralRequest.RQT_Requestor = await _db.D_Users.SingleAsync(x => x.PName == request.RQT_Requestor.PName);

                GeneralRequest.RQT_Process = await _db.D_Processes.SingleAsync(x => x.PName == request.RQT_Process.PName);

                if (crudOperation == CrudOperation.Create)
                    GeneralRequest.Id = null;
                else
                    GeneralRequest = await Get(nameof(F_Request), request.Id) as F_Request;

                await _db.F_Conditions
                    .Where(x => x.CD_RequestId == GeneralRequest.Id)
                    .ExecuteUpdateAsync(x => x.SetProperty(p => p.DsblRecord, false));

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

                    var EP_Endorsements = GeneralRequest.RQT_SelectedScenario?.EP_Endorsements;

                    foreach (var item in EP_Endorsements)
                    {
                        if (CompareCondition(GeneralRequest.RQT_Conditions, item.ED_Conditions))
                        {
                            var Positions = _db.L_RolePositions.Where(x => x.FirstId == item.ED_RoleId).Select(x => x.SecondId);

                            var Users = _db.L_UserPositions.Where(x => Positions.Contains(x.SecondId)).Select(x => x.FirstId);

                            var new_Assignment = new F_Assignment()
                            {
                                PRM_Endorsement = item,
                                PRM_CondidateUsers = _db.D_Users.Where(x => Users.Contains(x.Id)).ToList()
                            };

                            GeneralRequest.RQT_Assignments.Add(new_Assignment);
                        }
                    }
                }

                if (crudOperation == CrudOperation.Update)
                {
                    GeneralRequest.RQT_Current_Review.Id = null;

                    GeneralRequest.RQT_Current_Review.APV_Tag = await _db.D_Tags
                        .SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Tag.PName);

                    GeneralRequest.RQT_Current_Review.APV_Performer = await _db.D_Users
                        .SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Performer.PName);

                    //GeneralRequest.RQT_Current_Review.APV_Assignment.PRM_Endorsement = SelectedScenario.EP_Endorsements.First();
                }

                if (crudOperation == CrudOperation.Create)
                {
                    var tmp = await _db.AddAsync(GeneralRequest);
                    GeneralRequest = tmp.Entity;
                }
                else
                {
                    var tmp = _db.Update(GeneralRequest);
                    GeneralRequest = tmp.Entity;
                }

                await _db.SaveChangesAsync();

                if (crudOperation == CrudOperation.Update)
                    GeneralRequest.RQT_Current_Review.APV_RequestId = GeneralRequest.Id;

                await _db.SaveChangesAsync();
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
        public async Task<Int32> delete(string type, Int64? id)
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
        public async Task<SimpleClass> Get(string type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll)
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
        public async Task<IEnumerable<SimpleClass>> GetAllByName(string type)
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
        public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, string sd_Status, Int64? linkID)
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
        public async Task<Dictionary<string, string>> GetAllTableName(string SchemaName)
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
        public async Task<SimpleClass> GetLast(string type)
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
    }
}