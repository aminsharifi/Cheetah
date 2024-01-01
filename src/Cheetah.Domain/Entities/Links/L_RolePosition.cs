namespace Cheetah.Domain.Entities.Links;

public class L_RolePosition : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual D_Role? Role { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual D_Position? Position { get; set; }

    public L_RolePosition ShallowCopy()
    {
        return (L_RolePosition)MemberwiseClone();
    }
}