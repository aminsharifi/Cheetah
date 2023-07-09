using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_Endorsement), Schema = nameof(TableType.Facts))]
[Index(nameof(PName), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class F_Endorsement : BaseClass<F_Endorsement>
{
    [Column(Order = 100)]
    public long? RoleId { get; set; }
    public virtual D_Role? Role { get; set; }

    [Column(Order = 101)]
    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    public override void SetName()
    {
        PDisplayName = Scenario?.PDisplayName + "," + Role?.PDisplayName;
        PName = Scenario?.PName + "," + Role?.PName;
    }
}