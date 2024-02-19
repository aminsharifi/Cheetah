namespace Cheetah.Domain.Entities.Links;

public partial class L_WorkItemCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_WorkItem? WorkItem { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_WorkItemCondition ShallowCopy()
    {
        return (L_WorkItemCondition)MemberwiseClone();
    }
}