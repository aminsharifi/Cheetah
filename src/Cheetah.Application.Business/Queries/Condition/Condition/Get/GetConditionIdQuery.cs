﻿namespace Cheetah.Application.Business.Queries.Condition.Condition.Get;
public record GetConditionIdQuery(ConditionDTO input) : IQuery<Result<long?>>;