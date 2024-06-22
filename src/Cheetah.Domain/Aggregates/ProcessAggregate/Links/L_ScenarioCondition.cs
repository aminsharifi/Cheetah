namespace Cheetah.Domain.Entities.Links;

public partial class L_ScenarioCondition : BaseLink
{
    public virtual F_Scenario? Scenario { get; private set; }

    public L_ScenarioCondition ShallowCopy()
    {
        return (L_ScenarioCondition)MemberwiseClone();
    }
}