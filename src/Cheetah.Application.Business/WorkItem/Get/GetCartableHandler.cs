namespace Cheetah.Application.Business.WorkItem.Get;

public class GetCartableHandler(
    IReadRepository<F_WorkItem> _WorkItemRepository,
    ISender _ISender, ICopyClass _iCopyClass)
  : IQueryHandler<GetCartableQuery, Result<IEnumerable<CartableDTO>>>
{
    public async Task<Result<IEnumerable<CartableDTO>>> Handle(GetCartableQuery request, CancellationToken cancellationToken)
    {
        var _GetCartableSpec = new GetCartableSpec(cartableDTO: request.cartableDTO, cartableProperty: request.cartableProperty);
        var Records = await _WorkItemRepository.ListAsync(_GetCartableSpec, cancellationToken);
        var Inbox = Records
            .Select(x =>
            new CartableDTO()
            {
                PageSize = request.cartableDTO.PageSize,
                PageNumber = request.cartableDTO.PageNumber,
                TotalItems = request.cartableDTO.TotalItems,
                Process = _iCopyClass.GetSimpleClass(x.Case.Process),
                User = _iCopyClass.GetSimpleClass(x.User),
                Case = _iCopyClass.GetSimpleClass(x.Case),
                Requestor = _iCopyClass.GetSimpleClass(x.Case.Requestor),
                Creator = _iCopyClass.GetSimpleClass(x.Case.Creator),
                CaseState = _iCopyClass.GetSimpleClass(x.Case.CaseState),
                WorkItem = _iCopyClass.GetSimpleClass(x),
                WorkItemState = _iCopyClass.GetSimpleClass(x.WorkItemState),
                Task = _iCopyClass.GetSimpleClass(x.Task),
                ValidUserActions = x.Task.TaskFlows.SelectMany(a => a.Flow.FlowConditions, (a, b) => _iCopyClass.GetSimpleClass(b.Condition)),
                OccurredUserActions = x.WorkItemConditions.Select(x => _iCopyClass.GetSimpleClass(x.Condition)),
                Summary = string.Empty
            }
   );

        return Inbox.ToList();
    }
}
