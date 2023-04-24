namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Endorsement", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Endorsement : BaseClass<D_Endorsement>
    {
        [Column(Order = 100)]
        public long? ED_RoleId { get; set; }
        [ForeignKey("ED_RoleId")]
        public virtual D_Role? ED_Role { get; set; }

        [Column(Order = 101)]
        public long? ED_EndorsementPatternId { get; set; }
        [ForeignKey("ED_EndorsementPatternId")]
        public virtual D_EndorsementPattern? ED_EndorsementPattern { get; set; }
    }
}
