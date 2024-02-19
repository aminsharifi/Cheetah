namespace Cheetah.Infrastructure.Persistence.Repository;
public class WorkItem(ApplicationDbContext _db, IMapper _mapper, ITableCRUD _itableCRUD, ICopyClass _iCopyClass) : IWorkItem
{
    public IQueryable<F_Task> GetAllTask(Int64 ScenarioId)
    {
        var _allTasks =
            _db.F_Tasks
            .Where(x => x.ScenarioId == ScenarioId)
            .Where(x => x.EnableRecord == true)
            .OrderBy(x => x.SortIndex)
            .AsNoTracking();

        var _allPerformers = _allTasks
            .Include(x => x.L_TaskConditions)
            .ThenInclude(x => x.Condition);

        var _allFlows = _allPerformers
            .Include(x => x.L_TaskFlows)
            .ThenInclude(x => x.Flow)
            .ThenInclude(x => x.CaseState);

        var _allConditions = _allFlows
            .Include(x => x.L_TaskFlows)
            .ThenInclude(x => x.Flow)
            .ThenInclude(x => x.FlowConditions)
            .ThenInclude(x => x.Condition);

        var _allNextActions = _allConditions
                   .Include(x => x.L_TaskFlows)
                   .ThenInclude(x => x.Flow)
                   .ThenInclude(x => x.FlowTasks)
                   .ThenInclude(x => x.Task);

        return _allNextActions;
    }
    public async Task<CheetahResult<bool>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null)
    {
        try
        {
            var pc_ProcessScenarios = await _db.L_ProcessScenarios
                .Where(x => x.FirstId == Current_Case.ProcessId)
                .Where(x => x.EnableRecord == true)
                .AsNoTracking()
                .ToListAsync();

            if (pc_ProcessScenarios.Count() == 1)
            {
                Current_Case.SelectedScenarioId = pc_ProcessScenarios.First().SecondId;
            }
            else
            {
                var Actual_ConditionsIds = Current_Case.CaseConditions.Select(x => x.SecondId.Value);

                var Actual_Conditions = await _db.F_Conditions
                    .Where(x => Actual_ConditionsIds.Where(z => z == x.Id).Any())
                    .AsNoTracking()
                    .ToListAsync();

                foreach (var ProcessScenario in pc_ProcessScenarios)
                {
                    var ConditionOccures = false;

                    var Expected_Conditions = ProcessScenario
                        .Scenario
                        .ScenarioConditions
                        .Select(x => x.Condition);

                    ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions).Result.Value;

                    if (ConditionOccures)
                    {
                        Current_Case.SelectedScenarioId = ProcessScenario.Scenario.Id;
                        break;
                    }
                }
            }

            var _allTasks = await GetAllTask(Current_Case.SelectedScenarioId.Value)
                .AsNoTracking()
                .ToListAsync();

            F_WorkItem _workItem = new()
            {
                Case = Current_Case
            };

            foreach (var _task in _allTasks)
            {
                F_WorkItem f_WorkItem = new()
                {
                    Case = Current_Case,
                    TaskId = _task.Id
                };

                if (Current_Case.WorkItems.Count() == 1)
                {
                    _workItem = f_WorkItem;

                    Current_Case.WorkItems.Add(f_WorkItem);
                }
                else
                {
                    var _performerConditions =
                        _task.L_TaskConditions
                        .Where(x => x.EnableRecord)
                        .Select(x => x.Condition.Id);

                    var _users = await _db.L_UserConditions
                        .Where(x => _performerConditions.Contains(x.FirstId))
                        .Where(x => x.EnableRecord)
                        .AsNoTracking()
                        .Select(x => x.FirstId.Value)
                        .ToListAsync();

                    foreach (var _user in _users)
                    {
                        f_WorkItem = new()
                        {
                            Case = Current_Case,
                            TaskId = _task.Id,
                            UserId = _user
                        };
                        Current_Case.WorkItems.Add(f_WorkItem);
                    }
                    if (!Current_Case.WorkItems
                      .Where(x => x.TaskId == _task.Id)
                      .Any())
                    {
                        throw new ArgumentNullException($"There aren't any related users for {Current_Case.Name}");
                    }
                }
            }
            if (Current_WorkItem is not null)
            {
                _workItem = Current_WorkItem;
            }

            await SetCurrentAssignment(_workItem);

            return OutputState<Boolean>.Success("با موفقیت ایجاد شد.", true);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request)
    {
        var GeneralRequest = await _iCopyClass.DeepCopy(request);

        CheetahResult<F_Case> _OutputState = new();

        var DuplicateCase = _db.F_Cases
            .Where(x => x.ProcessId == GeneralRequest.ProcessId)
            .Where(x => x.ERPCode == GeneralRequest.ERPCode)
            .Where(x => x.CaseStateId == D_CaseState.Ongoing.Id || x.CaseStateId == D_CaseState.Editing.Id)
            .Where(x => x.EnableRecord == true)
            .AsNoTracking();

        var CaseID = await DuplicateCase.Select(x => x.Id).FirstOrDefaultAsync();

        if (CaseID is not null)
        {
            _OutputState = OutputState<F_Case>.DuplicateErrorCreateRequest(CaseID, GeneralRequest);

            return _OutputState;
        }

        await _db.F_Cases.AddAsync(GeneralRequest);

        await SetWorkItemsAsync(GeneralRequest);

        await _db.SaveChangesAsync();

        var log = new LoggerConfiguration()
                     .WriteTo.Console()
                     .WriteTo.File("Serilog.txt")
                     .CreateLogger();

        _OutputState = OutputState<F_Case>.SuccessCreateRequest(GeneralRequest.Id, GeneralRequest);

        log.Information($"CreateRequestAsync-{GeneralRequest.Id}");

        return _OutputState;
    }
    public async Task<CheetahResult<F_WorkItem>> PerformWorkItemAsync(F_WorkItem f_WorkItem, Boolean Rebase = false)
    {
        CheetahResult<F_WorkItem> _OutputState = new();

        var Current_WorkItem = await _db.F_WorkItems
              .Where(x => x.Id == f_WorkItem.Id)
              .Include(x => x.Case)
              .ThenInclude(x => x.WorkItems)
              .ThenInclude(x => x.Task)
              .Include(x => x.Case)
              .ThenInclude(x => x.CaseConditions)
              .ThenInclude(x => x.Condition)
              .FirstAsync();

        var _prevConditions = Current_WorkItem.Case.CaseConditions.Select(x => x.Condition);

        var _conditions = await _iCopyClass.CopyCondition(Current_WorkItem.WorkItemConditions.Select(x => x.Condition));

        foreach (var _condition in _conditions)
        {
            L_WorkItemCondition _workItemCondition = new()
            {
                WorkItem = Current_WorkItem,
                FirstId = Current_WorkItem.Id,
                Condition = _condition,
                SecondId = _condition.Id
            };
            Current_WorkItem.WorkItemConditions.Add(_workItemCondition);
        }

        if (Current_WorkItem.LastModified is not null && Rebase == false)
        {
            _OutputState = OutputState<F_WorkItem>.PreviouslySentErrorCreateRequest(Current_WorkItem.Id, Current_WorkItem);

            return _OutputState;
        }

        var _currentAssignment = await SetCurrentAssignment(Current_WorkItem);

        if (Current_WorkItem.Case.IsEditing())
        {
            Current_WorkItem.Case.WorkItems
                .Where(x => !x.IsExit() && !x.IsSent())
                .ToList().ForEach(x => x.SetExit());

            await SetWorkItemsAsync(Current_WorkItem.Case, Current_WorkItem);
        }

        _db.F_WorkItems.Update(_currentAssignment.Result.Value);

        await _db.SaveChangesAsync();

        _OutputState = OutputState<F_WorkItem>.SuccessPerformWorkItem(Current_WorkItem.Id, Current_WorkItem);

        return _OutputState;
    }
    public CheetahResult<bool> CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions)
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

                switch (Operand_Name)
                {
                    case string Greater when Current_Value > Scenario_Value && Greater == D_Operand.Greater.Name:
                    case string EqualAndGreater when Current_Value >= Scenario_Value && EqualAndGreater == D_Operand.EqualAndGreater.Name:
                    case string LessThan when Current_Value < Scenario_Value && LessThan == D_Operand.LessThan.Name:
                    case string LessThanOrEqual when Current_Value <= Scenario_Value && LessThanOrEqual == D_Operand.LessThanOrEqual.Name:
                    case string Equals when Current_Value == Scenario_Value && Equals == D_Operand.Equals.Name:
                    case string NotEquals when Current_Value != Scenario_Value && NotEquals == D_Operand.NotEquals.Name:
                        ConditionOccur++;
                        break;
                }


            }
        }
        CheetahResult<bool> _OutputState = new();

        if (ConditionOccur == cnt_con)
        {
            _OutputState = OutputState<bool>.Success("همانند است", true);
        }
        else
        {
            _OutputState = OutputState<bool>.Success("همانند نیست", false);
        }
        return _OutputState;
    }
    public async Task<CheetahResult<F_WorkItem>> SetCurrentAssignment(F_WorkItem Current_WorkItem)
    {
        Current_WorkItem.Case.LastModified = DateTimeOffset.Now;

        var WorkItemTaskId = Current_WorkItem.TaskId;

        var WorkItemTask = await _db.F_Tasks
            .Where(x => x.Id == Current_WorkItem.TaskId)
            .SingleAsync();

        var ActualConditions = Current_WorkItem.Case.CaseConditions.Select(x => x.Condition);

        var TaskItems = await _db.L_TaskFlows
           .Where(x => x.FirstId == WorkItemTaskId)
           .Select(x => x.Flow)
           .ToListAsync();

        foreach (var TaskItem in TaskItems)
        {
            var ExpectedConditions = TaskItem.FlowConditions.Select(x => x.Condition);

            foreach (var ExpectedCondition in ExpectedConditions)
            {
                var ExpectedConditionList = new List<F_Condition>();

                ExpectedConditionList.Add(ExpectedCondition);


                if (CompareCondition(ActualConditions, ExpectedConditionList).Result.Value)
                {

                    //Current_WorkItem.Case.CaseStateId =
                    //    TaskItem.CaseStateId;

                    //Current_WorkItem.Conditions = ActualConditions;

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

                        if (Current_WorkItem.CaseId.HasValue)
                        {
                            var OtherWorkItems = Current_WorkItem.Case.WorkItems
                                .Where(x => x.Task is not null)
                                .Where(x => x.Task.SortIndex <= WorkItemTask.SortIndex)
                                .Where(x => x.IsInbox() || x.IsFuture());

                            foreach (var OtherWorkItem in OtherWorkItems)
                            {
                                OtherWorkItem.SetExit();
                            }
                        }
                        #endregion

                        #region Set inbox

                        var toTasks = TaskItem?.TaskFlows?
                            .Select(x => x.Task);

                        foreach (var toTask in toTasks)
                        {
                            var _Current_WorkItems =
                                Current_WorkItem.Case.WorkItems
                                .Where(x => x.TaskId == toTask.Id)
                                .Where(x => !x.IsSent() && !x.IsExit());


                            var _caseTaskUsers = await _db.L_CaseTaskUsers
                                .Where(x => x.Case.Id == Current_WorkItem.CaseId)
                                .Where(x => x.Task.Id == toTask.Id)
                                .ToListAsync();

                            if (_caseTaskUsers.Any())
                            {
                                var _users = _caseTaskUsers.Select(x => x.User?.Id.Value);

                                _Current_WorkItems
                                    .Where(x => _users.Any(y => y == x.UserId))
                                    .ToImmutableList()
                                    .ForEach(x => x.SetInbox());

                                _Current_WorkItems
                                    .Where(x => !_users.Any(y => y == x.UserId))
                                    .ToImmutableList()
                                    .ForEach(x => x.SetExit());
                            }
                            else
                            {
                                _Current_WorkItems
                                    .ToList()
                                    .ForEach(x => x.SetInbox());
                            }
                            #endregion

                        }

                        Current_WorkItem.Case.WorkItems
                        .Where(x => x.WorkItemStateId is null)
                        .ToList().ForEach(x => x.SetFuture());
                    }


                }
            }
        }

        return OutputState<F_WorkItem>.Success("با موفقیت ایجاد شد", Current_WorkItem);
    }
    public async Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUser(L_CaseTaskUser CaseTaskUser)
    {
        var _CaseTaskUser = await _iCopyClass.DeepCopy(CaseTaskUser);

        var _selectedCaseTaskUsers = _db.L_CaseTaskUsers
            .Where(x => x.Case.Id == CaseTaskUser.Case.Id)
            .Where(x => x.Task.Id == CaseTaskUser.Task.Id);

        var _result = _selectedCaseTaskUsers
            .Include(x => x.Case)
            .Include(x => x.Task)
            .Include(x => x.User);

        if (!await _selectedCaseTaskUsers.AnyAsync())
        {
            await _db.L_CaseTaskUsers.AddAsync(_CaseTaskUser);

            await _db.SaveChangesAsync();
        }

        var _caseTaskUsers = await _result.FirstOrDefaultAsync();

        return OutputState<L_CaseTaskUser>.Success("با موفقیت ایجاد شد", _caseTaskUsers);
    }
}