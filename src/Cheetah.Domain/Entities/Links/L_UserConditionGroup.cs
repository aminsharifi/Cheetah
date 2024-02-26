namespace Cheetah.Domain.Entities.Links;

public partial class L_UserConditionGroup : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_ConditionGroup? ConditionGroup { get; set; }

    public L_UserConditionGroup ShallowCopy()
    {
        return (L_UserConditionGroup)MemberwiseClone();
    }
}