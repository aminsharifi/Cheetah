using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Links;

[Table(nameof(L_UserPosition), Schema = nameof(TableType.Links))]
[Index(nameof(PName), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_UserPosition : SimpleLinkClass
{
    [Column(Order = 101)]
    [ForeignKey(nameof(FirstId))]
    public virtual D_User? User { get; set; }

    [Column(Order = 100)]
    [ForeignKey(nameof(SecondId))]
    public virtual D_Position? Position { get; set; }
}