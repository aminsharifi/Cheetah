namespace Cheetah.Domain.Entities.Links;

public partial class L_UserConditionGroup : SimpleLinkClass
{
    public virtual D_User? User { get; set; }

    public virtual F_ConditionGroup? ConditionGroup { get; set; }

    public L_UserConditionGroup ShallowCopy()
    {
        return (L_UserConditionGroup)MemberwiseClone();
    }
}