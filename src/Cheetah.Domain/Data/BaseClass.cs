namespace Cheetah.Domain.Data;

/// <summary>
/// Base Class is a generic class for the Parent-Child classes
/// </summary>
/// <typeparam name="I">Generic class</typeparam>
public abstract class BaseClass<I> : SimpleClass
{
    /// <summary>
    /// Parent Id
    /// </summary>
    public long? Parent_Id { get; set; }
    [ForeignKey(nameof(Parent_Id))]
    public virtual I? Parent { get; set; }

    /// <summary>
    /// Children of the parent class
    /// </summary>
    [InverseProperty(nameof(Parent))]
    public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

}