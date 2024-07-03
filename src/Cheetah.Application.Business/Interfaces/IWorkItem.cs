using Cheetah.Application.Business.DTOs.Process;

namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{
    public Task<Result<CreateCase_Response>> CreateRequestAsync(CreateCase_Request request);
    public Task<Result<UpdateWorkItem_Response>> PerformWorkItemAsync(UpdateWorkItem_Request request);
    public Task<Result<CreateCaseTaskUser_Response>> SetCaseTaskUserAsync(CreateCaseTaskUser_Request CaseTaskUser);
    public Task<Result<Boolean>> ClearCasesAsync();

    public Task<Result<Boolean>> ClearProjectAsync();
}