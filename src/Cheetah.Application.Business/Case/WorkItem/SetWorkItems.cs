using Cheetah.Application.Business.Process;

namespace Cheetah.Application.Business.Case.WorkItem;

public static class SetWorkItems
{
    public static async Task<Result<bool>> Handle(ISender iSender, IRepository<F_Task> taskRepository, F_Case Current_Case, F_WorkItem? Current_WorkItem = null, SimpleClassDTO? WorkItemBase = null)
    {
        Current_Case = await SelectScenario.Handle(iSender, Current_Case);

        Current_Case = await CreateWorkItems.Handle(iSender, Current_Case);

        F_WorkItem _workItem = new();

        _workItem.SetCase(Current_Case);

        if (Current_WorkItem is not null)
        {
            _workItem = Current_WorkItem;
        }

        await SetCurrentAssignment.Handle(iSender, taskRepository, _workItem);

        return Result<bool>.Success(true, "با موفقیت ایجاد شد.");
    }
}
