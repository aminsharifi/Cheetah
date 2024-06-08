namespace Cheetah.Domain.Entities.Links;

public partial class L_WorkItemCondition : BaseLink
{
    public L_WorkItemCondition()
    {
        
    }
    public L_WorkItemCondition(Int64? conditionId) : base(secondId: conditionId)
    {

    }
    public virtual F_WorkItem? WorkItem { get; set; }

    public L_WorkItemCondition ShallowCopy()
    {
        return (L_WorkItemCondition)MemberwiseClone();
    }
}