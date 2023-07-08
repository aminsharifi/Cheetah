using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_Assignment), Schema = nameof(TableType.Facts))]
[Index(nameof(PName), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class F_Assignment : BaseClass<F_Assignment>
{
    [Column(Order = 101)]
    public long? PRM_EndorsementId { get; set; }
    public virtual F_Endorsement? PRM_Endorsement { get; set; }

    [Column(Order = 102)]
    public virtual D_User? PRM_User { get; set; }

    [Column(Order = 103)]
    public long? PRM_RequestId { get; set; }
    [ForeignKey(nameof(PRM_RequestId))]
    public virtual F_Request? PRM_Request { get; set; }

    [Column(Order = 104)]
    public virtual D_Tag? PRM_Tag { get; set; }
}