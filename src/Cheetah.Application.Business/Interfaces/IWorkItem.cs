namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{

    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<CheetahResult<long>> CreateRequestAsync(SimpleClassDTO Request, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<GRPC_Condition> CaseConditions,
        SimpleClassDTO WorkItemUser, List<GRPC_Condition> WorkItemConditions);
    public Task<CheetahResult<F_Case>> PerformWorkItemAsync(F_WorkItem f_WorkItem, D_User User, Boolean Rebase = false);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<CheetahResult<F_WorkItem>> SetCurrentAssignmentAsync(F_WorkItem Current_WorkItem);
    public Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
}