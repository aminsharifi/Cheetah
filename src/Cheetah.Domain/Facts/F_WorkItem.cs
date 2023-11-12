﻿namespace Cheetah.Domain.Facts;

public partial class F_WorkItem : SimpleClass
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
        return (F_WorkItem)this.MemberwiseClone();
    }

    #region Getter
    public Boolean IsInbox()
    {
        return (WorkItemStateId == 1);
    }
    public Boolean IsSent()
    {
        return (WorkItemStateId == 2);
    }
    public Boolean IsExit()
    {
        return (WorkItemStateId == 3);
    }
    public Boolean IsFuture()
    {
        return (WorkItemStateId == 4);
    }
    public Boolean IsAborted()
    {
        return (WorkItemStateId == 5);
    }
    public Boolean IsApprove()
    {
        return (TagId == 201);
    }
    public Boolean IsReject()
    {
        return (TagId == 202);
    }
    public Boolean IsRevise()
    {
        return (TagId == 203);
    }

    #endregion

    #region Setter
    public void SetInbox()
    {
        WorkItemStateId = 1;
    }
    public void SetSent()
    {
        WorkItemStateId = 2;
    }
    public void SetExit()
    {
        WorkItemStateId = 3;
    }
    public void SetFuture()
    {
        WorkItemStateId = 4;
    }
    public void SetAborted()
    {
        WorkItemStateId = 5;
    }
    public void SetApprove()
    {
        TagId = 201;
    }
    public void SetReject()
    {
        TagId = 202;
    }
    public void SetRevise()
    {
        TagId = 203;
    }


    #endregion

    #endregion

}