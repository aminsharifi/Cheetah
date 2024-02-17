using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Entities.Links;

public partial class L_WorkItemCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_WorkItemState? Case { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_WorkItemCondition ShallowCopy()
    {
        return (L_WorkItemCondition)MemberwiseClone();
    }
}