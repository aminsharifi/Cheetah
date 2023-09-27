using Cheetah.Domain.Data;
using Cheetah.Domain.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah.Domain.Dimentions;

[Table(nameof(D_Role), Schema = nameof(TableType.Dimentions))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
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