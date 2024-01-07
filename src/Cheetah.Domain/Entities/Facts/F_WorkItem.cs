namespace Cheetah.Domain.Entities.Facts;

public partial class F_WorkItem : BaseEntity
{
    #region Entities

    public long? EndorsementId { get; set; }
    public virtual F_Endorsement? Endorsement { get; set; }

    public long? UserId { get; set; }
    public virtual D_User? User { get; set; }

    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    public long? TagId { get; set; }
    public virtual D_Tag? Tag { get; set; }

    public long? WorkItemStateId { get; set; }
    public virtual D_WorkItemState? WorkItemState { get; set; }

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
    public bool IsApprove()
    {
        return TagId == D_Tag.Approve.Id;
    }
    public bool IsReject()
    {
        return TagId == D_Tag.Reject.Id;
    }
    public bool IsRevise()
    {
        return TagId == D_Tag.Revise.Id;
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
        LastModified = DateTimeOffset.Now;
    }
    public void SetExit()
    {
        WorkItemStateId = D_WorkItemState.Exit.Id;
    }
    public void SetFuture()
    {
        WorkItemStateId = D_WorkItemState.Future.Id;
    }
    public void SetApprove()
    {
        TagId = D_Tag.Approve.Id;
    }
    public void SetReject()
    {
        TagId = D_Tag.Reject.Id;
    }
    public void SetRevise()
    {
        TagId = D_Tag.Revise.Id;
    }


    #endregion

    #endregion
}