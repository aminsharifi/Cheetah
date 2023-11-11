namespace Cheetah.Domain.Links;

public partial class L_ProcessScenario : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_Process? Process { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Scenario? Scenario { get; set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)this.MemberwiseClone();
    }
}