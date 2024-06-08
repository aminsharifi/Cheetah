﻿using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.Aggregates.CaseAggregate.DTOs;

public class WorkItemDTO
{
    public BaseClassWithNameAndDateDTO? Base { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
    public BaseClassWithNameDTO? WorkItemState { get; set; }
    public List<ConditionDTO?>? OccurredUserActions { get; set; }
}
