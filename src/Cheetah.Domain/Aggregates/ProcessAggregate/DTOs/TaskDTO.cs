namespace Cheetah.Domain.Aggregates.ProcessAggregate.DTOs;

public class TaskDTO
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<ConditionDTO?>? Performers { get; set; }
    public List<ConditionDTO?>? ValidUserActions { get; set; }
    public List<WorkItemDTO>? WorkItems { get; set; }
}
