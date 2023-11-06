namespace Cheetah.Domain.Dimentions;

[Table(nameof(D_Position), Schema = nameof(TableType.Dimentions))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_Position : SimpleClass
{
    public virtual ICollection<L_UserPosition>? UserPositions { get; set; } = new HashSet<L_UserPosition>();

    public virtual ICollection<L_RolePosition>? RolePositions { get; set; } = new HashSet<L_RolePosition>();
}