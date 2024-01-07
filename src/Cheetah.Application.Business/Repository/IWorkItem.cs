namespace Cheetah.Application.Business.Repository;
public interface IWorkItem
{

    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request);
    public Task<CheetahResult<F_WorkItem>> PerformWorkItemAsync(F_WorkItem f_WorkItem, Boolean Rebase = false);
    public CheetahResult<Boolean> CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<CheetahResult<F_WorkItem>> SetCurrentAssignment(F_WorkItem Current_WorkItem);
    public Task<CheetahResult<List<L_CaseEndorsementUser>>> SetCaseEndorsementUser(L_CaseEndorsementUser CaseEndorsementUser);
}