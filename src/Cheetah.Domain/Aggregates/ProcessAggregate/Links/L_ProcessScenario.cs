namespace Cheetah.Domain.Entities.Links;

public partial class L_ProcessScenario : SimpleLinkClass
{
    public virtual D_Process? Process { get; set; }

    public virtual F_Scenario? Scenario { get; set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)MemberwiseClone();
    }
}