namespace Cheetah.Domain.Entities.Links;

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