using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces.Cartable.DTOs;

/// <summary>
/// CartableDTO use for Inbox and Outbox
/// </summary>
public class CartableDTO
{
    #region pagination
    public long? PageNumber { get; set; }
    public long? PageSize { get; set; }
    public long? TotalItems { get; set; }
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
    public IEnumerable<ConditionDTO> OccurredUserActions { get; set; }

    #endregion

    #region process
    public SimpleClassDTO? Scenario { get; set; }
    public SimpleClassDTO? Process { get; set; }
    public SimpleClassDTO? Task { get; set; }
    public SimpleClassDTO? Form { get; set; }
    public IEnumerable<ConditionDTO> ValidUserActions { get; set; } = default!;
    #endregion

    public string? Summary { get; set; }
}