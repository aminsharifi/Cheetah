namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Position : SimpleClass
{
    public virtual ICollection<L_UserPosition>? UserPositions { get; set; } = new HashSet<L_UserPosition>();

    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();

}