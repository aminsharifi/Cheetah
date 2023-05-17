using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Links
{
    [Table(nameof(L_UserAssignment), Schema = nameof(TableType.Links))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
    [Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
    public partial class L_UserAssignment : SimpleLinkClass
    {
        [Column(Order = 101)]
        [ForeignKey(nameof(FirstId))]
        public virtual D_User? UA_User { get; set; }

        [Column(Order = 100)]
        [ForeignKey(nameof(SecondId))]
        public virtual F_Assignment? UA_Assignment { get; set; }
    }
}
