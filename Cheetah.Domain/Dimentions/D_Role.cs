namespace Cheetah.Domain.Dimentions;

[Index(nameof(Independent), IsUnique = false, AllDescending = true)]
public partial class D_Role : SimpleClass
{

    [Column(Order = 100)]
    public Boolean Independent { get; set; } = false;

    [Column(Order = 101)]
    public Boolean FixedRole { get; set; } = false;

    #region Collection
    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();
    
    #endregion
}