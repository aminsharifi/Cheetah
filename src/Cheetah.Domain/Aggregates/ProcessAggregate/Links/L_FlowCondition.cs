namespace Cheetah.Domain.Entities.Links;

public partial class L_FlowCondition : SimpleLinkClass
{
    public virtual F_Flow? Flow { get; set; }

    public L_FlowCondition ShallowCopy()
    {
        return (L_FlowCondition)MemberwiseClone();
    }
}