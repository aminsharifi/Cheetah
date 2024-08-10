using Cheetah.Core.Aggregates.CaseAggregate.DTOs;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Aggregates.ProcessAggregate.DTOs;

public class TaskDTO
{
    public BaseClassWithNameDTO? Base { get; set; } = new();
    public BaseClassWithNameDTO? Form { get; set; } = new();
    public List<ConditionDTO>? Performers { get; set; } = new();
    public List<ConditionDTO>? ValidUserActions { get; set; } = new();
    public List<WorkItemDTO>? WorkItems { get; set; } = new();
}
