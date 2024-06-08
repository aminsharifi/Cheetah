namespace Cheetah.Application.Business.Services;
public class WorkItem(ICopyClass _iCopyClass,
    ISender iSender, IMemoryCache _cache,
    IRepository<F_WorkItem> workItemRepository,
    IRepository<F_Case> caseRepository,
    IRepository<F_Task> taskRepository,
    IRepository<D_User> userRepository,
    IRepository<F_Condition> conditionRepository,
    IRepository<D_Process> processRepository
    ) : IWorkItem
{
    public async Task<Result<long>> CreateRequestAsync(SimpleClassDTO Case, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase)
    {
        var GeneralRequest = await iSender.Send(new CopyCaseQuery(Case, Creator, Requestor, Process,
            CaseConditions, WorkItemUser, WorkItemConditions));

        var _getCaseSpec = new GetIdCaseSpec(processId: GeneralRequest.Value.ProcessId.Value,
        eRPCode: GeneralRequest.Value.ERPCode.Value);

        Result<long> _OutputState;

        if (await caseRepository.AnyAsync(_getCaseSpec))
        {
            var _caseID = await caseRepository.FirstOrDefaultAsync(_getCaseSpec);

            _OutputState = Result<long>.Conflict();

            return _OutputState;
        }
        else
        {
            await SetWorkItemsAsync(Current_Case: GeneralRequest, WorkItemBase: WorkItemBase);

            GeneralRequest.Value.UpdateLastModified();

            var _createdCase = await caseRepository.AddAsync(GeneralRequest);

            _OutputState = Result<long>.Success(_createdCase.Id);
        }

        return _OutputState;
    }
    public async Task<Result<long>> PerformWorkItemAsync(
        SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, Boolean Rebase = false, SimpleClassDTO? WorkItemBase = null)
    {
        Result<long> _OutputState;

        F_WorkItem Current_WorkItem = await iSender.Send(new CopyWorkItemQuery(
            WorkItem, WorkItemUser, WorkItemConditions, Rebase));

        if (Current_WorkItem.LastModified is not null && !Rebase)
        {
            _OutputState = Result<long>.Conflict(WorkItem.Id.ToString());
            return _OutputState;
        }

        if (WorkItemBase is not null)
        {
            Current_WorkItem.SetDisplayName(WorkItemBase.DisplayName);
        }

        var _setCurrentAssignmentAsync = await SetCurrentAssignmentAsync(Current_WorkItem);

        Current_WorkItem = _setCurrentAssignmentAsync;

        if (Current_WorkItem.Case.IsEditing())
        {
            Current_WorkItem.Case.WorkItems
                .Where(x => !x.IsExit() && !x.IsSent())
                .ToList().ForEach(x => x.SetExit());

            await SetWorkItemsAsync(Current_WorkItem.Case, Current_WorkItem);
        }

        await workItemRepository.UpdateAsync(_setCurrentAssignmentAsync);

        _OutputState = Result<long>.Success(WorkItem.Id);

        return _OutputState;
    }
    public async Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser)
    {
        var _selectedCaseTaskUsers = (await iSender.Send(
            new GetByCaseAndTaskQuery(caseId: CaseTaskUser.FirstId,
            taskId: CaseTaskUser.SecondId.Value))).Value;

        if (_selectedCaseTaskUsers.Any())
        {
            var _addedCaseTaskUsers = (await iSender.Send(
            new CreateCaseTaskUserQuery(CaseTaskUser))).Value;

            _selectedCaseTaskUsers.Append(_addedCaseTaskUsers);
        }

        return Result<L_CaseTaskUser>.Success(CaseTaskUser, "با موفقیت ایجاد شد");
    }
    public async Task<IEnumerable<F_Task>> GetAllTask(Int64 ScenarioId)
    {
        var _allTasks = (await iSender.Send(new GetTasksFromScenarioQuery(ScenarioId))).Value;

        return _allTasks;
    }
    public async Task<Result<bool>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null, SimpleClassDTO? WorkItemBase = null)
    {
        var pc_ProcessScenarios = (await iSender.Send(new GetProcessScenarioQuery(Current_Case.ProcessId.Value))).Value;

        if (pc_ProcessScenarios.Count() == 1)
        {
            Current_Case.SetSelectedScenario(pc_ProcessScenarios.First().SecondId);
        }
        else
        {
            var Actual_ConditionsIds = Current_Case.CaseConditions.Select(x => x.SecondId.Value);

            var Actual_Conditions = (await iSender.Send(new GetIncludedConditionsQuery(Actual_ConditionsIds))).Value;

            foreach (var ProcessScenario in pc_ProcessScenarios)
            {
                var ConditionOccures = false;

                var Expected_ConditionsIds = ProcessScenario
                    .Scenario.ScenarioConditions.Select(x => x.SecondId);

                var Expected_Conditions = (await iSender.Send(new GetIncludedConditionsQuery(Actual_ConditionsIds))).Value;

                ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions);

                if (ConditionOccures)
                {
                    Current_Case.SetSelectedScenario(ProcessScenario.Scenario.Id);
                    break;
                }
            }
        }

        var _allTasks = await GetAllTask(Current_Case.SelectedScenarioId.Value);

        F_WorkItem _workItem = new();

        _workItem.SetCase(Current_Case);

        foreach (var _task in _allTasks)
        {
            if (Current_Case.WorkItems.First().TaskId is null)
            {
                Current_Case.WorkItems.First().SetTaskId(_task.Id);

                _workItem = Current_Case.WorkItems.First();
                _workItem.SetCase(Current_Case);
            }
            else
            {
                var _performerConditions =
                    _task.TaskConditions
                    .Where(x => x.EnableRecord)
                    .Select(x => x.SecondId);

                var _CaseCondition =
                    Current_Case.CaseConditions
                    .Where(x => x.EnableRecord)
                    .Select(x => x.SecondId);

                var _taskUserConditions = (await iSender.Send(new GetUserByConditionQuery(_performerConditions))).Value;

                var _CaseUserConditions = (await iSender.Send(new GetUserByCaseConditionQuery(_taskUserConditions, _CaseCondition))).Value;

                var _userIds = new List<Int64?>();

                if (_CaseUserConditions.Any())
                {
                    _userIds = _CaseUserConditions.ToList();
                }
                else
                {
                    _userIds = _taskUserConditions.ToList();
                }

                Parallel.ForEach(_userIds, _userId =>
                {
                    F_WorkItem _WorkItemForEachTask = new(taskId: _task.Id, userId: _userId, f_case: Current_Case);

                    Current_Case.WorkItems.Add(_WorkItemForEachTask);
                });

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
        if (WorkItemBase is not null)
        {
            _workItem.SetDisplayName(WorkItemBase.DisplayName);
        }

        await SetCurrentAssignmentAsync(_workItem);

        return Result<Boolean>.Success(true, "با موفقیت ایجاد شد.");
    }
    public bool CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions)
    {
        var _notSame = Expected_Conditions.Where(x => !Actual_Conditions.Select(y => y.Id).Contains(x.Id)).Any();

        if (!_notSame)
        {
            return true;
        }

        var cnt_con = Expected_Conditions.Count();

        var ConditionOccur = 0;

        Parallel.ForEach(Expected_Conditions, _expected_Condition =>
        {
            var Operand_Name = _expected_Condition.Operand.Name;

            switch (Operand_Name)
            {
                case string Equals when Actual_Conditions
                .Where(x => x.TagId == _expected_Condition.TagId)
                .Where(x => x.Value == _expected_Condition.Value)
                .Any() && Equals == D_Operand.Equals.Name:

                case string NotEquals when Actual_Conditions
                .Where(x => x.TagId == _expected_Condition.TagId)
                .Where(x => x.Value != _expected_Condition.Value)
                .Any() && NotEquals == D_Operand.NotEquals.Name:
                    ConditionOccur++;
                    break;
            }
        });

        var _isTheSame = (ConditionOccur == cnt_con);

        return _isTheSame;
    }
    public async Task<Result<F_WorkItem>> SetCurrentAssignmentAsync(F_WorkItem Current_WorkItem)
    {
        var _currentTaskId = Current_WorkItem.TaskId;

        var _taskFlows = await iSender.Send(new GetFlowsByTaskQuery(_currentTaskId.Value));

        var _actualConditionsIds = Current_WorkItem.WorkItemConditions.Select(x => x.SecondId.Value);

        var _actual_Conditions = await iSender.Send(new GetIncludedConditionsQuery(_actualConditionsIds));

        foreach (var _taskFlow in _taskFlows.Value)
        {
            var ExpectedConditionsIds = _taskFlow.Flow.FlowConditions
                .Select(x => x.SecondId.Value);

            var ExpectedConditions = (await iSender.Send(
        new GetIncludedConditionsQuery(ExpectedConditionsIds))).Value;

            if (CompareCondition(_actual_Conditions.Value, ExpectedConditions))
            {
                Current_WorkItem.Case.SetCaseStateId(_taskFlow.Flow.CaseStateId);

                Current_WorkItem.SetSent();

                if (Current_WorkItem.Case.IsAborted())
                {
                    Current_WorkItem.Case.WorkItems
                        .Where(x => !x.IsExit() && !x.IsSent())
                        .ToList().ForEach(x => x.SetExit());
                }
                else
                {
                    #region Exit Current work items

                    if (Current_WorkItem.CaseId.HasValue)
                    {

                        var OtherWorkItems = Current_WorkItem.Case.WorkItems
                            .Where(x => x.TaskId is not null)
                            .Where(x => x.IsInbox() || x.IsFuture());

                        foreach (var OtherWorkItem in OtherWorkItems)
                        {
                            var _sortIndex = await taskRepository
                            .FirstOrDefaultAsync(new GetSortIndexTask(OtherWorkItem.TaskId));

                            if (_sortIndex <= _taskFlow.Task.SortIndex)
                            {
                                OtherWorkItem.SetExit();
                            }

                        }
                    }
                    #endregion

                    #region Set inbox

                    var toTasks = _taskFlow?.Flow?.FlowTasks
                        .Select(x => x.Task);

                    await Parallel.ForEachAsync(toTasks, async (toTask, cancellationToken) =>
                    {
                        var _Current_WorkItems =
                         Current_WorkItem.Case.WorkItems
                         .Where(x => x.TaskId == toTask.Id)
                         .Where(x => !x.IsSent() && !x.IsExit());

                        var _selectedUser = false;

                        if (Current_WorkItem.CaseId is not null or 0)
                        {
                            var _caseTaskUsers = (await iSender.Send(
                            new GetByCaseAndTaskQuery(
                                caseId: Current_WorkItem.CaseId.Value, taskId: toTask.Id))).Value;

                            if (_caseTaskUsers.Any())
                            {
                                var _users = _caseTaskUsers.Select(x => x.ThirdId);

                                _Current_WorkItems
                                    .Where(x => _users.Any(y => y == x.UserId))
                                    .ToList()
                                    .ForEach(x => x.SetInbox());

                                _Current_WorkItems
                                    .Where(x => !_users.Any(y => y == x.UserId))
                                    .ToList()
                                    .ForEach(x => x.SetExit());
                                _selectedUser = true;
                            }
                        }

                        if (!_selectedUser)
                        {
                            _Current_WorkItems
                                 .ToList()
                                 .ForEach(x => x.SetInbox());
                        }
                    });

                    #endregion

                    Current_WorkItem.Case.WorkItems
                    .Where(x => x.WorkItemStateId is null)
                    .ToList().ForEach(x => x.SetFuture());
                }
            }
        }
        return Result<F_WorkItem>.Success(Current_WorkItem, "با موفقیت ایجاد شد");
    }
}