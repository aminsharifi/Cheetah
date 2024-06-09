namespace Cheetah.Application.Business.Process;

public static class GetAllTask
{
    public static async Task<IEnumerable<F_Task>> Handle(ISender iSender, Int64 ScenarioId)
    {
        var _allTasks = (await iSender.Send(new GetTasksFromScenarioQuery(ScenarioId))).Value;

        return _allTasks;
    }
}
