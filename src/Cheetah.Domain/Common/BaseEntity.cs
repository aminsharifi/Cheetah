namespace Cheetah.Domain.Common;

/// <summary>
/// Base Class is a generic class for the Parent-Child classes
/// </summary>
/// <typeparam name="I">Generic class</typeparam>
public abstract class BaseEntity : EntityBase<Int64>, IAggregateRoot
{
    public Int64? SortIndex { get; private set; }
    public String Name { get; private set; }
    public String? DisplayName { get; private set; }
    public String? Description { get; private set; }
    public Guid? GuidRecord { get; private set; } = Guid.NewGuid();
    public Boolean EnableRecord { get; private set; } = true;
    public Int64? ERPCode { get; private set; }
    public DateTimeOffset? Created { get; private set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; private set; }
    public DateTimeOffset? LastModified { get; private set; }
    public string? LastModifiedBy { get; private set; }

    public BaseEntity()
    {
        /*
         
            [Description("شناسه")]
         
        */
    }
    public BaseEntity(long? eRPCode, bool enableRecord)
    {
        ERPCode = eRPCode;
        EnableRecord = enableRecord;
    }
    public BaseEntity(Int64? eRPCode)
    {
        ERPCode = eRPCode;
    }
    public BaseEntity(String name, String displayName, Int64? sortIndex, Int64? eRPCode)
    {
        Name = name;
        DisplayName = displayName;
        SortIndex = sortIndex;
        ERPCode = eRPCode;
    }
    public void SetEntity(String name, String? displayName, String? description, Boolean enableRecord)
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        EnableRecord = enableRecord;
    }

    public void SetEntity(String name, String? displayName,
        Boolean enableRecord, long? eRPCode, long? sortIndex,
        DateTimeOffset? created, DateTimeOffset? lastModified)
    {
        Name = name;
        DisplayName = displayName;
        EnableRecord = enableRecord;
        ERPCode = ERPCode;
        SortIndex = SortIndex;
        Created = created;
        LastModified = lastModified;
    }
    public void SetEntity(String name, String? displayName,
    Boolean enableRecord, long? eRPCode, long? sortIndex)
    {
        Name = name;
        DisplayName = displayName;
        EnableRecord = enableRecord;
        ERPCode = ERPCode;
        SortIndex = SortIndex;
    }
    public void SetEntity(Boolean enableRecord, long? eRPCode, long? sortIndex)
    {
        EnableRecord = enableRecord;
        ERPCode = ERPCode;
        SortIndex = SortIndex;
    }
    public void SetEntity(
      long? eRPCode, long? sortIndex, Boolean enableRecord,
      DateTimeOffset? created, DateTimeOffset? lastModified)
    {
        EnableRecord = enableRecord;
        ERPCode = ERPCode;
        SortIndex = SortIndex;
        Created = created;
        LastModified = lastModified;
    }

    public void SetEntity(String name,
     long? eRPCode, long? sortIndex, Boolean enableRecord)
    {
        Name = name;
        ERPCode = ERPCode;
        SortIndex = SortIndex;
        EnableRecord = enableRecord;
    }

    public BaseEntity(Int64 id, String name, String displayName, Int64? sortIndex, Int64? eRPCode)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
        SortIndex = sortIndex;
        ERPCode = eRPCode;
    }
    public BaseEntity(Int64 id, String name, String displayName, Int64? sortIndex, Int64? eRPCode, string description)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
        SortIndex = sortIndex;
        ERPCode = eRPCode;
        Description = description;
    }
    public BaseEntity(Int64 id, String name, String displayName,
        Int64? sortIndex, Int64? eRPCode, string description, Boolean enableRecord)
    {
        Id = id;
        Name = name;
        DisplayName = displayName;
        SortIndex = sortIndex;
        ERPCode = eRPCode;
        Description = description;
        EnableRecord = enableRecord;
    }

    public BaseEntity(String name, String displayName)
    {
        Name = name;
        DisplayName = displayName;
    }
    public void SetNameAndDisplayName(String name, String displayName)
    {
        Name = name;
        DisplayName = displayName;
    }
    public void SetDisplayName(String? displayName)
    {
        DisplayName = displayName;
    }

    public void SetName(String? displayName)
    {
        DisplayName = displayName;
    }

    public void SetEnable(Boolean enableRecord)
    {
        EnableRecord = enableRecord;
    }
    public virtual void SetName()
    {

    }

    public void SetSortIndex(Int64? sortIndex)
    {
        SortIndex = sortIndex;
    }

    private readonly List<BaseEvent> _domainEvents = new();

    //[NotMapped]
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

    public void UpdateLastModified()
    {
        LastModified = DateTimeOffset.Now;
    }
    public void UpdateLastModified(DateTimeOffset? lastModified)
    {
        LastModified = lastModified;
    }
}
public abstract class BaseEntity<I> : BaseEntity
{
    public BaseEntity()
    {

    }
    public BaseEntity(Int64 id, String name, String displayName, Int64? sortIndex, Int64? eRPCode) :
        base(id, name, displayName, sortIndex, eRPCode)
    {

    }
    public BaseEntity(Int64 id, String name, String displayName, Int64? sortIndex, Int64? eRPCode,
        String description, Boolean enableRecord) :
     base(id: id, name: name, displayName: displayName, sortIndex: sortIndex, eRPCode: eRPCode,
            description: description)
    {

    }

    /// <summary>
    /// Parent Id: long
    /// </summary>
    public long? Parent_Id { get; set; }
    public virtual I? Parent { get; set; }

    /// <summary>
    /// Children of the parent class
    /// </summary>
    public virtual ICollection<I>? Childs { get; set; } = new HashSet<I>();

}