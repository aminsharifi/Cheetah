using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Application.Business.Queries.Process.List;

public record ListProcessQuery(IEnumerable<long> processIds) : IQuery<Result<IEnumerable<D_Process>>>;