namespace Cheetah.Domain.Entities.Links;

public partial class L_UserConditionGroup : SimpleLinkClass
{
    public virtual D_User? User { get; set; }

    public L_UserConditionGroup ShallowCopy()
    {
        return (L_UserConditionGroup)MemberwiseClone();
    }
    public virtual ICollection<L_UserConditionGroup>? UserConditionGroups { get; set; } = new HashSet<L_UserConditionGroup>();
}