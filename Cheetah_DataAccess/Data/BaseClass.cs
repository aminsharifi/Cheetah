using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cheetah_DataAccess.Data
{ 
    public abstract class BaseClass<I> : SimpleClass
    {
        [Column(Order = 10)]
        public long? Parent_Id { get; set; }
        [ForeignKey("Parent_Id")]
        [Column(Order = 11)]
        public virtual I? ParentId { get; set; }

        [InverseProperty("ParentId")]
        public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

    }
}
