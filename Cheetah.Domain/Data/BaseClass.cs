namespace Cheetah.Domain.Data;

public abstract class BaseClass<I> : SimpleClass
{
    public long? Parent_Id { get; set; }
    public virtual I? Parent { get; set; }

    [InverseProperty(nameof(Parent))]
    public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

}