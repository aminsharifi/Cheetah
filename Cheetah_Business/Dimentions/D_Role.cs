using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions;

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

    public virtual ICollection<F_Endorsement>? EndorsementPosition { get; set; } = new HashSet<F_Endorsement>();
    #endregion
}