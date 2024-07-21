using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Domain.Entities.Facts;

/// <summary>
/// F_Case type is Fact and used for instancing for each request
/// </summary>
public partial class F_Case : BaseEntity, IAggregateRoot
{
    /// <summary>
    /// Case is instance for each request
    /// </summary>
    public F_Case()
    {

    }

    /// <summary>
    /// Create case instance for each request
    /// </summary>
    /// <param name="RequestorId">Requestor is who owner of case</param>
    /// <param name="CreatorId">Creator is who creator of case</param>
    /// <param name="ProcessId">Related process</param>
    /// <param name="ERPCode">ERPCode is record id of main ERP</param>
    public F_Case(long? RequestorId, long? CreatorId, long? ProcessId, long? ERPCode)
    {
        SetRequestorId(RequestorId).
            SetCreatorId(CreatorId).
            SetProcessId(ProcessId).
            SetERPCode(ERPCode);
    }

    #region CaseState

    /// <summary>
    /// State of the case, such as Initializing, Ongoing, Editing, Approved, Rejected, Aborted
    /// </summary>
    public virtual D_CaseState? CaseState { get; private set; }

    /// <summary>
    /// Id of CaseState
    /// </summary>
    public long? CaseStateId { get; private set; }

    /// <summary>
    /// Setting CaseState's Id
    /// </summary>
    /// <param name="caseStateId"> State of case</param>
    /// <returns>Current case</returns>
    public F_Case SetCaseStateId(long? caseStateId)
    {
        this.CaseStateId = caseStateId;
        return this;
    }

    /// <summary>
    /// When case is create, it's state is Initializing
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case SetInitializing()
    {
        SetCaseStateId(D_CaseState.Initializing.Id);
        this.CaseState = D_CaseState.Initializing;
        return this;
    }

    /// <summary>
    /// Check initializing state
    /// </summary>
    /// <returns>True if occured</returns>
    public bool IsInitializing()
    {
        return CaseStateId == D_CaseState.Initializing.Id;
    }

    /// <summary>
    /// When case need revise, reviewer sent it back to the creator
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case SetEditing()
    {
        SetCaseStateId(D_CaseState.Editing.Id);
        this.CaseState = D_CaseState.Editing;
        return this;
    }

    /// <summary>
    /// Check editing state
    /// </summary>
    /// <returns></returns>
    public bool IsEditing()
    {
        return CaseStateId == D_CaseState.Editing.Id;
    }

    /// <summary>
    /// When reviewer determine that request is agains rules
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case SetAborted()
    {
        SetCaseStateId(D_CaseState.Aborted.Id);
        this.CaseState = D_CaseState.Aborted;
        return this;
    }

    /// <summary>
    /// Check if case is aborted
    /// </summary>
    /// <returns>True if conditions occoured</returns>
    public bool IsAborted()
    {
        return CaseStateId == D_CaseState.Aborted.Id;
    }

    /// <summary>
    /// Check approve state
    /// </summary>
    /// <returns></returns>
    public bool IsApproved()
    {
        return CaseStateId == D_CaseState.Approved.Id;
    }

    /// <summary>
    /// When case finally approved
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case SetApproved()
    {
        SetCaseStateId(D_CaseState.Approved.Id);
        this.CaseState = D_CaseState.Approved;
        return this;
    }

    /// <summary>
    /// When case is under review
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case SetOngoing()
    {
        SetCaseStateId(D_CaseState.Ongoing.Id);
        this.CaseState = D_CaseState.Ongoing;
        return this;
    }

    /// <summary>
    /// Check Ongoing state
    /// </summary>
    /// <returns>True if condition occurred</returns>
    public bool IsOngoing()
    {
        return CaseStateId == D_CaseState.Ongoing.Id;
    }

    #endregion

    #region Requestor
    /// <summary>
    /// Set requestor of case
    /// </summary>
    /// <param name="requestorId">requestor's id</param>
    /// <returns>Current case</returns>
    public F_Case SetRequestorId(Int64? requestorId)
    {
        this.RequestorId = Guard.Against.Null(requestorId, nameof(requestorId));
        return this;
    }

    /// <summary>
    /// Id of requestor
    /// </summary>
    public long? RequestorId { get; private set; }
    #endregion

    #region Creator

    /// <summary>
    /// Creator of case
    /// </summary>
    /// <param name="creatorId">creator's id</param>
    /// <returns>Current case</returns>
    public F_Case SetCreatorId(Int64? creatorId)
    {
        this.CreatorId = Guard.Against.Null(creatorId, nameof(creatorId));
        return this;
    }

    /// <summary>
    /// Creator's id
    /// </summary>
    public long? CreatorId { get; private set; }
    #endregion

    #region Process
    /// <summary>
    /// Process's id
    /// </summary>
    public long? ProcessId { get; private set; }

    /// <summary>
    /// Setting id of process
    /// </summary>
    /// <param name="processId">Process's id</param>
    /// <returns>Current case</returns>
    public F_Case SetProcessId(Int64? processId)
    {
        this.ProcessId = Guard.Against.Null(processId, nameof(processId));
        return this;
    }
    #endregion

    #region SelectedScenario

    /// <summary>
    /// Cheetah checks conditions, then select accorate scenario
    /// </summary>
    /// <param name="selectedScenarioId">selected scenario's id</param>
    /// <returns>Current case</returns>
    public F_Case SetSelectedScenario(long? selectedScenarioId)
    {
        this.SelectedScenarioId = Guard.Against.Null(selectedScenarioId, nameof(selectedScenarioId));
        return this;
    }

    /// <summary>
    /// selected scenario's id
    /// </summary>
    public long? SelectedScenarioId { get; private set; }

    #endregion

    #region Collection

    /// <summary>
    /// Each case has several conditions
    /// </summary>
    public virtual ICollection<L_CaseCondition>? CaseConditions { get; set; } = new HashSet<L_CaseCondition>();

    /// <summary>
    /// Each transaction in the case, generate one WorkItem; WorkItem is equivalent to token of each step
    /// </summary>
    public virtual ICollection<F_WorkItem>? WorkItems { get; private set; } = new HashSet<F_WorkItem>();

    /// <summary>
    /// We can assign user for each case and task
    /// </summary>
    public virtual ICollection<L_CaseTaskUser>? CaseTaskUsers { get; private set; } = new HashSet<L_CaseTaskUser>();

    #endregion

    #region Functions

    /// <summary>
    /// Shallow Copy
    /// </summary>
    /// <returns>Current case</returns>
    public F_Case ShallowCopy()
    {
        return (F_Case)MemberwiseClone();
    }

    #endregion
}