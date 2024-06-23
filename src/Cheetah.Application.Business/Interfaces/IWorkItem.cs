namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{
    public Task<Result<CreateRequest_Response>> CreateRequestAsync(CreateRequest_Request request);
    public Task<Result<PerformRequest_Response>> PerformWorkItemAsync(PerformRequest_Request request);
    public Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
    public Task<Result<Boolean>> ClearCasesAsync();
}