using AutoMapper;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

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
        public async Task<F_Case> SetInboxAndFuture(F_WorkItem f_WorkItem)
        {
            var Current_SortIndex = f_WorkItem.Endorsement.SortIndex;

            f_WorkItem.Case.WorkItems.Where(x => x.IsInbox() &&
            x.Endorsement.SortIndex == Current_SortIndex)
                       .ToList().ForEach(x => x.SetExit());

            var Next_SortIndex = f_WorkItem.Case.IsEditing() ? Current_SortIndex : Current_SortIndex + 1;

            f_WorkItem.Case.WorkItems.Where(x => x.Endorsement.SortIndex == Next_SortIndex
            && x.Id >= f_WorkItem.Id)
                .ToList().ForEach(x => x.SetInbox());

            f_WorkItem.Case.WorkItems.Where(x => x.Endorsement.SortIndex > Next_SortIndex
            && x.Id > f_WorkItem.Id)
                .ToList().ForEach(x => x.SetFuture());

            return f_WorkItem.Case;
        }
        public async Task<F_Case> Exit(F_WorkItem f_WorkItem)
        {
            var Current_SortIndex = f_WorkItem.Endorsement.SortIndex;

            f_WorkItem.Case.WorkItems.Where(x => !x.IsSent() &&
            x.Endorsement.SortIndex >= Current_SortIndex)
                       .ToList().ForEach(x => x.SetExit());

            return f_WorkItem.Case;
        }
        public async Task<F_Case> SetCurrentAssignment(F_WorkItem? f_WorkItem)
        {
            if (f_WorkItem.IsReject())
            {
                f_WorkItem.Case.SetAborted();
                f_WorkItem.Case = await Exit(f_WorkItem);
            }
            else if (f_WorkItem.IsApprove())
            {
                f_WorkItem.Case.SetOngoing();

                f_WorkItem.Case = await SetInboxAndFuture(f_WorkItem);

                if (!f_WorkItem.Case.WorkItems.Any(x => x.IsInbox() || x.IsFuture()))
                {
                    f_WorkItem.Case.SetCompleted();
                }
            }

            _db.Update(f_WorkItem);

            await _db.SaveChangesAsync();

            return f_WorkItem.Case;
        }
        public async Task<F_Case> SetWorkItemsAsync(F_Case GeneralRequest)
        {
            try
            {
                var pc_ProcessScenario = _db.L_ProcessScenarios.Where(x => x.FirstId ==
                GeneralRequest.ProcessId).ToList();

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

                var eP_Endorsements = _db.F_Endorsements
                    .Where(x => x.Scenario == GeneralRequest.SelectedScenario)
                    .Include(x => x.Role)
                    .OrderBy(x => x.SortIndex).ToList();

                F_WorkItem first_WorkItem = new()
                {
                    Case = GeneralRequest
                };

                foreach (var eP_Endorsement in eP_Endorsements)
                {
                    if (eP_Endorsement.Role.FixedRole)
                    {
                        first_WorkItem = new()
                        {
                            Endorsement = eP_Endorsement,
                            EndorsementId = eP_Endorsement.Id
                        };

                        if (eP_Endorsement.IsRequestor())
                        {
                            first_WorkItem.UserId = GeneralRequest.Requestor.Id;
                            first_WorkItem.User = GeneralRequest.Requestor;
                            if (!GeneralRequest.IsEditing())
                            {
                                first_WorkItem.SetApprove();
                                first_WorkItem.SetSent();
                            }
                        }
                        else if (eP_Endorsement.IsRequestorManager())
                        {
                            first_WorkItem.UserId = GeneralRequest.Requestor.Parent_Id;
                            first_WorkItem.User = GeneralRequest.Requestor.Parent;
                        }

                        GeneralRequest.WorkItems.Add(first_WorkItem);
                    }
                    else
                    {
                        if (CompareCondition(GeneralRequest.Conditions, eP_Endorsement.Conditions))
                        {
                            var Positions = await _db.L_RolePositions
                                .Where(x => x.FirstId == eP_Endorsement.RoleId).Select(x => x.SecondId).ToListAsync();

                            var Users = await _db.L_UserPositions.Where(x => Positions.Contains(x.SecondId))
                                .Select(x => x.FirstId).ToListAsync();

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
                                    var userLocations = _db.L_UserLocations
                                        .Where(x => x.FirstId == GeneralRequest.RequestorId)
                                        .Select(x => x.SecondId).ToList();

                                    if (D_User.UserLocations.Any(x => userLocations.Contains(x.SecondId)))
                                    {
                                        UserOccur = true;
                                    }
                                }
                                if (UserOccur)
                                {
                                    F_WorkItem f_WorkItem = new()
                                    {
                                        Case = GeneralRequest,
                                        Endorsement = eP_Endorsement,
                                        EndorsementId = eP_Endorsement.Id,
                                        UserId = D_User.Id
                                    };
                                    GeneralRequest.WorkItems.Add(f_WorkItem);
                                }
                            }
                        }
                    }
                }

                GeneralRequest = _db.Update(GeneralRequest).Entity;

                _db.Update(GeneralRequest);

                await _db.SaveChangesAsync();

                var request = await SetCurrentAssignment(first_WorkItem);

                _db.Update(GeneralRequest);

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
            try
            {
                var GeneralRequest = await _iCopyClass.DeepCopy(request);

                GeneralRequest = await SetWorkItemsAsync(((F_Case)GeneralRequest));

                return GeneralRequest;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<F_Case> PerformWorkItemAsync(F_WorkItem f_WorkItem)
        {
            if (f_WorkItem.IsRevise())
            {
                f_WorkItem.Case.SetEditing();

                f_WorkItem.Case = await Exit(f_WorkItem);

                f_WorkItem.Case = await SetWorkItemsAsync(f_WorkItem.Case);

                f_WorkItem.Case = await SetInboxAndFuture(f_WorkItem.Case.WorkItems
                    .Where(x => x.WorkItemStateId is null || x.WorkItemStateId == 0)
                    .MinBy(x => x.Id));
            }
            else
            {
                var request = await SetCurrentAssignment(f_WorkItem);
            }

            _db.Update(f_WorkItem);
            await _db.SaveChangesAsync();

            return f_WorkItem.Case;
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
