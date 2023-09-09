using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface IWorkItem
    {
        public Task SetCurrentAssignment(F_WorkItem f_WorkItem);
        public Task SetWorkItemsAsync(F_Case Current_Case, F_WorkItem? Current_WorkItem = null);
        public Task<F_Case> CreateRequestAsync(F_Case request);
        public Task<F_WorkItem> PerformWorkItemAsync(F_WorkItem f_WorkItem);
        public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions,
            IEnumerable<F_Condition> Expected_Conditions);
    }
}
