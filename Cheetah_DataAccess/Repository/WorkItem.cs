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
        public async Task SetInboxAndFuture(Int64 workItem_Id)
        {
            var Current_WorkItem = await _db.F_WorkItems
              .Where(x => x.Id == workItem_Id)
              .Include(x => x.Case)
              .ThenInclude(x => x.WorkItems)
              .ThenInclude(x => x.Endorsement)
              .FirstAsync();

            var Current_SortIndex = Current_WorkItem.Endorsement.SortIndex;

            Current_WorkItem.Case.WorkItems.Where(x => x.IsInbox() &&
            x.Endorsement.SortIndex == Current_SortIndex)
                       .ToList().ForEach(x => x.SetExit());

            var Next_SortIndex = Current_WorkItem.Case.IsEditing() ? Current_SortIndex : Current_SortIndex + 1;

            Current_WorkItem.Case.WorkItems
                .Where(x => x.Endorsement.SortIndex == Next_SortIndex
                && x.Id >= workItem_Id)
                .ToList().ForEach(x => x.SetInbox());

            Current_WorkItem.Case.WorkItems
                .Where(x => x.Endorsement.SortIndex > Next_SortIndex
                && x.Id > workItem_Id)
                .ToList().ForEach(x => x.SetFuture());

            _db.Update(Current_WorkItem);
            await _db.SaveChangesAsync();

        }
        public async Task Exit(Int64 workItem_Id)
        {
            var Current_WorkItem = await _db.F_WorkItems
            .Where(x => x.Id == workItem_Id)
            .Include(x => x.Case)
            .ThenInclude(x => x.WorkItems)
            .ThenInclude(x => x.Endorsement)
            .FirstAsync();

            var Current_SortIndex = Current_WorkItem.SortIndex;

            Current_WorkItem.Case.WorkItems.Where(x => !x.IsSent() &&
            x.Endorsement.SortIndex >= Current_SortIndex)
                       .ToList().ForEach(x => x.SetExit());

            _db.Update(Current_WorkItem);
            await _db.SaveChangesAsync();
        }
        public async Task SetCurrentAssignment(Int64 workItem_Id)
        {
            var Current_WorkItem = await _db.F_WorkItems
            .Where(x => x.Id == workItem_Id)
            .Include(x => x.Case)
            .ThenInclude(x => x.WorkItems)
            .ThenInclude(x => x.Endorsement)
            .FirstAsync();

            Current_WorkItem.LastUpdatedRecord = DateTime.Now;

            if (Current_WorkItem.IsReject())
            {
                Current_WorkItem.Case.SetAborted();
                _db.Update(Current_WorkItem);
                await _db.SaveChangesAsync();
                await Exit(workItem_Id);
            }
            else if (Current_WorkItem.IsApprove())
            {
                Current_WorkItem.Case.SetOngoing();
                _db.Update(Current_WorkItem);
                await _db.SaveChangesAsync();
                await SetInboxAndFuture(workItem_Id);

                if (!Current_WorkItem.Case.WorkItems.Any(x => x.IsInbox() || x.IsFuture()))
                {
                    Current_WorkItem.Case.SetCompleted();
                    _db.Update(Current_WorkItem);
                    await _db.SaveChangesAsync();
                }
            }
        }
        public async Task SetWorkItemsAsync(Int64 Case_Id)
        {
            var Current_Case = await _db.F_Cases
              .Where(x => x.Id == Case_Id)
              .Include(x => x.WorkItems)
              .ThenInclude(x => x.Endorsement)
              .Include(x => x.Conditions)
              .FirstAsync();

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
                    CaseId = Case_Id
                };

                foreach (var eP_Endorsement in eP_Endorsements)
                {
                    if (eP_Endorsement.Role.FixedRole)
                    {
                        first_WorkItem = new()
                        {
                            EndorsementId = eP_Endorsement.Id,
                            LastUpdatedRecord = DateTime.Now
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
                                        CaseId = Case_Id,
                                        EndorsementId = eP_Endorsement.Id,
                                        UserId = D_User.Id
                                    };
                                    Current_Case.WorkItems.Add(f_WorkItem);
                                }
                            }
                        }
                    }
                }

                _db.Update(Current_Case);

                await _db.SaveChangesAsync();

                await SetCurrentAssignment(first_WorkItem.Id.Value);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<Int64> CreateRequestAsync(F_Case request)
        {
            try
            {
                var GeneralRequest = await _iCopyClass.DeepCopy(request);

                await SetWorkItemsAsync(GeneralRequest.Id.Value);

                var log = new LoggerConfiguration()
                             .WriteTo.Console()
                             .WriteTo.File("Serilog.txt")
                             .CreateLogger();

                log.Information($"CreateRequestAsync-{request.Id}");

                return GeneralRequest.Id.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task PerformWorkItemAsync(F_WorkItem f_WorkItem)
        {
            if (f_WorkItem.IsRevise())
            {
                f_WorkItem.Case.SetEditing();
                _db.Update(f_WorkItem);
                await _db.SaveChangesAsync();

                await Exit(f_WorkItem.Id.Value);

                await SetWorkItemsAsync(f_WorkItem.CaseId.Value);

                await SetInboxAndFuture(f_WorkItem.Case.WorkItems
                    .Where(x => x.WorkItemStateId is null || x.WorkItemStateId == 0)
                    .MinBy(x => x.Id).Id.Value);
            }
            else
            {
                await SetCurrentAssignment(f_WorkItem.Id.Value);
            }
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
