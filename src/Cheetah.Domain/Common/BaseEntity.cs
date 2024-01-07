namespace Cheetah.Domain.Common;

/// <summary>
/// Base Class is a generic class for the Parent-Child classes
/// </summary>
/// <typeparam name="I">Generic class</typeparam>
public abstract class BaseEntity
{
    public Int64? Id { get; set; }
    public Int64? SortIndex { get; set; }
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean? EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }

    public BaseEntity() 
    {
        /*
         
            [Description("شناسه")]
         
        */
    }

    public virtual void SetName()
    {

    }

    private readonly List<BaseEvent> _domainEvents = new();

    [NotMapped]
    public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
public abstract class BaseEntity<I> : BaseEntity
{
    /// <summary>
    /// Parent Id: long
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