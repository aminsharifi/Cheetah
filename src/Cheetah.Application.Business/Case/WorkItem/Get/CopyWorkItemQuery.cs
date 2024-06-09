namespace Cheetah.Application.Business.WorkItem.Get;

public record CopyWorkItemQuery(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, Boolean Rebase = false) : IQuery<Result<F_WorkItem>>;