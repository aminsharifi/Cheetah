namespace Cheetah.Domain.Entities.Links;

public partial class L_UserCondition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Condition? Condition { get; set; }

    public L_UserCondition ShallowCopy()
    {
        return (L_UserCondition)MemberwiseClone();
    }
}