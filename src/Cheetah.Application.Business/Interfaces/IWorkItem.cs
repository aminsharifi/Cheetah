namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{

    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case Request, D_User Creator, D_User Requestor, D_Process Process,
        List<F_Condition> CaseConditions, D_User WorkItemUser, List<F_Condition> WorkItemConditions);
    public Task<CheetahResult<F_Case>> PerformWorkItemAsync(F_WorkItem f_WorkItem, D_User User, Boolean Rebase = false);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<CheetahResult<F_WorkItem>> SetCurrentAssignmentAsync(F_WorkItem Current_WorkItem);
    public Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
}