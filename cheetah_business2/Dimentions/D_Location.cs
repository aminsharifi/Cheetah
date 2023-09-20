using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions;

[Table(nameof(D_Location), Schema = nameof(TableType.Dimentions))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class D_Location : SimpleClass
{
    #region Simple Prop

    #endregion

    #region Relations

    #region Entity

    [Column(Order = 110)]
    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    #endregion

    #region Collections
    
    #endregion

    #endregion
}