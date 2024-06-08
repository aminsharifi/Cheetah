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
    }
    public BaseEntity(Int64? eRPCode)
    {
        SetERPCode(eRPCode);
    }
    public BaseEntity(long? eRPCode, bool enableRecord) : this(eRPCode)
    {
        SetEnable(enableRecord);
    }
    public BaseEntity(String name, String? displayName, Int64? sortIndex, Int64? eRPCode) : this(eRPCode: eRPCode)
    {
        SetNameAndDisplayName(name: name, displayName: displayName);
        SetSortIndex(sortIndex);
    }
    public BaseEntity(Int64 id, String name, String? displayName, Int64? sortIndex, Int64? eRPCode)
        : this(name: name, displayName: displayName, sortIndex: sortIndex, eRPCode: eRPCode)
    {
        Id = id;
    }
    public BaseEntity(Int64 id, String name, String? displayName, Int64? sortIndex,
        Int64? eRPCode, string? description)
        : this(id: id, name: name, displayName: displayName, sortIndex: sortIndex, eRPCode: eRPCode)
    {
        Description = description;
    }
    public BaseEntity(Int64 id, String name, String? displayName,
        Int64? sortIndex, Int64? eRPCode, string? description, Boolean enableRecord)
        : this(id: id, name: name, displayName: displayName, sortIndex: sortIndex, eRPCode: eRPCode, description: description)
    {
        SetEnable(enableRecord);
    }
    public void SetName(String name)
    {
        Name = name;
    }
    public void SetDisplayName(String? displayName)
    {
        DisplayName = displayName;
    }
    public void SetDescription(String? description)
    {
        Description = description;
    }
    public void SetNameAndDisplayName(String name, String? displayName)
    {
        SetName(name: name);
        SetDisplayName(displayName: displayName);
    }
    public void SetERPCode(long? eRPCode)
    {
        ERPCode = eRPCode;
    }
    public void SetEnable(Boolean enableRecord)
    {
        EnableRecord = enableRecord;
    }
    public void SetSortIndex(Int64? sortIndex)
    {
        SortIndex = sortIndex;
    }
    public void UpdateLastModified()
    {
        LastModified = DateTimeOffset.Now;
    }
    public void UpdateLastModified(DateTimeOffset? lastModified)
    {
        LastModified = lastModified;
    }
    public void SetDate(DateTimeOffset? created, DateTimeOffset? lastModified)
    {
        Created = created;
        UpdateLastModified(lastModified);
    }
    public void SetEntity(Boolean enableRecord, long? eRPCode, long? sortIndex)
    {
        SetEnable(enableRecord);
        SetSortIndex(sortIndex);
        SetERPCode(eRPCode);
    }
    public void SetEntity(String name, String? displayName, String? description, Boolean enableRecord)
    {
        SetNameAndDisplayName(name: name, displayName: displayName);
        SetEnable(enableRecord);
        Description = description;
    }
    public void SetEntity(String name, long? eRPCode, long? sortIndex, Boolean enableRecord)
    {
        SetEntity(enableRecord: enableRecord, eRPCode: eRPCode, sortIndex: sortIndex);
        SetName(name);
    }
    public void SetEntity(String name, String? displayName, Boolean enableRecord, long? eRPCode, long? sortIndex)
    {
        SetEntity(name: name, displayName: displayName, eRPCode: eRPCode, sortIndex: sortIndex, enableRecord: enableRecord);
        SetERPCode(eRPCode);
    }
    public void SetEntity(String name, String? displayName,
        Boolean enableRecord, long? eRPCode, long? sortIndex,
        DateTimeOffset? created, DateTimeOffset? lastModified)
    {
        SetEntity(name: name, displayName: displayName, enableRecord: enableRecord, eRPCode: eRPCode, sortIndex: sortIndex);
        SetDate(created: created, lastModified: lastModified);
    }
    public void SetEntity(long? eRPCode, long? sortIndex, Boolean enableRecord,
      DateTimeOffset? created, DateTimeOffset? lastModified)
    {
        SetSortIndex(sortIndex);
        SetEnable(enableRecord);
        SetDate(created: created, lastModified: lastModified);
        SetERPCode(eRPCode);
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