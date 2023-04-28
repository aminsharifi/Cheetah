using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_Common.Data
{
    public abstract class BaseClass<I> : SimpleClass
    {
        [Column(Order = 50)]
        public long? Parent_Id { get; set; }
        [ForeignKey("Parent_Id")]
        [Column(Order = 51)]
        public virtual I? ParentId { get; set; }

        [InverseProperty("ParentId")]
        public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

    }
}
