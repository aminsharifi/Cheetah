using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Virtuals;

[Table(nameof(V_Position), Schema = nameof(TableType.Virtuals))]
public partial class V_Position
{
    [Column(Order = 101)]
    [Key]
    public Int64? PERPCode { get; set; }

    [Column(Order = 102)]
    [StringLength(256)]
    public String? PName { get; set; }

    [Column(Order = 103)]
    [StringLength(256)]
    public String? PDisplayName { get; set; }
}
