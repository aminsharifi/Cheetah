namespace Cheetah.Domain.Common;

/// <summary>
/// CartableDTO use for Inbox and Outbox
/// </summary>
public class CartableDTO
{
    private readonly CPersianClass? cPersianClass = new();
    public Int64? PageNumber { get; set; }
    public Int64? PageSize { get; set; }
    public Int64? TotalItems { get; set; }
    public SimpleClassDTO? Tag { get; set; }
    public SimpleClassDTO? User { get; set; }
    public SimpleClassDTO? Requestor { get; set; }
    public SimpleClassDTO? WorkItem { get; set; }
    public SimpleClassDTO? Case { get; set; }
    public SimpleClassDTO? Process { get; set; }
    public SimpleClassDTO? Endorsement { get; set; }
    public SimpleClassDTO? CaseState { get; set; }
    public string? Summary { get; set; }
    public IEnumerable<SimpleClassDTO> ValidUserActions { get; set; }

    //public CartableDTO()
    //{

    //}
    //public CartableDTO(String username)
    //{
    //    Username = username;
    //}
}