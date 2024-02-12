namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Task? Task { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_TaskCondition ShallowCopy()
    {
        return (L_TaskCondition)MemberwiseClone();
    }
}