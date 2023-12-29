namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Role : SimpleClass
{
    public bool Independent { get; set; } = false;
    public bool FixedRole { get; set; } = false;

    #region Collection
    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();

    #endregion
}