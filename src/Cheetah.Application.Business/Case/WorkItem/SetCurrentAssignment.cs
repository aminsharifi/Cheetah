namespace Cheetah.Application.Business.Case.WorkItem;

public static class SetCurrentAssignment
{
    public static async Task<Result<F_WorkItem>> Handle(ISender iSender, IRepository<F_Task> taskRepository,
        F_WorkItem Current_WorkItem)
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

            if (CompareConditionClass.Handle(_actual_Conditions.Value, ExpectedConditions))
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
