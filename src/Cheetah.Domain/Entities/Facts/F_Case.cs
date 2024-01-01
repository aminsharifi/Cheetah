namespace Cheetah.Domain.Entities.Facts;
public class F_Case : SimpleClass
{
    #region S_User
    public long? RequestorId { get; set; }
    public virtual D_User? Requestor { get; set; }

    public long? CreatorId { get; set; }
    public virtual D_User? Creator { get; set; }

    #endregion

    #region Enitty       

    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    public long? ProcessId { get; set; }
    public virtual D_Process? Process { get; set; }

    public long? SelectedScenarioId { get; set; }
    public virtual F_Scenario? SelectedScenario { get; set; }

    #endregion

    #region Collection
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(F_WorkItem.Case))]
    public virtual ICollection<F_WorkItem>? WorkItems { get; set; } = new HashSet<F_WorkItem>();

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
    public bool IsOngoing()
    {
        return CaseStateId == 1;
    }
    public bool IsEditing()
    {
        return CaseStateId == 2;
    }
    public bool IsCompleted()
    {
        return CaseStateId == 3;
    }
    public bool IsAborted()
    {
        return CaseStateId == 4;
    }
    #endregion

    #region Setter
    public void SetEditing()
    {
        CaseStateId = 2;
    }
    public void SetAborted()
    {
        CaseStateId = 4;
    }
    public void SetCompleted()
    {
        CaseStateId = 3;
    }
    public void SetOngoing()
    {
        CaseStateId = 1;
    }

    #endregion

    #endregion
}