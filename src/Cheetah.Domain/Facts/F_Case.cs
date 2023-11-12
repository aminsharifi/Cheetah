﻿namespace Cheetah.Domain.Facts;
public partial class F_Case : SimpleClass
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
        return (F_Case)this.MemberwiseClone();
    }

    #region Getter
    public Boolean IsCreating()
    {
        return (CaseStateId is null);
    }
    public Boolean IsOngoing()
    {
        return (CaseStateId == 1);
    }
    public Boolean IsEditing()
    {
        return (CaseStateId == 2);
    }
    public Boolean IsCompleted()
    {
        return (CaseStateId == 3);
    }
    public Boolean IsAborted()
    {
        return (CaseStateId == 4);
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