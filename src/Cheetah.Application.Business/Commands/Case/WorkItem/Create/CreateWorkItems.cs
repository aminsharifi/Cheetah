using Cheetah.Application.Business.Queries.Process.TaskEntity.List;
using Cheetah.Application.Business.Queries.User.UserCondition.List;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Commands.Case.WorkItem.Create;

public static class CreateWorkItems
{
    public static async Task<F_Case> Handle(ISender iSender, F_Case f_Case)
    {
        var _allTasks = (await iSender
            .Send(new ListTasksFromScenarioQuery(f_Case.SelectedScenarioId.Value))).Value;

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
                    .Where(x => x.SecondId != null)
                    .Select(x => x.SecondId!.Value);

                var _CaseCondition =
                    f_Case.CaseConditions
                    .Where(x => x.EnableRecord)
                    .Where(x => x.SecondId != null)
                    .Select(x => x.SecondId!.Value);

                var _taskUserConditions = (await iSender.Send(new ListUsersByConditionQuery(_performerConditions))).Value;

                var _CaseUserConditions = (await iSender.Send(new ListUsersByCaseConditionQuery(_taskUserConditions, _CaseCondition))).Value;

                var _userIds = new List<long>();

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
                    F_WorkItem _WorkItemForEachTask = new F_WorkItem()
                    .SetCase(f_Case)
                    .SetTaskId(_task.Id)
                    .SetUserId(_userId);

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
