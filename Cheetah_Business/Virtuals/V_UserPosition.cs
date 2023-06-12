using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Virtuals;

[Table(nameof(V_UserPosition), Schema = nameof(TableType.Virtuals))]
[Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class V_UserPosition
{
    [Column(Order = 1)]
    [Key]
    public Int64? PERPCode { get; set; }

    [Column(Order = 50)]
    public Int64? FirstId { get; set; }

    [Column(Order = 51)]
    public Int64? SecondId { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(FirstId))]
    public virtual V_User? UP_User { get; set; }

    [Column(Order = 102)]
    [ForeignKey(nameof(SecondId))]
    public virtual V_Position? UP_Position { get; set; }

    [Column(Order = 103)]
    public Boolean? DsblRecord { get; set; }
}