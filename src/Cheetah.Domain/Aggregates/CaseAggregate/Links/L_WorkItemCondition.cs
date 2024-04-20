namespace Cheetah.Domain.Entities.Links;

public partial class L_WorkItemCondition : SimpleLinkClass
{
    public virtual F_WorkItem? WorkItem { get; set; }

    public L_WorkItemCondition ShallowCopy()
    {
        return (L_WorkItemCondition)MemberwiseClone();
    }
}