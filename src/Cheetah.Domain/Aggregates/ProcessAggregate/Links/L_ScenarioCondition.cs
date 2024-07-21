using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Links;

public partial class L_ScenarioCondition : BaseLink
{
    public virtual F_Scenario? Scenario { get; private set; }

    public L_ScenarioCondition ShallowCopy()
    {
        return (L_ScenarioCondition)MemberwiseClone();
    }
}