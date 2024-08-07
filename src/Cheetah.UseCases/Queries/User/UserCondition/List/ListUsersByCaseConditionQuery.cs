﻿namespace Cheetah.UseCases.Queries.User.UserCondition.List;

public record ListUsersByCaseConditionQuery(IEnumerable<long> UserFilter, IEnumerable<long> ConditionFilter) : IQuery<Result<IEnumerable<long>>>;