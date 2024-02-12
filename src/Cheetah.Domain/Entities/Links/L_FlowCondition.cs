namespace Cheetah.Domain.Entities.Links;

public partial class L_FlowCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Flow? Flow { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_FlowCondition ShallowCopy()
    {
        return (L_FlowCondition)MemberwiseClone();
    }
}