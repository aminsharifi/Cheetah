namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{
    public Task<Result<long>> CreateRequestAsync(SimpleClassDTO Request, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase);
    public Task<Result<long>> PerformWorkItemAsync(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, Boolean Rebase = false);
    public Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
}