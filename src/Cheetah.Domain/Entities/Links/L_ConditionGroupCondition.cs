namespace Cheetah.Domain.Entities.Links;

public partial class L_ConditionGroupCondition : SimpleLinkClass
{
    public virtual F_ConditionGroup? ConditionGroup { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_ConditionGroupCondition ShallowCopy()
    {
        return (L_ConditionGroupCondition)MemberwiseClone();
    }
}