namespace Cheetah.Domain.Entities.Links;

public partial class L_UserCondition : SimpleLinkClass
{
    public virtual D_User? User { get; set; }

    public virtual F_Condition? Condition { get; set; }

    public L_UserCondition ShallowCopy()
    {
        return (L_UserCondition)MemberwiseClone();
    }
}