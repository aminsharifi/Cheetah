using Cheetah_Business.Facts;

namespace Cheetah_Business.Repository
{
    public interface IWorkItem
    {
        
        public Task<F_Case> SetInboxAndFuture(F_WorkItem f_WorkItem);
        public Task<F_Case> Exit(F_WorkItem f_WorkItem);
        public Task<F_Case> SetCurrentAssignment(F_WorkItem? f_WorkItem);
        public Task<F_Case> SetWorkItemsAsync(F_Case GeneralRequest);
        public Task<F_Case> CreateRequestAsync(F_Case request);
        public Task<F_Case> PerformWorkItemAsync(F_WorkItem f_WorkItem);
        public Boolean CompareCondition(IEnumerable<F_Condition> Actual_Conditions, IEnumerable<F_Condition> Expected_Conditions);
    }
}
