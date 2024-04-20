namespace Cheetah.Domain.Entities.Facts;
public partial class F_Case : BaseEntity, IAggregateRoot
{
    #region S_User
    public long? RequestorId { get; set; }

    [NotMapped]
    public virtual D_User? Requestor { get; set; }

    public long? CreatorId { get; set; }

    [NotMapped]
    public virtual D_User? Creator { get; set; }

    #endregion

    #region Enitty       

    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }
    public long? ProcessId { get; set; }

    [NotMapped]
    public virtual D_Process? Process { get; set; }

    public long? SelectedScenarioId { get; set; }

    #endregion

    #region Collection
    public virtual ICollection<L_CaseCondition>? CaseConditions { get; set; } = new HashSet<L_CaseCondition>();
    public virtual ICollection<F_WorkItem>? WorkItems { get; set; } = new HashSet<F_WorkItem>();
    public virtual ICollection<L_CaseTaskUser>? CaseTaskUsers { get; set; } = new HashSet<L_CaseTaskUser>();


    #endregion

    #region Functions
    public F_Case ShallowCopy()
    {
        return (F_Case)MemberwiseClone();
    }

    #region Getter
    public bool IsCreating()
    {
        return CaseStateId is null;
    }
    public bool IsInitializing()
    {
        return CaseStateId == D_CaseState.Initializing.Id;
    }
    public bool IsOngoing()
    {
        return CaseStateId == D_CaseState.Ongoing.Id;
    }
    public bool IsEditing()
    {
        return CaseStateId == D_CaseState.Editing.Id;
    }
    public bool IsCompleted()
    {
        return CaseStateId == D_CaseState.Completed.Id;
    }
    public bool IsAborted()
    {
        return CaseStateId == D_CaseState.Aborted.Id;
    }
    #endregion

    #region Setter
    public void SetEditing()
    {
        CaseStateId = D_CaseState.Editing.Id;
        CaseState = D_CaseState.Editing;
    }
    public void SetAborted()
    {
        CaseStateId = D_CaseState.Aborted.Id;
        CaseState = D_CaseState.Aborted;
    }
    public void SetCompleted()
    {
        CaseStateId = D_CaseState.Completed.Id;
        CaseState = D_CaseState.Completed;
    }
    public void SetOngoing()
    {
        CaseStateId = D_CaseState.Ongoing.Id;
        CaseState = D_CaseState.Ongoing;
    }

    #endregion

    #endregion
}