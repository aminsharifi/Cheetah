namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskCondition : BaseLink
{
    public virtual F_Task? Task { get; private set; }

    public L_TaskCondition ShallowCopy()
    {
        return (L_TaskCondition)MemberwiseClone();
    }
}