namespace Cheetah.Domain.Common;

public abstract class SimpleClass
{
    public Int64? Id { get; set; }
    public Int64? SortIndex { get; set; }
    public String? Name { get; set; }
    public String? DisplayName { get; set; }
    public String? Description { get; set; }
    public DateTimeOffset? CreateTimeRecord { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? LastUpdatedRecord { get; set; }
    public Guid? GuidRecord { get; set; } = Guid.NewGuid();
    public Boolean? EnableRecord { get; set; } = true;
    public Int64? ERPCode { get; set; }

    public SimpleClass()
    {
        /*
         
            [Description("شناسه")]
         
        */
    }
    public virtual void SetName()
    {

    }
}