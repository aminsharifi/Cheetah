using Cheetah.Core.Entities.Dimentions;

namespace Cheetah.UseCases.Queries.Process.List;

public record ListProcessQuery(IEnumerable<long> processIds) : IQuery<Result<IEnumerable<D_Process>>>;