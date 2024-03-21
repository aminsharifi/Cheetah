using Cheetah.Application.Business.Tags.Create;
using MediatR;
using System.Threading;

namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService(ILogger<RequestService> logger, ApplicationDbContext db,
        ITableCRUD simpleClassRepository, ICartable iCartable, IWorkItem iWorkItem,
        ICopyClass iCopyClass, IMediator _mediator) : Request.RequestBase
{
    #region Public methods
    public override async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", request);

        #region Input

        F_Case f_Request = request.Case.GetSimpleClass<F_Case>();
        f_Request.Creator = request.Creator.GetSimpleClass<D_User>();
        f_Request.Requestor = request.Requestor.GetSimpleClass<D_User>();
        f_Request.Process = request.Process.GetSimpleClass<D_Process>();

        var _conditions = request.Conditions.GetConditions().ToList();

        f_Request.CaseConditions = await GetCaseCondition(_conditions);

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

        output_Request.Case = await GetCase(f_Request);

        #endregion

        logger.LogInformation("Ended " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", output_Request);

        return output_Request;
    }
    public override async Task<GetCase_Output> GetCase(GetCase_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", request);

        #region Input
        var _request = request.Case?.GetSimpleClass<F_Case>();
        _request.CaseState = request.CaseState?.GetSimpleClass<D_CaseState>();
        _request.Process = request.Process?.GetSimpleClass<D_Process>();
        #endregion

        var _requests = await iCartable.GetCaseAsync(_request);

        #region Output

        GetCase_Output output_Request = new();

        if (!_requests.Any())
        {
            output_Request.OutputState = OutputState<Boolean>
                .NotFoundErrorCreateRequest(false)
                .SimpleClassDTO
                .GetBaseClassWithName();

            return output_Request;
        }

        var _selectedRequests = _requests.FirstOrDefault();

        output_Request.Case = await GetCase(_selectedRequests);

        output_Request.OutputState = OutputState<Boolean>
            .Success(nameof(GetCase), true)
            .SimpleClassDTO.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", output_Request);

        return output_Request;
    }
    public override async Task<Cartable_Output> Inbox(Cartable_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Inbox);

        logger.LogInformation("Ended " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", output_Request);

        return output_Request;
    }
    public override async Task<Cartable_Output> Outbox(Cartable_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Outbox);

        logger.LogInformation("Ended " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", output_Request);

        return output_Request;
    }
    public override async Task<PerformRequest_Output> PerformRequest(PerformRequest_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", request);

        #region Input

        var f_WorkItem = request.WorkItem.GetWorkItemClass();

        #endregion

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem, request.Rebase);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        PerformRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        var _resultOfCase = Outputresult.Result.Value;

        output_Request.Case = await GetCase(_resultOfCase);

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", output_Request);

        return output_Request;
    }
    public override async Task<GetAllByName_Output> GetAllByName(GetAllByName_Input request, ServerCallContext context)
    {
        //var result = await _mediator.Send(new CreateTagCommand(Name: "Tag1", DisplayName: "تگ 1"));

        logger.LogInformation("started " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", request);

        #region Input

        GetAllByName_Output output_Request = new();

        if (String.IsNullOrWhiteSpace(request.TableInput.Name))
        {
            return output_Request;
        }

        output_Request.TableInput = request.TableInput;

        #endregion

        var TableRecords = await simpleClassRepository.GetAllBySimpleClass(output_Request.TableInput.GetSimpleClass<SimpleClassDTO>());

        #region Output

        output_Request.TableInput = TableRecords.Item1.GetBaseClassWithName();

        output_Request.TableOutput.AddRange(TableRecords.Item2.Select(x => x.GetBaseClassWithName()));

        output_Request.OutputState = OutputState<Boolean>.Success(nameof(GetAllByName), true).SimpleClassDTO.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", output_Request);

        return output_Request;
    }
    public override async Task<SetCaseTaskUser_Output> SetCaseTaskUser(SetCaseTaskUser_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input

        L_CaseTaskUser l_CaseTaskUser = new();
        l_CaseTaskUser.Case = request.Case.GetSimpleClass<F_Case>();
        l_CaseTaskUser.Task = request.Task.GetSimpleClass<F_Task>();
        l_CaseTaskUser.User = request.User.GetSimpleClass<D_User>();

        #endregion

        var Outputresult = await iWorkItem.SetCaseTaskUser(l_CaseTaskUser);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        SetCaseTaskUser_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        var _list_CaseTaskUser = Outputresult.Result.Value;

        output_Request.Case = Outputresult.Result.Value.Case.GetBaseClass();
        output_Request.Task = Outputresult.Result.Value.Task.GetBaseClassWithName();
        output_Request.User = Outputresult.Result.Value.User.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", output_Request);

        return output_Request;
    }
    #endregion 

    #region Private methods
    private async Task<Cartable_Output> Cartable(Cartable_Input request, CartableProperty cartableProperty)
    {
        logger.LogInformation("started " + nameof(Cartable));
        logger.LogInformation("{@InputCartable}", request);

        #region Input

        var _assignee = request.Assignee?.GetSimpleClass<SimpleClassDTO>();
        var _process = request.Process?.GetSimpleClass<SimpleClassDTO>();
        var _caseState = request.CaseState?.GetSimpleClass<SimpleClassDTO>();
        var _case = request.Case?.GetSimpleClass<SimpleClassDTO>();
        var _workItem = request.WorkItem?.GetSimpleClass<SimpleClassDTO>();

        var cartableDTO = new CartableDTO()
        {
            User = _assignee,
            Process = _process,
            Case = _case,
            WorkItem = _workItem,
            CaseState = _caseState,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber,
        };

        #endregion

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await iCartable.Inbox(cartableDTO) :
           await iCartable.Outbox(cartableDTO)).ToList<CartableDTO>();

        #region Output
        Cartable_Output _OutputCartable = new();


        if (OutputRequest.Count() > 0)
        {
            _OutputCartable.TotalItems = OutputRequest.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.PageSize = OutputRequest.FirstOrDefault()?.PageSize.Value;
            _OutputCartable.PageNumber = OutputRequest.FirstOrDefault()?.PageNumber.Value;


            foreach (var outputRequestItem in OutputRequest)
            {
                GRPC_Case _Case = new()
                {
                    Base = outputRequestItem.Case.GetBaseClassWithDate(),
                    CaseState = outputRequestItem.CaseState.GetBaseClassWithName(),
                    Creator = outputRequestItem.Creator.GetBaseClassWithName(),
                    Requestor = outputRequestItem.Requestor.GetBaseClassWithName(),
                    Process = outputRequestItem.Process.GetBaseClassWithName()
                };

                GRPC_Task _task = new();

                _task.Base = outputRequestItem.Task.GetBaseClassWithName();

                GRPC_WorkItem _gRPC_WorkItem = new();

                _gRPC_WorkItem.Base = outputRequestItem.WorkItem.GetBaseClassWithDate();

                _gRPC_WorkItem.User = outputRequestItem.User.GetBaseClassWithName();

                _gRPC_WorkItem.WorkItemState = outputRequestItem.WorkItemState.GetBaseClassWithName();

                var _conditions = await GetConditions(_gRPC_WorkItem);
                _gRPC_WorkItem.ValidUserActions.AddRange(_conditions.ValidUserActions);
                _gRPC_WorkItem.OccurredUserActions.AddRange(_conditions.OccurredUserActions);


                _task.WorkItems.Add(_gRPC_WorkItem);

                _Case.Tasks.Add(_task);

                _OutputCartable.Cases.Add(_Case);
            }
        }
        #endregion

        logger.LogInformation("Ended " + nameof(Cartable));
        logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = OutputState<Boolean>
            .Success(nameof(Cartable), true)
            .SimpleClassDTO.GetBaseClassWithName();

        return _OutputCartable;
    }
    private async Task<List<L_CaseCondition>> GetCaseCondition(List<F_Condition> Conditions)
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
    private async Task<GRPC_Case> GetCase(F_Case Case)
    {
        F_Case _case = db
            .F_Cases
            .Where(x => x.Id == Case.Id)
            .AsNoTracking()
            .FirstOrDefault();

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
                var _conditions = await GetConditions(workItem);
                workItem.ValidUserActions.AddRange(_conditions.ValidUserActions);
                workItem.OccurredUserActions.AddRange(_conditions.OccurredUserActions);
            }
        }

        #endregion

        return _gRPC_Case;
    }
    private async Task<GRPC_WorkItem> GetConditions(GRPC_WorkItem gRPC_WorkItem)
    {
        var _workItemId = gRPC_WorkItem.Base.Id;

        var _workItem = await db
        .F_WorkItems
           .Where(x => x.Id == _workItemId)
           .AsNoTracking()
           .SingleAsync();

        #region OccurredUserActions

        var _occurredUserActions = _workItem
            .WorkItemConditions
            .Select(x => x.Condition)
        .GetConditions();

        gRPC_WorkItem.OccurredUserActions.AddRange(_occurredUserActions);
        #endregion

        #region ValidUserActions
        var _validUserActions = _workItem
            .Task.TaskFlows
            .SelectMany(x => x.Flow.FlowConditions, (x, y) => y.Condition)
        .GetConditions();

        gRPC_WorkItem.ValidUserActions.AddRange(_validUserActions);
        #endregion
        return gRPC_WorkItem;
    }
    #endregion
}