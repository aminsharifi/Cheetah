using AutoMapper;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Exceptions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Cheetah_DataAccess.Repository
{
    public class WorkItem : IWorkItem
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;
        protected ISync _iSync;
        protected ITableCRUD _itableCRUD;
        protected ICopyClass _iCopyClass;
        public WorkItem(ApplicationDbContext db, IMapper mapper,
            ISync iSync, ITableCRUD itableCRUD, ICopyClass iCopyClass)
        {
            _db = db;
            _iSync = iSync;
            _itableCRUD = itableCRUD;
            _iCopyClass = iCopyClass;
        }
        public async Task SetCartable(F_WorkItem Current_WorkItem, F_Condition ExpectedCondition)
        {
            var All_Endorsements = await _db.F_Endorsements
                                .AsNoTracking()
                                .Where(x => x.ScenarioId == Current_WorkItem.Case.SelectedScenarioId)
                                .OrderBy(x => x.Scenario.SortIndex)
                                .Select(x => new KeyValuePair<Int64?, Int64?>(x.Id, x.SortIndex))
                                .ToListAsync();

            /*

            if (ExpectedCondition.ToEndorsementId is not null)
            {
                var Current_Endorsement = All_Endorsements
                                               .Where(x => x.Key == ExpectedCondition.ToEndorsementId)
                                               .Single();

                var Next_Endorsement = All_Endorsements
                    .Where(x => x.Value > Current_Endorsement.Value)
                    .FirstOrDefault();

                foreach (var Endorsement_Item in All_Endorsements.Where(x => x.Key >= Next_Endorsement.Key))
                {
                    Current_WorkItem.Case.WorkItems
                        .Where(x => !x.IsExit() && !x.IsSent())
                        .Where(x => x.EndorsementId == Endorsement_Item.Key)
                        .ToList().ForEach(x => x.SetFuture());
                }
            }

            */

        }
        public async Task SetCurrentAssignment(F_WorkItem Current_WorkItem)
        {
            Current_WorkItem.LastUpdatedRecord = DateTime.Now;

            var WorkItemEndorsement = await _db.F_Endorsements
                .AsNoTracking()
                .Where(x => x.Id == Current_WorkItem.EndorsementId)
                //.Include(x => x.EndorsementItem.Conditions)
                //.ThenInclude(x => x.Operand)
                .SingleAsync();

            var ActualConditions = Current_WorkItem.Case.Conditions;
            /*
            var ExpectedConditions = WorkItemEndorsement.EndorsementItem.Conditions;

            foreach (var ExpectedCondition in ExpectedConditions)
            {
                var ExpectedConditionList = new List<F_Condition>();

                ExpectedConditionList.Add(ExpectedCondition);

                if (CompareCondition(ActualConditions, ExpectedConditionList))
                {
                    //Current_WorkItem.Case.CaseStateId =
                    //    ExpectedCondition.CaseStateId;

                    Current_WorkItem.TagId =
                        ExpectedCondition.TagId;

                    Current_WorkItem.SetSent();

                    if (Current_WorkItem.Case.IsAborted())
                    {
                        Current_WorkItem.Case.WorkItems
                            .Where(x => !x.IsExit() && !x.IsSent())
                            .ToList().ForEach(x => x.SetExit());
                    }
                    if (!Current_WorkItem.Case.IsAborted())
                    {
                        #region Exit Current work items
                        var OtherWorkItems = Current_WorkItem.Case.WorkItems
                            .Where(x => x.EndorsementId == Current_WorkItem.EndorsementId)
                            .Where(x => x.IsInbox());

                        foreach (var OtherWorkItem in OtherWorkItems)
                        {
                            OtherWorkItem.SetExit();
                        }
                        #endregion

                        #region Set inbox

                        /*

                        var _Current_WorkItems = Current_WorkItem.Case.WorkItems
                            .Where(x => x.EndorsementId == ExpectedCondition.ToEndorsementId)
                            .Where(x => !x.IsSent() && !x.IsExit());

                        var _UserId = ActualConditions.First().UserId;

                        if (_UserId > 0)
                        {
                            _Current_WorkItems.Where(x => x.UserId == _UserId)
                                .Single().SetInbox();

                            _Current_WorkItems
                                .Where(x => x.UserId != _UserId)
                                .ToList()
                                .ForEach(x => x.SetExit());
                        }
                        else
                        {
                            _Current_WorkItems
                                .ToList()
                                .ForEach(x => x.SetInbox());
                        }

                       

                        #endregion

                        await SetCartable(Current_WorkItem, ExpectedCondition);
            
                    }
                }
            }

            */
        }
        public async Task SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null)
        {
            try
            {
                var pc_ProcessScenario = await _db.L_ProcessScenarios
                    .AsNoTracking()
                    .Where(x => x.FirstId == Current_Case.ProcessId)
                    .Where(x => x.EnableRecord == true)
                    .Include(x => x.Scenario)
                    .ThenInclude(x => x.Conditions)
                    .ToListAsync();

                var Actual_Conditions = Current_Case.Conditions;

                foreach (var ProcessScenario in pc_ProcessScenario)
                {
                    var ConditionOccures = false;

                    if (Actual_Conditions.Count() == 0)
                    {
                        ConditionOccures = true;
                    }
                    else
                    {
                        var Expected_Conditions = ProcessScenario.Scenario.Conditions;

                        ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions);
                    }
                    if (ConditionOccures)
                    {
                        Current_Case.SelectedScenarioId = ProcessScenario.Scenario.Id;
                        break;
                    }
                }

                if (Current_Case.WorkItems is null)
                {
                    Current_Case.WorkItems = new HashSet<F_WorkItem>();
                }

                var eP_Endorsements = await _db.F_Endorsements
                    .AsNoTracking()
                    .Where(x => x.ScenarioId == Current_Case.SelectedScenarioId)
                    .Where(x => x.EnableRecord == true)
                    .OrderBy(x => x.SortIndex)
                    .Include(x => x.Role)
                    .Include(x => x.EndorsementItem.Conditions)
                    .ThenInclude(x => x.Tag)
                    .Include(x => x.EndorsementItem.Conditions)
                    .ThenInclude(x => x.Operand)
                    .Include(x => x.EndorsementItem)
                    .ThenInclude(x => x.CaseState)
                    .ToListAsync();

                F_WorkItem first_WorkItem = new()
                {
                    Case = Current_Case
                };

                foreach (var eP_Endorsement in eP_Endorsements)
                {
                    if (eP_Endorsement.Role.FixedRole)
                    {
                        F_WorkItem f_WorkItem = new()
                        {
                            Case = Current_Case,
                            EndorsementId = eP_Endorsement.Id,
                            LastUpdatedRecord = DateTime.Now
                        };

                        if (eP_Endorsement.IsRequestor())
                        {
                            f_WorkItem.UserId = Current_Case.RequestorId;
                        }
                        else if (eP_Endorsement.IsRequestorManager())
                        {
                            f_WorkItem.UserId = Current_Case.Requestor.Parent_Id;
                        }
                        if (!(first_WorkItem.EndorsementId > 0))
                        {
                            first_WorkItem = f_WorkItem;
                        }
                        Current_Case.WorkItems.Add(f_WorkItem);
                    }
                    else
                    {
                        var Positions = await _db.L_RolePositions
                            .AsNoTracking()
                            .Where(x => x.FirstId == eP_Endorsement.RoleId)
                            .Where(x => x.EnableRecord == true)
                            .Select(x => x.SecondId)
                            .ToListAsync();

                        var Users = await _db.L_UserPositions
                            .AsNoTracking()
                            .Where(x => Positions.Contains(x.SecondId))
                            .Where(x => x.EnableRecord == true)
                            .Select(x => x.FirstId)
                            .ToListAsync();

                        var D_Users = await _db.D_Users
                            .AsNoTracking()
                            .Where(x => Users.Contains(x.Id))
                            .Where(x => x.EnableRecord == true)
                            .Include(x => x.UserLocations)
                            .ToListAsync();

                        foreach (var D_User in D_Users)
                        {
                            var UserOccur = false;

                            if (eP_Endorsement.Role.Independent)
                            {
                                UserOccur = true;
                            }
                            else
                            {
                                var userLocations = await _db.L_UserLocations
                                    .AsNoTracking()
                                    .Where(x => x.FirstId == Current_Case.RequestorId)
                                    .Where(x => x.EnableRecord == true)
                                    .Select(x => x.SecondId)
                                    .ToListAsync();

                                if (D_User.UserLocations.Any(x => userLocations.Contains(x.SecondId)))
                                {
                                    UserOccur = true;
                                }
                            }
                            if (UserOccur)
                            {
                                F_WorkItem f_WorkItem = new()
                                {
                                    Case = Current_Case,
                                    EndorsementId = eP_Endorsement.Id,
                                    UserId = D_User.Id
                                };
                                Current_Case.WorkItems.Add(f_WorkItem);
                            }
                        }

                        if (!Current_Case.WorkItems
                          .Where(x => x.EndorsementId == eP_Endorsement.Id)
                          .Any())
                        {
                            throw new ArgumentNullException($"There aren't any related users for {eP_Endorsement.Name}");
                        }
                    }
                }
                if (Current_WorkItem is not null)
                {
                    first_WorkItem = Current_WorkItem;
                }
                await SetCurrentAssignment(first_WorkItem);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<F_Case> CreateRequestAsync(F_Case request)
        {
            //Clean up
            var GeneralRequest = await _iCopyClass.DeepCopy(request);

            var DuplicateCase = _db.F_Cases
                .AsNoTracking()
                .Where(x => x.ProcessId == GeneralRequest.ProcessId)
                .Where(x => x.ERPCode == GeneralRequest.ERPCode)
                .Where(x => x.CaseStateId == 1 || x.CaseStateId == 2);

            var AnyDuplicate = await DuplicateCase.AnyAsync();

            if (AnyDuplicate)
            {
                var CaseID = (await DuplicateCase.FirstAsync()).Id;

                throw new Exception($"There is another case with caseid {CaseID}");
            }

            await SetWorkItemsAsync(GeneralRequest);

            _db.F_Cases.Add(GeneralRequest);

            await _db.SaveChangesAsync();

            var log = new LoggerConfiguration()
                         .WriteTo.Console()
                         .WriteTo.File("Serilog.txt")
                         .CreateLogger();

            log.Information($"CreateRequestAsync-{GeneralRequest.Id}");

            return GeneralRequest;
        }
        public async Task<F_WorkItem> PerformWorkItemAsync(F_WorkItem f_WorkItem)
        {
            var Current_WorkItem = await _db.F_WorkItems
                  .Where(x => x.Id == f_WorkItem.Id)
                  .Include(x => x.Case)
                  .ThenInclude(x => x.WorkItems)
                  .ThenInclude(x => x.Endorsement)
                  .Include(x => x.Case)
                  .ThenInclude(x => x.Conditions)
                  .FirstAsync();

            Current_WorkItem.Case.Conditions = await _iCopyClass.CopyCondition(f_WorkItem.Case.Conditions);

            await SetCurrentAssignment(Current_WorkItem);

            if (Current_WorkItem.Case.IsEditing())
            {
                Current_WorkItem.Case.WorkItems
                    .Where(x => !x.IsExit() && !x.IsSent())
                    .ToList().ForEach(x => x.SetExit());

                await SetWorkItemsAsync(Current_WorkItem.Case, Current_WorkItem);
            }

            _db.F_WorkItems.Update(Current_WorkItem);

            await _db.SaveChangesAsync();

            return Current_WorkItem;
        }
        public bool CompareCondition(IEnumerable<F_Condition> Actual_Conditions,
            IEnumerable<F_Condition> Expected_Conditions)
        {
            var cnt_con = Expected_Conditions.Count();

            var ConditionOccur = 0;

            for (int i = 0; i < cnt_con; i++)
            {
                var Condition = Expected_Conditions.ToArray()[i];

                if (Actual_Conditions.Any(x => x.TagId == Condition.TagId))
                {
                    var Scenario_Value = float.Parse(Condition.Value);
                    var Current_Value = float.Parse(Actual_Conditions
                        .Single(x => x.TagId == Condition.TagId).Value);

                    var Operand_Name = Condition.Operand.Name;

                    if (
                           Operand_Name == ">" && Current_Value > Scenario_Value
                        || Operand_Name == ">=" && Current_Value >= Scenario_Value
                        || Operand_Name == "<" && Current_Value < Scenario_Value
                        || Operand_Name == "<=" && Current_Value <= Scenario_Value
                        || Operand_Name == "=" && Current_Value == Scenario_Value
                        || Operand_Name == "!=" && Current_Value != Scenario_Value
                        )
                    {
                        ConditionOccur++;
                    }
                }
            }
            return ConditionOccur == cnt_con;
        }
    }
}
