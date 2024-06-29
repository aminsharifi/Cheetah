namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{
    public Task<Result<CreateCaseResponse>> CreateRequestAsync(CreateCaseRequest request);
    public Task<Result<UpdateCaseResponse>> PerformWorkItemAsync(UpdateCaseRequest request);
    public Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
    public Task<Result<Boolean>> ClearCasesAsync();

    public Task<Result<Boolean>> ClearProjectAsync();
}