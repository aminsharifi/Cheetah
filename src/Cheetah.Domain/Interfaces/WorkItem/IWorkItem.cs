using Cheetah.Domain.Interfaces.WorkItem.DTOs;

namespace Cheetah.Domain.Interfaces.WorkItem;
public interface IWorkItem
{
    public Task<Result<CreateCase_Response>> CreateRequestAsync(CreateCase_Request request);
    public Task<Result<UpdateWorkItem_Response>> PerformWorkItemAsync(UpdateWorkItem_Request request);
    public Task<Result<UpdateWorkItemUser_Response>> SetCaseTaskUserAsync(UpdateWorkItemUser_Request CaseTaskUser);
    public Task<Result<bool>> ClearCasesAsync();

    public Task<Result<bool>> ClearProjectAsync();
}