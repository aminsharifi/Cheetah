namespace Cheetah.Domain.Entities.Links;

public partial class L_ConditionGroupCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_ConditionGroup? Case { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_ConditionGroupCondition ShallowCopy()
    {
        return (L_ConditionGroupCondition)MemberwiseClone();
    }
}