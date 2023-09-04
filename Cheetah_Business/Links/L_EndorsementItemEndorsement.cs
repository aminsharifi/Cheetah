using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Links;

[Table(nameof(L_EndorsementItemEndorsement), Schema = nameof(TableType.Links))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_EndorsementItemEndorsement : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    public L_EndorsementItemEndorsement ShallowCopy()
    {
        return (L_EndorsementItemEndorsement)this.MemberwiseClone();
    }
}