namespace Cheetah.Application.Business.WorkItem.Get;

public record CopyWorkItemQuery(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<GRPC_Condition> WorkItemConditions, Boolean Rebase = false) : IQuery<Result<F_WorkItem>>;