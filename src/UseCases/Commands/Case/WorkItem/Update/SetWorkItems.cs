using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.UseCases.Commands.Case.WorkItem.Create;

namespace Cheetah.UseCases.Commands.Case.WorkItem.Update;

public static class SetWorkItems
{
    public static async Task<Result<F_Case>> Handle
        (ISender iSender, IRepository<F_Task> taskRepository,
        F_Case Current_Case, F_WorkItem Current_WorkItem)
    {
        Current_Case = await SelectScenario.Handle(iSender, Current_Case);

        Current_Case = await CreateWorkItems.Handle(iSender, Current_Case);

        await SetCurrentAssignment.Handle(iSender: iSender, taskRepository: taskRepository,
            Current_WorkItem: Current_WorkItem);

        return Current_Case;
    }
}
