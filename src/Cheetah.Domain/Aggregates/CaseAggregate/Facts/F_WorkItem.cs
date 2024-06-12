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

    public void SetCase(F_Case? f_Case)
    {
        Case = f_Case;
    }

    public void SetTaskId(long? taskId)
    {
        TaskId = taskId;
    }

    #region Collection    
    public virtual ICollection<L_WorkItemCondition>? WorkItemConditions { get; set; } = new HashSet<L_WorkItemCondition>();

    #endregion

    #region Functions

    public F_WorkItem(Int64 id, String? name, String displayName, Int64 sortIndex, Int64 eRPCode) :
        base(id, name, displayName, sortIndex, eRPCode)
    {

    }
    public F_WorkItem()
    {

    }
    public F_WorkItem(long? userId)
    {
        UserId = userId;
    }

    public F_WorkItem(long? taskId, long? userId, F_Case f_case)
    {
        TaskId = taskId;
        UserId = userId;
        Case = f_case;
    }

    public void SetUserId(long? userId)
    {
        UserId = userId;
    }

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
        UpdateLastModified();
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