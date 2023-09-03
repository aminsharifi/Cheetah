using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_EndorsementSelector), Schema = nameof(TableType.Facts))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class F_EndorsementSelector : SimpleClass
{
    [Column(Order = 100)]
    public long? EndorsementId { get; set; }
    public virtual F_Endorsement? Endorsement { get; set; }

    [Column(Order = 101)]
    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    public override void SetName()
    {
        DisplayName = Endorsement?.DisplayName + "," + SortIndex;
        Name = Endorsement?.Name + "," + SortIndex ;
    }

    #region Functions
    public F_EndorsementSelector ShallowCopy()
    {
        return (F_EndorsementSelector)this.MemberwiseClone();
    }  

    #endregion

}