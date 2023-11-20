namespace Cheetah.Domain.Data;

/// <summary>
/// CartableDTO use for Inbox and Outbox
/// </summary>
public class CartableDTO
{
    private readonly CPersianClass?  cPersianClass = new ();
    public Int64? PageNumber { get; set; }
    public Int64? ERPCode { get; set; }
    public Int64? PageSize { get; set; }
    public Int64? TotalItems { get; set; }
    public SimpleClassDTO? Tag { get; set; }
    public SimpleClassDTO? User { get; set; }
    public SimpleClassDTO? Requestor { get; set; }
    public SimpleClassDTO? WorkItem { get; set; }
    public String? RadNumber { get; set; }
    public String? WorkItemId { get; set; }
    public DateTime? CreateDate { get; set; }
    public String? PCreateDate
    {
        get { return cPersianClass.GetPersianDate(this.CreateDate); }
        set { PCreateDate = value; }
    }
    public DateTime? RecieveDate { get; set; }
    public String? PRecieveDate
    {
        get { return cPersianClass.GetPersianDate(this.RecieveDate); }
        set { PRecieveDate = value; }
    }
    public SimpleClassDTO? Process { get; set; }
    public SimpleClassDTO? Task { get; set; }
    public string? Summary { get; set; }
    public IEnumerable<SimpleClassDTO> ValidUserActions { get; set; }
    public SimpleClassDTO? CaseState { get; set; }

    //public CartableDTO()
    //{

    //}
    //public CartableDTO(String username)
    //{
    //    Username = username;
    //}
}