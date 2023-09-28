using Cheetah.Domain.Data;
using Cheetah.Domain.Facts;

namespace Cheetah.Application.Business.Repository;
public interface IWorkItem
{
    public Task SetCurrentAssignment(F_WorkItem f_WorkItem);
    public Task SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
    public Task<Tuple<F_Case, SimpleClassDTO>> CreateRequestAsync(F_Case request);
    public Task<Tuple<F_WorkItem, SimpleClassDTO>> PerformWorkItemAsync(F_WorkItem f_WorkItem);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions,
        IEnumerable<F_Condition> Expected_Conditions);
}