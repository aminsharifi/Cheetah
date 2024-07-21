using Cheetah.Application.Business.Helper;
using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public static class GetCaseConditions
{
    public static async Task<F_Case> Apply(
        F_Case f_case,
        List<ConditionDTO> caseConditions,
        IReadRepository<F_Condition> conditionRepository,
        IMapper iMapper,
        CancellationToken cancellationToken)
    {
        if (caseConditions is not null && caseConditions.Count > 0)
        {
            await Parallel.ForEachAsync(caseConditions, async (_condition, _cancellatoin) =>
            {
                var _getCondition = await conditionRepository
                .FirstOrDefaultAsync(new GetIdEntitySpec<F_Condition>
                (_condition.GetCondition(iMapper).Adapt<SimpleClassDTO>()));
                f_case!.CaseConditions!.Add((L_CaseCondition)new L_CaseCondition().SetSecondId(_getCondition.Value));
            });
        }

        return f_case;
    }
}
