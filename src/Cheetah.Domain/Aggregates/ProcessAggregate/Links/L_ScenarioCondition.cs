namespace Cheetah.Domain.Entities.Links;

public partial class L_ScenarioCondition : SimpleLinkClass
{
    public virtual F_Scenario? Scenario { get; set; }

    public L_ScenarioCondition ShallowCopy()
    {
        return (L_ScenarioCondition)MemberwiseClone();
    }
}