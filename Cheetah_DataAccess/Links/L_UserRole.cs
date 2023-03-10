using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Links
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("L_UserRole", Schema = "Links")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
    [Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
    public partial class L_UserRole : SimpleLinkClass
    {
        [Column(Order = 101)]
        [ForeignKey("FirstId")]        
        public virtual D_User? UR_User { get; set; }

        [Column(Order = 100)]
        [ForeignKey("SecondId")]
        public virtual D_Role? UR_Role { get; set; }
        

    }
}
