namespace Cheetah.Presentation.Services.Shared.Services;

public class RequestService(ILogger<RequestService> logger,
        ITableCRUD simpleClassRepository, ICartable iCartable, IWorkItem iWorkItem,
        ICopyClass iCopyClass, ISync iSync, IMediator _mediator) : Request.RequestBase
{
    public Health_Output Health()
    {
        Health_Output _health_Output = new();
        _health_Output.DisplayName = "Ok!";
        return _health_Output;
    }

    public async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request)
    {
        logger.LogInformation("started " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", request);

        #region Input

        F_Case f_Request = request.Case.GetSimpleClass<F_Case>();
        f_Request.Creator = request.Creator.GetSimpleClass<D_User>();
        f_Request.Requestor = request.Requestor.GetSimpleClass<D_User>();
        f_Request.Process = request.Process.GetSimpleClass<D_Process>();

        var _conditions = request.Conditions.GetConditions().ToList();

        f_Request.CaseConditions = GetCaseCondition(_conditions);

        F_WorkItem _workItem = request.WorkItem.GetWorkItemClass();

        f_Request.WorkItems.Add(_workItem);

        #endregion

        var Outputresult = await iWorkItem.CreateRequestAsync(f_Request);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        CreateRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        f_Request = Outputresult.Result.Value;

        var _requests = (await iCartable.GetCaseAsync(f_Request)).Value.FirstOrDefault();

        output_Request.Case = GetCase(_requests);

        #endregion

        logger.LogInformation("Ended " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", output_Request);

        return output_Request;
    }

    public List<L_CaseCondition> GetCaseCondition(List<F_Condition> Conditions)
    {
        List<L_CaseCondition> _caseConditions = new();

        foreach (var _condition in Conditions)
        {
            L_CaseCondition _CaseCondition = new()
            {
                Condition = _condition,
                SecondId = _condition.Id
            };

            _caseConditions.Add(_CaseCondition);
        }
        return _caseConditions;
    }

    public GRPC_Case GetCase(F_Case _case)
    {
        GRPC_Case _gRPC_Case = new()
        {
            Base = _case?.GetBaseClassWithDate(),
            CaseState = _case?.CaseState?.GetBaseClassWithName(),
            Process = _case?.Process?.GetBaseClassWithName(),
            Creator = _case?.Creator.GetBaseClassWithName(),
            Requestor = _case?.Requestor.GetBaseClassWithName()
        };

        #region Tasks

        var Tasks = _case?
            .SelectedScenario
            .Tasks
            .OrderBy(x => x.SortIndex)
            .ToList();

        _gRPC_Case.Tasks.AddRange(
            Tasks.Select(x => new GRPC_Task()
            {
                Base = x.GetBaseClassWithName()
            })
            );

        #endregion

        #region L_WorkItem

        foreach (var Task in _gRPC_Case.Tasks)
        {
            Task.WorkItems.AddRange(
            _case?.WorkItems
                .Where(x => x.TaskId == Task.Base.Id)
                .Select(x => new GRPC_WorkItem()
                {
                    Base = x.GetBaseClassWithDate(),
                    User = x.User.GetBaseClassWithName(),
                    WorkItemState = x.WorkItemState?.GetBaseClassWithName()
                })
                );
            foreach (var workItem in Task.WorkItems)
            {
                var _WorkItem = _case?.WorkItems
                    .Where(x => x.Id == workItem.Base.Id)
                    .SingleOrDefault();

                var _conditions = GetConditions(_WorkItem);
                workItem.ValidUserActions.AddRange(_conditions.ValidUserActions);
                workItem.OccurredUserActions.AddRange(_conditions.OccurredUserActions);
            }
        }

        #endregion

        return _gRPC_Case;
    }

    public GRPC_WorkItem GetConditions(F_WorkItem workItem)
    {
        GRPC_WorkItem gRPC_WorkItem = new();

        #region OccurredUserActions

        var _occurredUserActions = workItem
            .WorkItemConditions
            .Select(x => x.Condition)
        .GetConditions();

        gRPC_WorkItem.OccurredUserActions.AddRange(_occurredUserActions);
        #endregion

        #region ValidUserActions
        var _validUserActions = workItem
            .Task.TaskFlows
            .SelectMany(x => x.Flow.FlowConditions, (x, y) => y.Condition)
        .GetConditions();

        gRPC_WorkItem.ValidUserActions.AddRange(_validUserActions);
        #endregion
        return gRPC_WorkItem;
    }
}