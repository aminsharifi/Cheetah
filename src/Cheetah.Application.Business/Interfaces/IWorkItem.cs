using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Application.Business.Interfaces;
public interface IWorkItem
{

    public Task<Result<Boolean>> SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null,
        SimpleClassDTO? WorkItemBase = null);
    public Task<Result<long>> CreateRequestAsync(SimpleClassDTO Request, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase);
    public Task<Result<long>> PerformWorkItemAsync(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, Boolean Rebase = false, SimpleClassDTO? WorkItemBase = null);
    public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    public Task<Result<F_WorkItem>> SetCurrentAssignmentAsync(F_WorkItem Current_WorkItem);
    public Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser);
}