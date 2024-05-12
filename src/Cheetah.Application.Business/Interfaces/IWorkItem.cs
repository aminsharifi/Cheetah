namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{

    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null,
        SimpleClassDTO? WorkItemBase = null);
    public Task<CheetahResult<long>> CreateRequestAsync(SimpleClassDTO Request, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<GRPC_Condition> CaseConditions, SimpleClassDTO WorkItemUser,
        List<GRPC_Condition> WorkItemConditions, SimpleClassDTO WorkItemBase);
    public Task<CheetahResult<long>> PerformWorkItemAsync(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<GRPC_Condition> WorkItemConditions, Boolean Rebase = false, SimpleClassDTO? WorkItemBase = null);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<CheetahResult<F_WorkItem>> SetCurrentAssignmentAsync(F_WorkItem Current_WorkItem);
    public Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
}