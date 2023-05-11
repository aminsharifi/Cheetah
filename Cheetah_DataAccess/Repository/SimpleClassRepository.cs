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
        public async Task<F_Request> PerformRequestAsync(F_Request request)
        {
            F_Request GeneralRequest = request;

            try
            {
                if (!String.IsNullOrEmpty(request.RQT_Creator.PName))
                {
                    var RI_Creator = await _db.D_Users.SingleAsync(x => x.PName == request.RQT_Creator.PName);
                    GeneralRequest.RQT_CreatorId = RI_Creator.Id;
                    GeneralRequest.RQT_Creator = RI_Creator;
                }
                if (!String.IsNullOrEmpty(request.RQT_Requestor.PName))
                {
                    var RI_Requestor = await _db.D_Users.SingleAsync(x => x.PName == request.RQT_Requestor.PName);
                    GeneralRequest.RQT_RequestorId = RI_Requestor.Id;
                    GeneralRequest.RQT_Requestor = RI_Requestor;
                }
                if (!String.IsNullOrEmpty(request.RQT_Process.PName))
                {
                    var RI_Process = await _db.D_Processes.SingleAsync(x => x.PName == request.RQT_Process.PName);
                    GeneralRequest.RQT_ProcessId = RI_Process.Id;
                    GeneralRequest.RQT_Process = RI_Process;
                }

                #region Create

                if (GeneralRequest.Id is null || GeneralRequest.Id == 0)
                {
                    #region Initials

                    var temp_Request = await GetLast(nameof(F_Request)) as F_Request;
                    GeneralRequest.Id = null;
                    GeneralRequest.PCode = temp_Request.PCode;
                    GeneralRequest.PIndex = temp_Request.PIndex;
                    GeneralRequest.PName = nameof(F_Request) + "-" + temp_Request.PCode;
                    GeneralRequest.PDisplayName = nameof(F_Request) + "-" + temp_Request.PCode;

                    #endregion

                }
                else
                {
                    GeneralRequest = await Get(nameof(F_Request), request.Id) as F_Request;
                }

                #endregion

                #region Conditions

                var f_Condition = await GetLast(nameof(F_Condition)) as F_Condition;

                foreach (var item in GeneralRequest.RQT_Conditions)
                {
                    if (item.Id is null || item.Id == 0)
                    {
                        item.Id = null;
                        item.PCode = f_Condition.PCode++;
                        item.PIndex = f_Condition.PIndex++;
                        item.PDisplayName = item.PName = GeneralRequest.PCode.ToString() + "-" + f_Condition.PCode.ToString();
                    }
                    else
                    {
                        var ri_Conditions = GeneralRequest.RQT_Conditions.Single(x => x.Id == item.Id);
                        ri_Conditions.CD_TagId = item.CD_TagId;
                        ri_Conditions.CD_OperandId = item.CD_OperandId;
                        ri_Conditions.CD_Value = item.CD_Value;
                    }
                    if (!String.IsNullOrEmpty(item.CD_Tag?.PName))
                    {
                        var CD_Tag = await _db.D_Tags.SingleAsync(x => x.PName == item.CD_Tag.PName);
                        item.CD_TagId = CD_Tag.Id;
                        item.CD_Tag = CD_Tag;
                    }
                    var CD_Operand = await _db.D_Operands.SingleAsync(x => x.Id == 1);
                    item.CD_OperandId = CD_Operand.Id;
                    item.CD_Operand = CD_Operand;
                }

                #endregion


                var pc_ProcessScenario = GeneralRequest.RQT_Process.PC_ProcessScenario.ToList<L_ProcessScenario>();

                foreach (var ProcessScenario in pc_ProcessScenario)
                {
                    F_Scenario SelectedScenario = null;
                    var ConditionOccur = true;

                    foreach (var Condition in ProcessScenario.PS_Scenario.EP_Conditions)
                    {
                        if (GeneralRequest.RQT_Conditions.Any(x => x.CD_Tag.PName == Condition.CD_Tag.PName))
                        {
                            var Scenario_Value = float.Parse(Condition.CD_Value);
                            var Current_Value = float.Parse(GeneralRequest.RQT_Conditions
                                .Single(x => x.CD_Tag.PName == Condition.CD_Tag.PName).CD_Value);

                            var Operand_Name = Condition.CD_Operand.PName;

                            if (
                                   (Operand_Name == ">" && Current_Value <= Scenario_Value)
                                || (Operand_Name == ">=" && Current_Value < Scenario_Value)
                                || (Operand_Name == "<" && Current_Value >= Scenario_Value)
                                || (Operand_Name == "<=" && Current_Value > Scenario_Value)
                                || (Operand_Name == "=" && Current_Value != Scenario_Value)
                                || (Operand_Name == "!=" && Current_Value == Scenario_Value)
                                )
                            {
                                ConditionOccur = false;
                                break;
                            }
                        }
                        else
                        {
                            ConditionOccur = false;
                            break;
                        }
                    }
                    if (ConditionOccur)
                    {
                        SelectedScenario = ProcessScenario.PS_Scenario;

                        if (GeneralRequest.RQT_Current_Review is not null)
                        {
                            #region Current_Review

                            var f_Review = await GetLast(nameof(F_Review)) as F_Review;

                            GeneralRequest.RQT_Current_Review.Id = f_Review.Id;
                            GeneralRequest.RQT_Current_Review.PCode = f_Review.PCode;
                            GeneralRequest.RQT_Current_Review.PIndex = f_Review.PIndex;
                            GeneralRequest.RQT_Current_Review.PName = GeneralRequest.PName + "-" + f_Review.PCode;

                            if (!String.IsNullOrEmpty(request.RQT_Current_Review.APV_Tag.PName))
                            {
                                var APV_Tag = await _db.D_Tags.SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Tag.PName);
                                GeneralRequest.RQT_Current_Review.APV_TagId = APV_Tag.Id;
                                GeneralRequest.RQT_Current_Review.APV_Tag = APV_Tag;
                            }

                            if (!String.IsNullOrEmpty(request.RQT_Current_Review.APV_Performer.PName))
                            {
                                var APV_Performer = await _db.D_Users
                                    .SingleAsync(x => x.PName == request.RQT_Current_Review.APV_Performer.PName);

                                GeneralRequest.RQT_Current_Review.APV_PerformerId = APV_Performer.Id;
                                GeneralRequest.RQT_Current_Review.APV_Performer = APV_Performer;
                            }




                            GeneralRequest.RQT_Current_Review.APV_Assignment.PRM_Endorsement = SelectedScenario.EP_Endorsements.First();







                            #endregion
                        }
                    }
                }
                if (GeneralRequest.Id is null || GeneralRequest.Id == 0)
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

                GeneralRequest.RQT_Current_Review.APV_RequestId = GeneralRequest.Id;

                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            var ret_Requests = await _db.F_Requests
                .Include(x => x.RQT_ProcessState)
                .SingleAsync(x => x.Id == GeneralRequest.Id); ;

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