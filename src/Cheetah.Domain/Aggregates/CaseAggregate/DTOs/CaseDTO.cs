using Cheetah.Domain.Aggregates.ProcessAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Aggregates.CaseAggregate.DTOs;
public class CaseDTO
{
    public BaseClassWithDateDTO? Base { get; set; }
    public long? ProcessId { get; set; }
    public long? CreatorId { get; set; }
    public long? RequestorId { get; set; }
    public List<TaskDTO>? Tasks { get; set; }
    public BaseClassWithNameDTO? CaseState { get; set; }
}
