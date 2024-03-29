namespace Cheetah.Infrastructure.Persistence.Services;
public class WorkItem(ICopyClass _iCopyClass, IMediator _mediator,
    IRepository<F_WorkItem> workItemRepository, IRepository<F_Case> caseRepository) : IWorkItem
{
    public async Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request)
    {
        CheetahResult<F_Case> _OutputState = new();

        var GeneralRequest = (await _mediator.Send(new CopyCaseQuery(request))).Value;

        var _getCaseSpec = new GetIdCaseSpec(processId: GeneralRequest.ProcessId.Value,
        eRPCode: GeneralRequest.ERPCode.Value);

        if (await caseRepository.AnyAsync(_getCaseSpec))
        {
            var _caseID = await caseRepository.FirstOrDefaultAsync(_getCaseSpec);

            _OutputState = OutputState<F_Case>.DuplicateErrorCreateRequest(_caseID, GeneralRequest);

            return _OutputState;
        }
        else
        {
            var _retGeneralRequest = await SetWorkItemsAsync(GeneralRequest);

            await caseRepository.AddAsync(GeneralRequest);

            _OutputState = OutputState<F_Case>.SuccessCreateRequest(GeneralRequest.Id, GeneralRequest);
        }

        return _OutputState;
    }
    public async Task<CheetahResult<F_Case>> PerformWorkItemAsync(F_WorkItem f_WorkItem, Boolean Rebase = false)
    {
        CheetahResult<F_Case> _OutputState = new();

        F_WorkItem Current_WorkItem = await _iCopyClass.DeepCopy(f_WorkItem);

        await workItemRepository.UpdateAsync(Current_WorkItem);

        /*
        _db.F_WorkItems.Update(Current_WorkItem);

        await _db.SaveChangesAsync();

        */

        if (Current_WorkItem.LastModified is not null && !Rebase)
        {
            _OutputState = OutputState<F_Case>.PreviouslySentErrorCreateRequest(Current_WorkItem.Id, Current_WorkItem.Case);

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

        //await _db.SaveChangesAsync();

        _OutputState = OutputState<F_Case>.SuccessPerformWorkItem(Current_WorkItem.Id, Current_WorkItem.Case);

        return _OutputState;
    }
    public async Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUser(L_CaseTaskUser CaseTaskUser)
    {
        var _CaseTaskUser = await _iCopyClass.DeepCopy(CaseTaskUser);

        //var _selectedCaseTaskUsers = _db.L_CaseTaskUsers
        //    .Where(x => x.Case.Id == CaseTaskUser.Case.Id)
        //    .Where(x => x.Task.Id == CaseTaskUser.Task.Id);

        //var _result = _selectedCaseTaskUsers
        //    .Include(x => x.Case)
        //    .Include(x => x.Task)
        //    .Include(x => x.User);

        var _selectedCaseTaskUsers = (await _mediator.Send(
            new GetByCaseAndTaskQuery(caseId: CaseTaskUser.Case.Id,
            taskId: CaseTaskUser.Task.Id))).Value;

        if (_selectedCaseTaskUsers.Any())
        {
            var _addedCaseTaskUsers = (await _mediator.Send(
            new CreateCaseTaskUserQuery(CaseTaskUser))).Value;

            _selectedCaseTaskUsers.Append(_addedCaseTaskUsers);
        }

        return OutputState<L_CaseTaskUser>.Success("با موفقیت ایجاد شد", CaseTaskUser);
    }
    public async Task<IEnumerable<F_Task>> GetAllTask(Int64 ScenarioId)
    {
        var _allTasks = (await _mediator.Send(new GetTasksFromScenarioQuery(ScenarioId))).Value;

        return _allTasks;
    }
    public async Task<CheetahResult<bool>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null)
    {
        var pc_ProcessScenarios = (await _mediator.Send(new GetProcessScenarioQuery(Current_Case.ProcessId.Value))).Value;

        if (pc_ProcessScenarios.Count() == 1)
        {
            Current_Case.SelectedScenarioId = pc_ProcessScenarios.First().SecondId;
        }
        else
        {
            var Actual_ConditionsIds = Current_Case.CaseConditions.Select(x => x.SecondId.Value);

            var Actual_Conditions = (await _mediator.Send(new GetIncludedConditionsQuery(Actual_ConditionsIds))).Value;

            foreach (var ProcessScenario in pc_ProcessScenarios)
            {
                var ConditionOccures = false;

                var Expected_Conditions = ProcessScenario
                    .Scenario
                    .ScenarioConditions
                    .Select(x => x.Condition);

                ConditionOccures = CompareCondition(Actual_Conditions, Expected_Conditions);

                if (ConditionOccures)
                {
                    Current_Case.SelectedScenarioId = ProcessScenario.Scenario.Id;
                    break;
                }
            }
        }

        var _allTasks = await GetAllTask(Current_Case.SelectedScenarioId.Value);

        F_WorkItem _workItem = new() { Case = Current_Case };

        foreach (var _task in _allTasks)
        {
            if (Current_Case.WorkItems.First().TaskId is null)
            {
                Current_Case.WorkItems.First().TaskId = _task.Id;
                _workItem = Current_Case.WorkItems.First();
                _workItem.Case = Current_Case;
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

                //var _taskUserConditions = await _db.L_UserConditions
                //    .Where(x => _performerConditions.Contains(x.SecondId))
                //    .Where(x => x.EnableRecord)
                //    .AsNoTracking()
                //    .Select(x => x.FirstId)
                //    .ToListAsync();

                var _taskUserConditions = (await _mediator.Send(new GetUserByConditionQuery(_performerConditions))).Value;

                //var _CaseUserConditions = await _db.L_UserConditions
                //    .Where(x => _taskUserConditions.Contains(x.FirstId))
                //    .Where(x => _CaseCondition.Contains(x.SecondId))
                //    .Where(x => x.EnableRecord)
                //    .AsNoTracking()
                //    .Select(x => x.FirstId)
                //    .ToListAsync();

                var _CaseUserConditions = (await _mediator.Send(new GetUserByCaseConditionQuery(_taskUserConditions, _CaseCondition))).Value;

                var _userIds = new List<Int64?>();

                if (_CaseUserConditions.Any())
                {
                    _userIds = _CaseUserConditions.ToList();
                }
                else
                {
                    _userIds = _taskUserConditions.ToList();
                }

                foreach (var _userId in _userIds)
                {
                    F_WorkItem _WorkItemForEachTask = new()
                    {
                        TaskId = _task.Id,
                        UserId = _userId,
                        Case = Current_Case
                    };

                    Current_Case.WorkItems.Add(_WorkItemForEachTask);
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

        //await caseRepository.UpdateAsync(Current_Case);

        return OutputState<Boolean>.Success("با موفقیت ایجاد شد.", true);
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

        foreach (var _expected_Condition in Expected_Conditions)
        {
            var Operand_Name = _expected_Condition.Operand.Name;

            switch (Operand_Name)
            {
                //case string Greater when Current_Value > Scenario_Value && Greater == D_Operand.Greater.Name:
                //case string EqualAndGreater when Current_Value >= Scenario_Value && EqualAndGreater == D_Operand.EqualAndGreater.Name:
                //case string LessThan when Current_Value < Scenario_Value && LessThan == D_Operand.LessThan.Name:
                //case string LessThanOrEqual when Current_Value <= Scenario_Value && LessThanOrEqual == D_Operand.LessThanOrEqual.Name:

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
        }

        var _isTheSame = (ConditionOccur == cnt_con);

        return _isTheSame;
    }
    public async Task<CheetahResult<F_WorkItem>> SetCurrentAssignment(F_WorkItem Current_WorkItem)
    {
        Current_WorkItem.Case.LastModified = DateTimeOffset.Now;

        var _currentTaskId = Current_WorkItem.TaskId;

        //var _taskFlows = await _db.L_TaskFlows
        //   .Where(x => x.FirstId == _currentTaskId)
        //   .Include(x => x.Task)
        //   .Include(x => x.Flow)
        //   .AsNoTracking()
        //   .ToListAsync();

        var _taskFlows = (await _mediator.Send(new GetFlowsByTaskQuery(_currentTaskId.Value))).Value;

        var _actualConditionsIds = Current_WorkItem.WorkItemConditions.Select(x => x.SecondId.Value);

        var _actual_Conditions = (await _mediator.Send(
            new GetIncludedConditionsQuery(_actualConditionsIds))).Value;
        /*
        var _actual_Conditions = await _db.F_Conditions
            .Where(x => _actualConditionsIds.Where(z => z == x.Id).Any())
            .AsNoTracking()
            .ToListAsync();
        */

        foreach (var _taskFlow in _taskFlows)
        {
            var ExpectedConditions = _taskFlow.
                Flow.FlowConditions.
                Select(x => x.Condition)
                .ToList();

            if (CompareCondition(_actual_Conditions, ExpectedConditions))
            {
                Current_WorkItem.Case.CaseStateId = _taskFlow.Flow.CaseStateId;

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
                            .Where(x => x.Task is not null)
                            .Where(x => x.Task.SortIndex <= _taskFlow.Task.SortIndex)
                            .Where(x => x.IsInbox() || x.IsFuture());

                        foreach (var OtherWorkItem in OtherWorkItems)
                        {
                            OtherWorkItem.SetExit();
                        }
                    }
                    #endregion


                    #region Set inbox

                    var toTasks = _taskFlow?.Flow?.FlowTasks
                        .Select(x => x.Task);

                    foreach (var toTask in toTasks)
                    {
                        var _Current_WorkItems =
                            Current_WorkItem.Case.WorkItems
                            .Where(x => x.TaskId == toTask.Id)
                            .Where(x => !x.IsSent() && !x.IsExit());

                        /*
                        var _caseTaskUsers = await _db.L_CaseTaskUsers
                            .Where(x => x.Case.Id == Current_WorkItem.CaseId)
                            .Where(x => x.Task.Id == toTask.Id)
                            .ToListAsync();
                        */

                        var _selectedUser = false;

                        if (Current_WorkItem.CaseId is not null or 0)
                        {
                            var _caseTaskUsers = (await _mediator.Send(
                            new GetByCaseAndTaskQuery(
                                caseId: Current_WorkItem.CaseId.Value, taskId: toTask.Id))).Value;

                            if (_caseTaskUsers.Any())
                            {
                                var _users = _caseTaskUsers.Select(x => x.User?.Id);

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

                        #endregion

                    }
                    Current_WorkItem.Case.WorkItems
                    .Where(x => x.WorkItemStateId is null)
                    .ToList().ForEach(x => x.SetFuture());
                }
            }
        }
        //await workItemRepository.UpdateAsync(Current_WorkItem);
        return OutputState<F_WorkItem>.Success("با موفقیت ایجاد شد", Current_WorkItem);
    }
}