using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_Business.Dimentions
{

    [Table(nameof(D_EndorsementPattern), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_EndorsementPattern : BaseClass<D_EndorsementPattern>
    {
        #region Relations
        public virtual ICollection<F_Condition>? EP_Conditions { get; set; } = new HashSet<F_Condition>();

        public virtual ICollection<F_Endorsement>? EP_Endorsements { get; set; } = new HashSet<F_Endorsement>();
        #endregion
    }
}