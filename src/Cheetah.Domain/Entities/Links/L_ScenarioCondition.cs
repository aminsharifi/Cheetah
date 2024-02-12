namespace Cheetah.Domain.Entities.Links;

public partial class L_ScenarioCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Scenario? Scenario { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_ScenarioCondition ShallowCopy()
    {
        return (L_ScenarioCondition)MemberwiseClone();
    }
}