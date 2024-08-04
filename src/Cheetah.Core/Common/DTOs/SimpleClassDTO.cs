namespace Cheetah.Core.Common.DTOs;

public class SimpleClassDTO
{
    public long Id { get; set; }
    public long? SortIndex { get; set; }
    public string Name { get; set; }
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public bool EnableRecord { get; set; } = true;
    public long? ERPCode { get; set; }
    public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
}