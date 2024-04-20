namespace Cheetah.Domain.Entities.Facts;

public partial class F_Flow : BaseEntity
{
    #region Entities    
    public long? CaseStateId { get; set; }
    #endregion

    #region Collection
    public virtual ICollection<L_FlowCondition>? FlowConditions { get; set; } = new HashSet<L_FlowCondition>();
    public virtual ICollection<L_TaskFlow>? TaskFlows { get; set; } = new HashSet<L_TaskFlow>();
    public virtual ICollection<L_FlowTask>? FlowTasks { get; set; } = new HashSet<L_FlowTask>();

    #endregion

    #region Functions
    public F_Flow ShallowCopy()
    {
        return (F_Flow)MemberwiseClone();
    }

    #endregion
}