using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_ProcessScenario : BaseLink
{
    public L_ProcessScenario()
    {
        
    }

    public virtual D_Process? Process { get; private set; }

    public virtual F_Scenario? Scenario { get; private set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)MemberwiseClone();
    }
}