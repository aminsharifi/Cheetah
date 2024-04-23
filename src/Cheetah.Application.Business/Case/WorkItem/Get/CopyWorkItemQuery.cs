namespace Cheetah.Application.Business.WorkItem.Get;

public record CopyWorkItemQuery(F_WorkItem WorkItem, D_User User) : IQuery<Result<F_WorkItem>>;