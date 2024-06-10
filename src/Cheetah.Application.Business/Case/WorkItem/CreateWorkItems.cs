namespace Cheetah.Application.Business.Case.WorkItem;

public static class CreateWorkItems
{
    public static async Task<F_Case> Handle(ISender iSender, F_Case f_Case)
    {
        var _allTasks = (await iSender
            .Send(new GetTasksFromScenarioQuery(f_Case.SelectedScenarioId.Value))).Value;

        foreach (var _task in _allTasks)
        {
            if (f_Case.WorkItems.First().TaskId is null)
            {
                f_Case.WorkItems.First().SetTaskId(_task.Id);
            }
            else
            {
                var _performerConditions =
                    _task.TaskConditions
                    .Where(x => x.EnableRecord)
                    .Select(x => x.SecondId);

                var _CaseCondition =
                    f_Case.CaseConditions
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
                    F_WorkItem _WorkItemForEachTask = new(taskId: _task.Id, userId: _userId, f_case: f_Case);

                    f_Case.WorkItems.Add(_WorkItemForEachTask);
                });

                if (!f_Case.WorkItems
                  .Where(x => x.TaskId == _task.Id)
                  .Any())
                {
                    throw new ArgumentNullException($"There aren't any related users for {f_Case.Name}");
                }
            }
        }

        return f_Case;
    }
}
