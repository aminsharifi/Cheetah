using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_EndorsementItem), Schema = nameof(TableType.Facts))]
[Index(nameof(Name), IsUnique = true, AllDescending = true)]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
//[Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
public partial class F_EndorsementItem : SimpleClass
{
    [Column(Order = 102)]
    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    [Column(Order = 103)]
    public long? EndorsementId { get; set; }
    public virtual F_Endorsement? Endorsement { get; set; }

    [InverseProperty(nameof(F_Condition.EndorsementItem))]
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    
    [InverseProperty(nameof(F_EndorsementSelector.EndorsementItem))]
    public virtual ICollection<F_EndorsementSelector>? EndorsementSelectors { get; set; } = new HashSet<F_EndorsementSelector>();


    [InverseProperty(nameof(D_User.EndorsementItem))]
    public virtual ICollection<D_User>? Users { get; set; } = new HashSet<D_User>();

    [InverseProperty(nameof(D_Location.EndorsementItem))]
    public virtual ICollection<D_Location>? Locations { get; set; } = new HashSet<D_Location>();

    #region Functions
    public F_EndorsementItem ShallowCopy()
    {
        return (F_EndorsementItem)this.MemberwiseClone();
    }

    #endregion

}