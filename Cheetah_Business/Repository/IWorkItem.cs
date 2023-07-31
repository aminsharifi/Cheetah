using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface IWorkItem
    {
        public Task SetInboxAndFuture(Int64 workItem_Id);
        public Task Exit(Int64 workItem_Id);
        public Task SetCurrentAssignment(Int64 workItem_Id);
        public Task SetWorkItemsAsync(Int64 workItem_Id);
        public Task<Int64> CreateRequestAsync(F_Case request);
        public Task PerformWorkItemAsync(F_WorkItem f_WorkItem);
        public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    }
}
