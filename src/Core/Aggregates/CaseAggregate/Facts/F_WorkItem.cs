using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Common;
using Cheetah.Core.Entities.Dimentions;

namespace Cheetah.Core.Entities.Facts;

public partial class F_WorkItem : BaseEntity
{
    public F_WorkItem()
    {

    }

    #region Case
    public virtual F_Case? Case { get; private set; }
    public long? CaseId { get; private set; }
    public F_WorkItem SetCase(F_Case? f_Case)
    {
        this.Case = Guard.Against.Null(f_Case, nameof(f_Case));
        this.CaseId = f_Case?.Id;
        return this;
    }
    #endregion

    #region Task
    public long? TaskId { get; private set; }
    public F_WorkItem SetTaskId(long? taskId)
    {
        this.TaskId = Guard.Against.Null(taskId, nameof(taskId));
        return this;
    }
    #endregion

    #region User
    public long? UserId { get; private set; }
    public F_WorkItem SetUserId(long? userId)
    {
        this.UserId = Guard.Against.Null(userId, nameof(userId));
        return this;
    } 
    #endregion

    #region WorkItemState
    public long? WorkItemStateId { get; private set; }
    public virtual D_WorkItemState? WorkItemState { get; private set; }
    public F_WorkItem SetInbox()
    {
        this.WorkItemState = D_WorkItemState.Inbox;
        this.WorkItemStateId = D_WorkItemState.Inbox.Id;
        return this;
    }
    public bool IsInbox()
    {
        return WorkItemStateId == D_WorkItemState.Inbox.Id;
    }
    public F_WorkItem SetSent()
    {
        this.WorkItemStateId = D_WorkItemState.Sent.Id;
        this.WorkItemState = D_WorkItemState.Sent;
        SetLastModified(DateTimeOffset.Now);
        return this;
    }
    public bool IsSent()
    {
        return WorkItemStateId == D_WorkItemState.Sent.Id;
    }
    public F_WorkItem SetExit()
    {
        this.WorkItemStateId = D_WorkItemState.Exit.Id;
        this.WorkItemState = D_WorkItemState.Exit;
        return this;
    }
    public bool IsExit()
    {
        return WorkItemStateId == D_WorkItemState.Exit.Id;
    }
    public F_WorkItem SetFuture()
    {
        this.WorkItemStateId = D_WorkItemState.Future.Id;
        this.WorkItemState = D_WorkItemState.Future;
        return this;
    }   
    public bool IsFuture()
    {
        return WorkItemStateId == D_WorkItemState.Future.Id;
    }
    #endregion

    #region Collection    
    public virtual ICollection<L_WorkItemCondition>? WorkItemConditions { get; set; } = new HashSet<L_WorkItemCondition>();
    #endregion

    public F_WorkItem ShallowCopy()
    {
        return (F_WorkItem)MemberwiseClone();
    }   
}