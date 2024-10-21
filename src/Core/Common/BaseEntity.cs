namespace Cheetah.Core.Common;

/// <summary>
/// Base Class is a generic class for the Parent-Child classes
/// </summary>
/// <typeparam name="I">Generic class</typeparam>
public abstract class BaseEntity : EntityBase<long>, IAggregateRoot
{
    public long? SortIndex { get; private set; }
    public string? Name { get; private set; }
    public string? DisplayName { get; private set; }
    public string? Description { get; private set; }
    public Guid? GuidRecord { get; private set; }
    public bool EnableRecord { get; private set; } = true;
    public long? ERPCode { get; private set; }
    public DateTimeOffset? Created { get; private set; }
    public string? CreatedBy { get; private set; }
    public DateTimeOffset? LastModified { get; private set; }
    public string? LastModifiedBy { get; private set; }

    public BaseEntity()
    {
    }
    public BaseEntity SetId(long id)
    {
        Id = id;
        return this;
    }
    public BaseEntity SetSortIndex(long? sortIndex)
    {
        SortIndex = sortIndex;
        return this;
    }
    public BaseEntity SetERPCode(long? eRPCode)
    {
        ERPCode = eRPCode;
        return this;
    }  
    public BaseEntity SetEnableRecord(bool enableRecord)
    {
        EnableRecord = enableRecord;
        return this;
    }
    public BaseEntity SetName(string? name)
    {
        Name = name;
        return this;
    }
    public BaseEntity SetDisplayName(string? displayName)
    {
        DisplayName = displayName;
        return this;
    }
    public BaseEntity SetDescription(string? description)
    {
        Description = description;
        return this;
    }
    public BaseEntity SetLastModified()
    {
        LastModified = DateTimeOffset.UtcNow;
        return this;
    }
    public BaseEntity SetLastModified(DateTimeOffset? lastModified)
    {
        LastModified = lastModified;
        return this;
    }
    public BaseEntity SetCreated(DateTimeOffset? created)
    {
        Created = created;
        return this;
    }
    public virtual void SetNaming()
    {
    }
}
public abstract class BaseEntity<I> : BaseEntity
{
    public BaseEntity()
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