using Cheetah.Core.Aggregates.ProcessAggregate.Links;
using Cheetah.Core.Common;
using Cheetah.Core.Entities.Links;

namespace Cheetah.Core.Entities.Facts;

public partial class F_Flow : BaseEntity
{
    public F_Flow()
    {

    }
    #region Entities    
    public long? CaseStateId { get; private set; }

    public F_Flow SetCaseStateId(long? caseStateId)
    {
        this.CaseStateId = caseStateId;
        return this;
    }

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