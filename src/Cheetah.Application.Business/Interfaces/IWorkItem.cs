namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{

    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request);
    public Task<CheetahResult<F_Case>> PerformWorkItemAsync(F_WorkItem f_WorkItem, Boolean Rebase = false);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<CheetahResult<F_WorkItem>> SetCurrentAssignment(F_WorkItem Current_WorkItem);
    public Task<CheetahResult<L_CaseTaskUser>> SetCaseTaskUser(L_CaseTaskUser CaseTaskUser);
}