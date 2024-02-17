namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Case? Case { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_CaseCondition ShallowCopy()
    {
        return (L_CaseCondition)MemberwiseClone();
    }
}