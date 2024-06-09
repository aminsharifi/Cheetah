namespace Cheetah.Application.Business.Case.Get;

public record CopyCaseQuery(SimpleClassDTO Case, SimpleClassDTO Creator,
    SimpleClassDTO Requestor, SimpleClassDTO Process,
    List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
    List<ConditionDTO> WorkItemConditions) : IQuery<Result<F_Case>>;