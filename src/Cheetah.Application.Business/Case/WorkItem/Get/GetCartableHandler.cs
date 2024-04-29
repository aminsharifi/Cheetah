using Cheetah.Domain.Entities.Facts;
using System.Diagnostics;

namespace Cheetah.Application.Business.WorkItem.Get;

public class GetCartableHandler(
    IReadRepository<F_WorkItem> _WorkItemRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<D_CaseState> _caseStateRepository,
    IReadRepository<F_Task> _taskRepository,
    IReadRepository<F_Scenario> _scenarioRepository,
    ISender _ISender, ICopyClass _iCopyClass)
  : IQueryHandler<GetCartableQuery, Result<IEnumerable<CartableDTO>>>
{
    public async Task<Result<IEnumerable<CartableDTO>>> Handle(GetCartableQuery request, CancellationToken cancellationToken)
    {
        if (request.cartableDTO.User is not null)
        {
            GetIdEntitySpec<D_User> _getIdEntitySpec = new(request.cartableDTO.User);

            var _userId = await _userRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.User = new() { Id = _userId.Value };
        }
        if (request.cartableDTO.Process is not null)
        {
            GetIdEntitySpec<D_Process> _getIdEntitySpec = new(request.cartableDTO.Process);

            var _processId = await _processRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.Process = new() { Id = _processId.Value };
        }
        
        if (request.cartableDTO.Scenario is not null)
        {
            GetIdEntitySpec<F_Scenario> _getIdEntitySpec = new(request.cartableDTO.Scenario);

            var _processId = await _scenarioRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.Scenario = new() { Id = _processId.Value };
        }
        if (request.cartableDTO.CaseState is not null)
        {
            GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(request.cartableDTO.CaseState);

            var _caseState = await _caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.CaseState = new() { Id = _caseState.Value };
        }

        var _GetCartableSpec = new GetCartableSpec(cartableDTO: request.cartableDTO, cartableProperty: request.cartableProperty);
        var Records = await _WorkItemRepository.ListAsync(_GetCartableSpec, cancellationToken);

        var _totalItems = await _WorkItemRepository.CountAsync(_GetCartableSpec, cancellationToken);

        var Inbox = Records
            .Select(x =>
            new CartableDTO()
            {
                PageSize = request.cartableDTO.PageSize,
                PageNumber = request.cartableDTO.PageNumber,
                TotalItems = _totalItems,          
                User = _iCopyClass.GetSimpleClass(
                _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.UserId)).GetAwaiter().GetResult()),                
                Process = _iCopyClass.GetSimpleClass(
                _processRepository.FirstOrDefaultAsync(new GetEntitySpec<D_Process>(x.Case.ProcessId)).GetAwaiter().GetResult()),
                Case = _iCopyClass.GetSimpleClass(x.Case),
                Requestor = _iCopyClass.GetSimpleClass(
                    _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.Case.RequestorId)).GetAwaiter().GetResult()),
                Creator = _iCopyClass.GetSimpleClass(
                    _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.Case.CreatorId)).GetAwaiter().GetResult()),
                CaseState = _iCopyClass.GetSimpleClass(x.Case.CaseState),
                WorkItem = _iCopyClass.GetSimpleClass(x),
                WorkItemState = _iCopyClass.GetSimpleClass(x.WorkItemState),
                Task = _iCopyClass.GetSimpleClass(
                    _taskRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Task>(x.TaskId)).GetAwaiter().GetResult()),
                ValidUserActions =
                (_ISender.Send(new GetFlowsByTaskQuery(x.TaskId)).GetAwaiter().GetResult().Value)
                .SelectMany(a => a.Flow.FlowConditions,
                (a, b) => _iCopyClass.GetSimpleClass(
                    _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(b.SecondId)).GetAwaiter().GetResult())),

                OccurredUserActions = x.WorkItemConditions.Select(x => _iCopyClass.GetSimpleClass(
                    _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(x.SecondId)).GetAwaiter().GetResult())),
                Summary = string.Empty
            }
            );     
        return Inbox.ToList();
    }
}
