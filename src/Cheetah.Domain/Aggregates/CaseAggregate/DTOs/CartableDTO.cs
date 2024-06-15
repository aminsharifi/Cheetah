namespace Cheetah.Domain.Aggregates.CaseAggregate.DTOs;

/// <summary>
/// CartableDTO use for Inbox and Outbox
/// </summary>
public class CartableDTO
{
    #region pagination
    public Int64? PageNumber { get; set; }
    public Int64? PageSize { get; set; }
    public Int64? TotalItems { get; set; }
    #endregion

    #region User
    public SimpleClassDTO? User { get; set; }
    public SimpleClassDTO? Requestor { get; set; }
    public SimpleClassDTO? Creator { get; set; }
    #endregion

    #region Case
    public SimpleClassDTO? Case { get; set; }
    public SimpleClassDTO? CaseState { get; set; }
    public IEnumerable<SimpleClassDTO>? CaseStateList { get; set; }
    public SimpleClassDTO? WorkItem { get; set; }
    public SimpleClassDTO? WorkItemState { get; set; }    
    public IEnumerable<SimpleClassDTO> OccurredUserActions { get; set; }

    #endregion

    #region process
    public SimpleClassDTO? Scenario { get; set; }
    public SimpleClassDTO? Process { get; set; }
    public SimpleClassDTO? Task { get; set; }
    public IEnumerable<SimpleClassDTO> ValidUserActions { get; set; }
    #endregion

    public string? Summary { get; set; }
}