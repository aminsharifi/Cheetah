using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.WorkItem.Get;

public record GetWorkItemQuery(SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, bool Rebase = false) : IQuery<Result<F_WorkItem>>;