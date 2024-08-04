using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UseCases.Queries.Case.WorkItem.Get;

public record GetWorkItemQuery(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, bool Rebase = false) : IQuery<Result<F_WorkItem>>;