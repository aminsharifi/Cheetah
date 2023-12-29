using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Repository;
public interface IWorkItem
{
    
    public Task<CheetahResult<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<CheetahResult<F_Case>> CreateRequestAsync(F_Case request);
    public Task<CheetahResult<F_WorkItem>> PerformWorkItemAsync(F_WorkItem f_WorkItem);
    public CheetahResult<Boolean> CompareCondition(IEnumerable<F_Condition> Actual_Conditions,
        IEnumerable<F_Condition> Expected_Conditions);

    public Task<CheetahResult<Boolean>> SetCurrentAssignment(F_WorkItem Current_WorkItem);
}