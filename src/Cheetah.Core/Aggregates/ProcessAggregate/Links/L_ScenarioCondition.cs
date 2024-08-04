using Cheetah.Core.Common;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_ScenarioCondition : BaseLink
{
    public virtual F_Scenario? Scenario { get; private set; }

    public L_ScenarioCondition ShallowCopy()
    {
        return (L_ScenarioCondition)MemberwiseClone();
    }
}