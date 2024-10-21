using Cheetah.Core.Enums;
using Cheetah.Core.Interfaces.Cartable.DTOs;
using Cheetah.Core.Interfaces.Cartable;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListWorkItemsHistory(ILogger<ListWorkItemsHistory> logger, ICartable iCartable)
    : Endpoint<ListWorkItemsHistoryRequest, List<ListWorkItemsHistoryResponse>>
{
    public override void Configure()
    {
        Post(ListWorkItemsHistoryRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(ListWorkItemsHistoryRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(ListWorkItemsHistory) + " {@" + nameof(ListWorkItemsHistory) + "}", request);

        var output_Request = await iCartable.GetCartableAsync(request.Adapt<CartableRequest>(), CartableProperty.All);

        List<ListWorkItemsHistoryResponse> _listWorkItemsResponses = new();

        var _cases = output_Request.Value.Cases;

        foreach (var _case in _cases)
        {
            var _tasks = _case.Tasks;

            foreach (var _task in _tasks)
            {

                var _workItems = _task.WorkItems;

                foreach (var _workItem in _workItems)
                {
                    ListWorkItemsHistoryResponse _listWorkItemsResponse = new();

                    _listWorkItemsResponse.Case = _case.Base;
                    _listWorkItemsResponse.Form = _task.Form;

                    _listWorkItemsResponse.OccurredUserActions = _workItem?.OccurredUserActions?
                        .Select(x => x!.Base!)?.ToList();

                    _listWorkItemsResponse.Performer = _task.Performers?.Select(x => x.Base!).ToList();
                    _listWorkItemsResponse.Task = _task.Base;
                    _listWorkItemsResponse.WorkItem = _workItem?.Base;
                    _listWorkItemsResponse.User = _workItem?.User;
                    _listWorkItemsResponse.WorkItemState = _workItem?.WorkItemState;
                    _listWorkItemsResponse.OutputState = new() { Id = 0, Name = nameof(Ok) };

                    _listWorkItemsResponses.Add(_listWorkItemsResponse);
                }
            }
        }

        Response = _listWorkItemsResponses;

        logger.LogInformation("Ended " + nameof(ListWorkItemsHistory) + " {@" + nameof(ListWorkItemsHistory) + "}", output_Request);

        return;
    }
}