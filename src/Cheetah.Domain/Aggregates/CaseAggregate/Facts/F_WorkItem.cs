namespace Cheetah.Domain.Entities.Facts;

public partial class F_WorkItem : BaseEntity
{
    #region Entities

    public long? TaskId { get; set; }
    public long? UserId { get; set; }    
    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }
    public long? WorkItemStateId { get; set; }
    public virtual D_WorkItemState? WorkItemState { get; set; }

    #endregion

    #region Collection    
    public virtual ICollection<L_WorkItemCondition>? WorkItemConditions { get; set; } = new HashSet<L_WorkItemCondition>();

    #endregion

    #region Functions
    public F_WorkItem ShallowCopy()
    {
        return (F_WorkItem)MemberwiseClone();
    }

    #region Getter
    public bool IsInbox()
    {
        return WorkItemStateId == D_WorkItemState.Inbox.Id;
    }
    public bool IsSent()
    {
        return WorkItemStateId == D_WorkItemState.Sent.Id;
    }
    public bool IsExit()
    {
        return WorkItemStateId == D_WorkItemState.Exit.Id;
    }
    public bool IsFuture()
    {
        return WorkItemStateId == D_WorkItemState.Future.Id;
    }

    #endregion

    #region Setter
    public void SetInbox()
    {
        WorkItemStateId = D_WorkItemState.Inbox.Id;
    }
    public void SetSent()
    {
        WorkItemStateId = D_WorkItemState.Sent.Id;
        //LastModified = DateTimeOffset.Now;
    }
    public void SetExit()
    {
        WorkItemStateId = D_WorkItemState.Exit.Id;
    }
    public void SetFuture()
    {
        WorkItemStateId = D_WorkItemState.Future.Id;
    }

    #endregion

    #endregion
}