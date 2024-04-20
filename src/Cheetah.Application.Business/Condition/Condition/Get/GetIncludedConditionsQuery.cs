namespace Cheetah.Application.Business.Condition.Get;

public record GetIncludedConditionsQuery(IEnumerable<long> input) : IQuery<Result<IEnumerable<F_Condition>>>;
