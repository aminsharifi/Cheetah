namespace Cheetah.Domain.Common;

public class SimpleClassDTO
{
    public Int64 Id { get; set; }
    public Int64? SortIndex { get; set; }
    public String Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get;  set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean EnableRecord { get;  set; } = true;
    public Int64? ERPCode { get; set; }
    public DateTimeOffset? Created { get;  set; } = DateTimeOffset.Now;
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }   
}