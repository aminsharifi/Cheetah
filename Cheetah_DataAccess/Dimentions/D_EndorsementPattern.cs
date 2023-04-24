namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_EndorsementPattern", Schema = "Dimentions")]
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
        [InverseProperty("CD_EndorsementPattern")]
        public virtual ICollection<F_Condition>? EP_Condition { get; set; } = new HashSet<F_Condition>();

        [InverseProperty("ED_EndorsementPattern")]
        public virtual ICollection<D_Endorsement>? EP_Endorsement { get; set; } = new HashSet<D_Endorsement>();
        #endregion
    }
}