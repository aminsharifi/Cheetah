namespace Cheetah.Domain.Entities.Facts;
public partial class F_Case : BaseEntity, IAggregateRoot
{
    public F_Case()
    {

    }

    public F_Case(long? RequestorId, long? CreatorId, long? ProcessId, long? ERPCode)
    {
        SetRequestorId(RequestorId).
            SetCreatorId(CreatorId).
            SetProcessId(ProcessId).
            SetERPCode(ERPCode);
    }

    public F_Case SetSelectedScenario(long? selectedScenarioId)
    {
        this.SelectedScenarioId = Guard.Against.Null(selectedScenarioId);
        return this;
    }
    public F_Case SetCreatorId(Int64? creatorId)
    {
        this.CreatorId = Guard.Against.Null(creatorId);
        return this;
    }
    public F_Case SetProcessId(Int64? processId)
    {
        this.ProcessId = Guard.Against.Null(processId);
        return this;
    }

    #region CaseState
    public long? CaseStateId { get; private set; }
    public virtual D_CaseState? CaseState { get; private set; }
    public F_Case SetCaseStateId(long? caseStateId)
    {
        this.CaseStateId = caseStateId;
        return this;
    }
    public F_Case SetInitializing()
    {
        SetCaseStateId(D_CaseState.Initializing.Id);
        this.CaseState = D_CaseState.Initializing;
        return this;
    }
    public F_Case SetEditing()
    {
        SetCaseStateId(D_CaseState.Editing.Id);
        this.CaseState = D_CaseState.Editing;
        return this;
    }
    public F_Case SetAborted()
    {
        SetCaseStateId(D_CaseState.Aborted.Id);
        this.CaseState = D_CaseState.Aborted;
        return this;
    }
    public F_Case SetApproved()
    {
        SetCaseStateId(D_CaseState.Approved.Id);
        this.CaseState = D_CaseState.Approved;
        return this;
    }
    public F_Case SetOngoing()
    {
        SetCaseStateId(D_CaseState.Ongoing.Id);
        this.CaseState = D_CaseState.Ongoing;
        return this;
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
    public bool IsApproved()
    {
        return CaseStateId == D_CaseState.Approved.Id;
    }
    public bool IsAborted()
    {
        return CaseStateId == D_CaseState.Aborted.Id;
    }
    #endregion

    #region Requestor
    public F_Case SetRequestorId(Int64? requestorId)
    {
        this.RequestorId = Guard.Against.Null(requestorId);
        return this;
    }
    public long? RequestorId { get; private set; }
    public long? CreatorId { get; private set; }
    #endregion

    #region Enitty

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

    #endregion
}