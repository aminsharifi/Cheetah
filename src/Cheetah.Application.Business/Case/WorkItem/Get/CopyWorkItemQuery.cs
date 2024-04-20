namespace Cheetah.Application.Business.WorkItem.Get;

public record CopyWorkItemQuery(F_WorkItem input) : IQuery<Result<F_WorkItem>>;