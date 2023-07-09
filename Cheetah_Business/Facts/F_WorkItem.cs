using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_WorkItem), Schema = nameof(TableType.Facts))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class F_WorkItem : BaseClass<F_WorkItem>
{
    [Column(Order = 101)]
    public long? EndorsementId { get; set; }
    public virtual F_Endorsement? Endorsement { get; set; }

    [Column(Order = 102)]
    public virtual D_User? User { get; set; }

    [Column(Order = 103)]
    public long? CaseId { get; set; }
    [ForeignKey(nameof(CaseId))]
    public virtual F_Case? Case { get; set; }

    [Column(Order = 104)]
    public virtual D_Tag? Tag { get; set; }
}