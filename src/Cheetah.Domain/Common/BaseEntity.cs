namespace Cheetah.Domain.Common;

/// <summary>
/// Base Class is a generic class for the Parent-Child classes
/// </summary>
/// <typeparam name="I">Generic class</typeparam>
public abstract class BaseEntity : EntityBase<Int64>, IAggregateRoot
{
    public Int64? SortIndex { get; private set; }
    public String? Name { get; private set; }
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
    }
    public BaseEntity SetId(Int64 id)
    {
        this.Id = id;
        return this;
    }
    public BaseEntity SetSortIndex(Int64? sortIndex)
    {
        this.SortIndex = sortIndex;
        return this;
    }
    public BaseEntity SetERPCode(Int64? eRPCode)
    {
        this.ERPCode = eRPCode;
        return this;
    }
    public BaseEntity SetEnableRecord(Boolean enableRecord)
    {
        this.EnableRecord = enableRecord;
        return this;
    }
    public BaseEntity SetName(String? name)
    {
        this.Name = name;
        return this;
    }
    public BaseEntity SetDisplayName(String? displayName)
    {
        this.DisplayName = displayName;
        return this;
    }
    public BaseEntity SetDescription(string? description)
    {
        this.Description = description;
        return this;
    }
    public BaseEntity SetLastModified()
    {
        this.LastModified = DateTimeOffset.UtcNow;
        return this;
    }
    public BaseEntity SetLastModified(DateTimeOffset? lastModified)
    {
        this.LastModified = lastModified;
        return this;
    }
    public BaseEntity SetCreated(DateTimeOffset? created)
    {
        this.Created = created;
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