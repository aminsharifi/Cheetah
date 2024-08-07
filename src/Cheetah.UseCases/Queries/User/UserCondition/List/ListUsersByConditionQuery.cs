﻿namespace Cheetah.UseCases.Queries.User.UserCondition.List;

public record ListUsersByConditionQuery(IEnumerable<long> performerConditions) : IQuery<Result<IEnumerable<long>>>;
