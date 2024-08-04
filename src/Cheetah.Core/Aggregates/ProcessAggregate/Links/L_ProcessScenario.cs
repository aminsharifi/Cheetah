using Cheetah.Core.Common;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Entities.Links;

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