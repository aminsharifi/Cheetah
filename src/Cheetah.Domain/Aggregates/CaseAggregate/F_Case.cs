namespace Cheetah.Domain.Entities.Facts;
public partial class F_Case : BaseEntity, IAggregateRoot
{
    public F_Case()
    {

    }
    public F_Case(Int64? eRPCode, Int64? requestorId, Int64? creatorId, Int64? processId) : base(eRPCode: eRPCode)
    {
        RequestorId = requestorId;
        CreatorId = creatorId;
        ProcessId = processId;
    }
    #region S_User
    public long? RequestorId { get; private set; }
    public long? CreatorId { get; private set; }
    #endregion

    #region Enitty
    public long? CaseStateId { get; private set; }
    public virtual D_CaseState? CaseState { get; private set; }
    public long? ProcessId { get; private set; }
    public long? SelectedScenarioId { get; private set; }

    #endregion

    #region Collection
    public virtual ICollection<L_CaseCondition>? CaseConditions { get;  set; } = new HashSet<L_CaseCondition>();
    public virtual ICollection<F_WorkItem>? WorkItems { get; private set; } = new HashSet<F_WorkItem>();
    public virtual ICollection<L_CaseTaskUser>? CaseTaskUsers { get; private set; } = new HashSet<L_CaseTaskUser>();

    #endregion

    #region Functions

    public void SetCaseStateId(long? caseStateId)
    {
        CaseStateId = caseStateId;
    }

    public void SetSelectedScenario(long? selectedScenarioId)
    {
        SelectedScenarioId = selectedScenarioId;
    }

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
        return CaseStateId == D_CaseState.Approved.Id;
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
        CaseStateId = D_CaseState.Approved.Id;
        CaseState = D_CaseState.Approved;
    }
    public void SetOngoing()
    {
        CaseStateId = D_CaseState.Ongoing.Id;
        CaseState = D_CaseState.Ongoing;
    }

    #endregion

    #endregion
}