namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_RolePosition : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual D_Role? Role { get; set; }
    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual D_Position? Position { get; set; }

    public L_RolePosition ShallowCopy()
    {
        return (L_RolePosition)this.MemberwiseClone();
    }
}