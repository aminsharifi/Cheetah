using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.DTOs;

public class TaskDTO
{
    public BaseClassWithNameDTO? Base { get; set; } = new();
    public BaseClassWithNameDTO? Form { get; set; } = new();
    public List<ConditionDTO>? Performers { get; set; } = new();
    public List<ConditionDTO>? ValidUserActions { get; set; } = new();
    public List<WorkItemDTO>? WorkItems { get; set; } = new();
}
