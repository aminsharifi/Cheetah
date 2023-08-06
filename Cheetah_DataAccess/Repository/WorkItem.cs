using AutoMapper;
using Cheetah_Business.Dimentions;
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
        public async Task SetInboxAndFuture(F_WorkItem Current_WorkItem)
        {
            var All_Endorsements = await _db.F_Endorsements
                .Where(x => x.ScenarioId == Current_WorkItem.Case.SelectedScenarioId)
                .AsNoTracking()
                .OrderBy(x => x.Scenario.SortIndex)
                .Select(x => new KeyValuePair<Int64?, Int64?>(x.Id, x.SortIndex))
                .ToListAsync();

            var Current_Endorsement = All_Endorsements
                .Where(x => x.Key == Current_WorkItem.EndorsementId)
                .Single();

            var Next_Endorsement = Current_WorkItem.Case.IsEditing() ?
                All_Endorsements.First() : All_Endorsements
                .Where(x => x.Value > Current_Endorsement.Value)
                .FirstOrDefault();

            Current_WorkItem.Case.WorkItems.Where(x => x.IsInbox() &&
            x.Endorsement.SortIndex == Current_Endorsement.Value)
           .ToList().ForEach(x => x.SetExit());

            Current_WorkItem.Case.WorkItems
                .Where(x => !x.IsExit() && x.EndorsementId == Next_Endorsement.Key)
                .ToList().ForEach(x => x.SetInbox());

            foreach (var Endorsement_Item in All_Endorsements.Where(x => x.Key > Next_Endorsement.Key))
            {
                Current_WorkItem.Case.WorkItems
                    .Where(x => !x.IsExit() && x.EndorsementId == Endorsement_Item.Key)
                    .ToList().ForEach(x => x.SetFuture());
            }
        }
        public async Task Exit(F_WorkItem Current_WorkItem)
        {
            var Current_SortIndex = Current_WorkItem.SortIndex;
            Current_WorkItem.Case.WorkItems.Where(x => !x.IsSent() &&
            x.Endorsement.SortIndex >= Current_SortIndex)
                       .ToList().ForEach(x => x.SetExit());
        }
        public async Task SetCurrentAssignment(F_WorkItem Current_WorkItem)
        {
            Current_WorkItem.LastUpdatedRecord = DateTime.Now;

            if (Current_WorkItem.IsReject())
            {
                Current_WorkItem.Case.SetAborted();
                await Exit(Current_WorkItem);
            }
            else if (Current_WorkItem.IsApprove())
            {
                Current_WorkItem.Case.SetOngoing();

                await SetInboxAndFuture(Current_WorkItem);

                if (!Current_WorkItem.Case.WorkItems.Any(x => x.IsInbox() || x.IsFuture()))
                {
                    Current_WorkItem.Case.SetCompleted();
                }
            }
        }
        public async Task SetWorkItemsAsync(F_Case Current_Case)
        {
            try
            {
                var pc_ProcessScenario = await _db.L_ProcessScenarios
                    .Where(x => x.FirstId == Current_Case.ProcessId)
                    .Include(x => x.Scenario)
                    .ThenInclude(x => x.Conditions)
                    .AsNoTracking()
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
                    .Where(x => x.ScenarioId == Current_Case.SelectedScenarioId)
                    .Include(x => x.Role)
                    .OrderBy(x => x.SortIndex)
                    .Include(x => x.Conditions)
                    .AsNoTracking()
                    .ToListAsync();

                F_WorkItem first_WorkItem = new()
                {
                    Case = Current_Case
                };

                foreach (var eP_Endorsement in eP_Endorsements)
                {
                    if (eP_Endorsement.Role.FixedRole)
                    {
                        first_WorkItem = new()
                        {
                            EndorsementId = eP_Endorsement.Id,
                            LastUpdatedRecord = DateTime.Now,
                            Case = Current_Case
                        };

                        if (eP_Endorsement.IsRequestor())
                        {
                            first_WorkItem.UserId = Current_Case.RequestorId;
                            if (!Current_Case.IsEditing())
                            {
                                first_WorkItem.SetApprove();
                                first_WorkItem.SetSent();
                            }
                        }
                        else if (eP_Endorsement.IsRequestorManager())
                        {
                            first_WorkItem.UserId = Current_Case.Requestor.Parent_Id;
                        }

                        Current_Case.WorkItems.Add(first_WorkItem);
                    }
                    else
                    {
                        if (CompareCondition(Actual_Conditions, eP_Endorsement.Conditions))
                        {
                            var Positions = await _db.L_RolePositions
                                .Where(x => x.FirstId == eP_Endorsement.RoleId)
                                .AsNoTracking()
                                .Select(x => x.SecondId)
                                .ToListAsync();

                            var Users = await _db.L_UserPositions
                                .Where(x => Positions.Contains(x.SecondId))
                                .AsNoTracking()
                                .Select(x => x.FirstId)
                                .ToListAsync();

                            var D_Users = await _db.D_Users
                                .Where(x => Users.Contains(x.Id))
                                .Include(x => x.UserLocations)
                                .AsNoTracking()
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
                                        .Where(x => x.FirstId == Current_Case.RequestorId)
                                        .AsNoTracking()
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
                        }
                    }
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
            var GeneralRequest = await _iCopyClass.DeepCopy(request);

            await SetWorkItemsAsync(GeneralRequest);

            GeneralRequest.CaseState = await _db.D_CaseStates
                .Where(x => x.Id == GeneralRequest.CaseStateId)
                .SingleAsync();

            GeneralRequest = (await _db.F_Cases.AddAsync(GeneralRequest)).Entity;

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

            Current_WorkItem.TagId = f_WorkItem.TagId;

            Current_WorkItem.WorkItemStateId = 2;

            if (Current_WorkItem.IsRevise())
            {
                Current_WorkItem.Case.SetEditing();

                Exit(Current_WorkItem);

                await SetWorkItemsAsync(Current_WorkItem.Case);

                await SetInboxAndFuture(Current_WorkItem.Case.WorkItems
                    .Where(x => x.WorkItemStateId is null || x.WorkItemStateId == 0)
                    .MinBy(x => x.Id));
            }
            else
            {
                await SetCurrentAssignment(Current_WorkItem);
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

                if (Actual_Conditions.Any(x => x.Tag.Name == Condition.Tag.Name))
                {
                    var Scenario_Value = float.Parse(Condition.Value);
                    var Current_Value = float.Parse(Actual_Conditions
                        .Single(x => x.Tag.Name == Condition.Tag.Name).Value);

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
