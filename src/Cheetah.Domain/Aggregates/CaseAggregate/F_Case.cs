namespace Cheetah.Domain.Entities.Facts;
public partial class F_Case : BaseEntity, IAggregateRoot
{
    public F_Case()
    {

    }
    public F_Case SetCaseStateId(long? caseStateId)
    {
        this.CaseStateId = caseStateId;
        return this;
    }
    public F_Case SetSelectedScenario(long? selectedScenarioId)
    {
        this.SelectedScenarioId = selectedScenarioId;
        return this;
    }
    public F_Case SetRequestorId(Int64? requestorId)
    {
        this.RequestorId = requestorId;
        return this;
    }
    public F_Case SetCreatorId(Int64? creatorId)
    {
        this.CreatorId = creatorId;
        return this;
    }
    public F_Case SetProcessId(Int64? processId)
    {
        this.ProcessId = processId;
        return this;
    }
    public F_Case SetEditing()
    {
        this.CaseStateId = D_CaseState.Editing.Id;
        this.CaseState = D_CaseState.Editing;
        return this;
    }
    public F_Case SetAborted()
    {
        this.CaseStateId = D_CaseState.Aborted.Id;
        this.CaseState = D_CaseState.Aborted;
        return this;
    }
    public F_Case SetCompleted()
    {
        this.CaseStateId = D_CaseState.Approved.Id;
        this.CaseState = D_CaseState.Approved;
        return this;
    }
    public F_Case SetOngoing()
    {
        this.CaseStateId = D_CaseState.Ongoing.Id;
        this.CaseState = D_CaseState.Ongoing;
        return this;
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
    public virtual ICollection<L_CaseCondition>? CaseConditions { get; set; } = new HashSet<L_CaseCondition>();
    public virtual ICollection<F_WorkItem>? WorkItems { get; private set; } = new HashSet<F_WorkItem>();
    public virtual ICollection<L_CaseTaskUser>? CaseTaskUsers { get; private set; } = new HashSet<L_CaseTaskUser>();

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
        return CaseStateId == D_CaseState.Approved.Id;
    }
    public bool IsAborted()
    {
        return CaseStateId == D_CaseState.Aborted.Id;
    }
    #endregion

    #endregion
}