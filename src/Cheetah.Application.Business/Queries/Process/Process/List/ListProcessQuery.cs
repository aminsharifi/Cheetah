﻿namespace Cheetah.Application.Business.Queries.Process.Process.List;

public record ListProcessQuery(IEnumerable<long?> processIds) : IQuery<Result<IEnumerable<D_Process>>>;