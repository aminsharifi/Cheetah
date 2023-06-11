using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Virtuals
{
    [Table(nameof(V_UserPosition), Schema = nameof(TableType.Virtuals))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
    [Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
    public partial class V_UserPosition : SimpleLinkClass
    {
        [Column(Order = 101)]
        [ForeignKey(nameof(FirstId))]
        public virtual V_User? UP_User { get; set; }

        [Column(Order = 100)]
        [ForeignKey(nameof(SecondId))]
        public virtual V_Position? UP_Position { get; set; }
    }
}
