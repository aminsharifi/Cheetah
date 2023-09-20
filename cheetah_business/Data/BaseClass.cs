using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_Business.Data;

public abstract class BaseClass<I> : SimpleClass
{
    [Column(Order = 50)]
    public long? Parent_Id { get; set; }
    [ForeignKey("Parent_Id")]
    [Column(Order = 51)]
    public virtual I? Parent { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

}