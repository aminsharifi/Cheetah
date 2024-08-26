using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public record GetCaseQuery(SimpleClassDTO Case, SimpleClassDTO Creator,
    SimpleClassDTO Requestor, SimpleClassDTO Process,
    List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
    List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase) : IQuery<Result<F_Case>>;