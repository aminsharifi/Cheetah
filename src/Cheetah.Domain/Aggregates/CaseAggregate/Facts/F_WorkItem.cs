namespace Cheetah.Domain.Entities.Facts;

public partial class F_WorkItem : BaseEntity
{
    #region Entities
    public long? TaskId { get; private set; }
    public long? UserId { get; private set; }
    public long? CaseId { get; private set; }
    public virtual F_Case? Case { get; private set; }
    public long? WorkItemStateId { get; private set; }
    public virtual D_WorkItemState? WorkItemState { get; private set; }

    #endregion

    #region Collection    
    public virtual ICollection<L_WorkItemCondition>? WorkItemConditions { get; set; } = new HashSet<L_WorkItemCondition>();

    #endregion

    #region Functions

    public F_WorkItem()
    {

    }

    public F_WorkItem SetCase(F_Case? f_Case)
    {
        this.Case = Guard.Against.Null(f_Case,nameof(f_Case));
        return this;
    }
    public F_WorkItem SetTaskId(long? taskId)
    {
        this.TaskId = Guard.Against.Null(taskId);
        return this;
    }
    public F_WorkItem SetUserId(long? userId)
    {
        this.UserId = Guard.Against.Null(userId);
        return this;
    }

    #region WorkItemState
    public F_WorkItem SetInbox()
    {
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
        return this;
    }
    public bool IsExit()
    {
        return WorkItemStateId == D_WorkItemState.Exit.Id;
    }
    public F_WorkItem SetFuture()
    {
        this.WorkItemStateId = D_WorkItemState.Future.Id;
        return this;
    }   
    public bool IsFuture()
    {
        return WorkItemStateId == D_WorkItemState.Future.Id;
    }
    #endregion

    public F_WorkItem ShallowCopy()
    {
        return (F_WorkItem)MemberwiseClone();
    }

    #endregion
}