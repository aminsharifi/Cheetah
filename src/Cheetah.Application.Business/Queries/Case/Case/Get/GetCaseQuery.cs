namespace Cheetah.Application.Business.Queries.Case.Case.Get;

public record GetCaseQuery(SimpleClassDTO Case, SimpleClassDTO Creator,
    SimpleClassDTO Requestor, SimpleClassDTO Process,
    List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
    List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase) : IQuery<Result<F_Case>>;