using Type = System.Type;

namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService : Cheetah_GrpcService.Request.RequestBase
{
    private readonly ILogger<RequestService> _logger;
    private readonly ITableCRUD simpleClassRepository;
    private readonly ICartable iCartable;
    private readonly ISync iSync;
    private readonly IWorkItem iWorkItem;
    private readonly IMapper _mapper;
    private readonly ICopyClass _iCopyClass;
    protected ApplicationDbContext _db;
    public RequestService(ILogger<RequestService> logger,
        ApplicationDbContext db,
        ITableCRUD iP_ParameterListRepository,
        ICartable _iCartable, ISync _iSync,  IWorkItem _iWorkItem,
        IMapper mapper, ICopyClass _iCopyClass)
    {
        _logger = logger;
        _db = db;
        this._mapper = mapper;
        this.simpleClassRepository = iP_ParameterListRepository;
        this.iCartable = _iCartable;
        this.iSync = _iSync;
        this.iWorkItem = _iWorkItem;
        this._iCopyClass = _iCopyClass;
    }

    public IEnumerable<F_Condition> GetCondition(IEnumerable<Condition> Conditions)
    {
        foreach (var Condition in Conditions)
        {
            var f_Condition = new F_Condition();

            if (Condition.Base is not null)
            {
                f_Condition.Id = Condition.Base.Id;
                f_Condition.Name = Condition.Base.Name;
                f_Condition.ERPCode = Condition.Base.ERPCode;
            }

            if (Condition.Tag is not null)
            {
                f_Condition.Tag = new D_Tag() { ERPCode = Condition?.Tag?.ERPCode };
            }
            if (Condition.Operand is not null)
            {
                f_Condition.Operand = new D_Operand() { ERPCode = Condition?.Operand?.ERPCode };
            }
            if (Condition.Value is not null)
            {
                f_Condition.Value = Condition.Value;
            }

            yield return f_Condition;
        }
    }
    public SimpleClass GetSimpleClass(Type type, GRPC_BaseClass gRPC_BaseClass)
    {
        var _SimpleClass = (SimpleClass)Activator.CreateInstance(type);

        if (gRPC_BaseClass is not null)
        {
            if (gRPC_BaseClass.Id > 0)
            {
                _SimpleClass.Id = gRPC_BaseClass.Id;
            }
            else if (gRPC_BaseClass.ERPCode > 0)
            {
                _SimpleClass.ERPCode = gRPC_BaseClass.ERPCode;
            }
            else if (!String.IsNullOrEmpty(gRPC_BaseClass.Name))
            {
                _SimpleClass.Name = gRPC_BaseClass.Name;
            }
        }
        return _SimpleClass;
    }
    public override async Task<Brief_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
    {
        _logger.LogInformation("started " + nameof(CreateRequest));
        _logger.LogInformation("{@Create_Input_Request}", request);

        var output_Request = new Brief_Request();

        var f_Request = new F_Case();

        f_Request.Creator = (D_User)GetSimpleClass(typeof(D_User), request.Creator);
        f_Request.Requestor = (D_User)GetSimpleClass(typeof(D_User), request.Requestor);
        f_Request.Process = (D_Process)GetSimpleClass(typeof(D_Process), request.Process);

        f_Request.ERPCode = request.ERPCode;

        f_Request.Conditions = GetCondition(request.Conditions).ToList();

        var Outputresult = await iWorkItem.CreateRequestAsync(f_Request);

        f_Request = Outputresult.Result.Value;

        var OutputState = Outputresult.SimpleClassDTO;

        output_Request.OutputState = GetBaseClass(OutputState);

        if (OutputState.Id > 0)
        {
            return output_Request;
        }

        output_Request.CaseId = f_Request.Id.Value;

        output_Request.ERPCode = f_Request.ERPCode.Value;

        var processes = await _db.D_Processes
            .Where(x => x.Id == f_Request.ProcessId)
            .SingleAsync();

        output_Request.Process = GetBaseClass(processes);

        var caseState = await _db.D_CaseStates
            .Where(x => x.Id == f_Request.CaseStateId)
            .SingleAsync();

        output_Request.CaseState = GetBaseClass(caseState);

        _logger.LogInformation("Ended " + nameof(CreateRequest));
        _logger.LogInformation("{@Brief_Request}", output_Request);

        return output_Request;
    }
    public GRPC_BaseClass GetBaseClass(SimpleClass simpleClass)
    {
        var _GRPC_BaseClass = new GRPC_BaseClass();

        if (simpleClass is not null)
        {
            _GRPC_BaseClass = new GRPC_BaseClass()
            {
                Id = simpleClass.Id.HasValue ? simpleClass.Id.Value : 0,
                ERPCode = simpleClass.ERPCode.HasValue ? simpleClass.ERPCode.Value : 0,
                Name = (simpleClass.Name is not null) ? simpleClass.Name : String.Empty,
                DisplayName = (simpleClass.DisplayName is not null) ? simpleClass.DisplayName : String.Empty
            };
        }

        return _GRPC_BaseClass;
    }
    public override async Task<Brief_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
    {
        _logger.LogInformation("started " + nameof(PerformRequest));
        _logger.LogInformation("{@Perform_Input_Request}", request);

        var f_WorkItem = new F_WorkItem();

        f_WorkItem.Id = request.WorkItemId;

        f_WorkItem.Case = new F_Case();

        f_WorkItem.Case.Conditions = GetCondition(request.Conditions).ToList();

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem);
        f_WorkItem = Outputresult.Result.Value;
        var OutputState = Outputresult.SimpleClassDTO;

        var output_Request = new Brief_Request()
        {
            CaseId = f_WorkItem.Case.Id.Value,
            ERPCode = f_WorkItem.Case.ERPCode.Value,
            CaseState = GetBaseClass(f_WorkItem.Case.CaseState),
            Process = GetBaseClass(f_WorkItem.Case.Process)
        };
        output_Request.OutputState = GetBaseClass(OutputState);

        _logger.LogInformation("Ended " + nameof(PerformRequest));
        _logger.LogInformation("{@Brief_Request}", output_Request);

        return output_Request;
    }
    public override async Task<DetailOutput_Requests> GetCase(Brief_Request request, ServerCallContext context)
    {
        F_Case f_Request = new();

        #region CaseId
        if (request.CaseId > 0)
        {
            f_Request.Id = request.CaseId;
        }
        #endregion

        #region ERPCode
        if (request.ERPCode > 0)
        {
            f_Request.ERPCode = request.ERPCode;
        }
        #endregion

        var _Process = (D_Process)GetSimpleClass(typeof(D_Process), request.Process);

        f_Request.ProcessId = await _iCopyClass.GetSimpleClassId(_db.D_Processes, _Process);

        var _CaseState = (D_CaseState)GetSimpleClass(typeof(D_CaseState), request.CaseState);

        f_Request.CaseStateId = await _iCopyClass.GetSimpleClassId(_db.D_CaseStates, _CaseState);

        var l_Requests = await iCartable.GetCaseAsync(f_Request);

        #region DetailOutput_Request

        DetailOutput_Requests output_Requests = new();

        var Endorsements = _db.F_Cases
           .SelectMany(x => x.WorkItems)
           .Where(x => x.Endorsement != null)
           .Select(x => x.Endorsement)
           .Distinct();

        var d_Tags = await _db.D_Tags.AsNoTracking().ToListAsync();

        foreach (var l_Request in l_Requests)
        {
            DetailOutput_Request output_Request = new();
            output_Request = new()
            {
                Id = l_Request.Id.Value,
                Process = new GRPC_BaseClass() { Name = l_Request.Process.Name },
                ERPCode = l_Request.ERPCode.Value
            };

            #region CaseState
            output_Request.CaseState = GetBaseClass(l_Request.CaseState);
            #endregion

            #region Endorsements

            var lendorsements = await Endorsements
                .OrderBy(x => x.SortIndex)
                .ToListAsync();

            var endorsements = lendorsements
                .Select(x => new GRPC_Assignment()
                {
                    Endorsement = GetBaseClass(x)
                });

            output_Request.Assignments.AddRange(endorsements);

            #endregion

            #region L_WorkItem

            var L_WorkItems = l_Request.WorkItems.ToList();

            foreach (var Assignment in output_Request.Assignments)
            {
                Assignment.UserAssignments.AddRange
                    (
                        L_WorkItems.Where(x => x.EndorsementId == Assignment.Endorsement.Id)
                        .Select(x => new GRPC_UserAssignment()
                        {
                            WorkItemId = x.Id.Value,
                            LastUpdatedRecord =
                            (x.LastUpdatedRecord is null) ? new Timestamp() :
                            Timestamp.FromDateTime(
                                DateTime.SpecifyKind(x.LastUpdatedRecord.Value, DateTimeKind.Utc)),
                            User = GetBaseClass(x.User),
                            WorkItemState = GetBaseClass(x.WorkItemState)
                        }
                        )
                );
            }

            #region d_Tag


            foreach (var Assignment in output_Request.Assignments)
            {
                foreach (var UserAssignment in Assignment.UserAssignments)
                {
                    var TagId = L_WorkItems.Where(x => x.Id == UserAssignment.WorkItemId).Single().TagId;

                    if (TagId is not null && TagId > 0)
                    {
                        var d_Tag = d_Tags.Where(x => x.Id == TagId).SingleOrDefault();
                        UserAssignment.Tag = GetBaseClass(d_Tag);
                    }
                }
            }

            #endregion

            #endregion

            output_Requests.DetailOutputRequest.Add(output_Request);
        }

        #endregion

        return output_Requests;
    }
    public async Task<OutputCartable> Cartable(InputCartable request, CartableProperty cartableProperty)
    {
        _logger.LogInformation("started " + nameof(Cartable));
        _logger.LogInformation("{@InputCartable}", request);

        OutputCartable _OutputCartable = new();

        var _D_User = (SimpleClassDTO)GetSimpleClass(typeof(SimpleClassDTO), request.Assignee);
        var _D_Process = (SimpleClassDTO)GetSimpleClass(typeof(SimpleClassDTO), request.Process);
        var _D_CaseState = (SimpleClassDTO)GetSimpleClass(typeof(SimpleClassDTO), request.CaseState);

        var cartableDTO = new CartableDTO()
        {
            User = _D_User,
            Process = _D_Process,
            CaseState = _D_CaseState,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber
        };

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await iCartable.Inbox(cartableDTO) :
           await iCartable.Outbox(cartableDTO)).ToList<CartableDTO>();

        if (OutputRequest.Count() > 0)
        {
            _OutputCartable.TotalItems = OutputRequest.FirstOrDefault().TotalItems.Value;
            _OutputCartable.Assignee = GetBaseClass(OutputRequest.FirstOrDefault().User);
            _OutputCartable.Process = GetBaseClass(OutputRequest.FirstOrDefault().Process);
            _OutputCartable.CaseState = GetBaseClass(OutputRequest.FirstOrDefault().CaseState);

            var _Recordtable = OutputRequest.Select(
                 x => new RecordCartable()
                 {
                     CreateDate = Timestamp.FromDateTime(
                         DateTime.SpecifyKind(
                         x.CreateDate.Value, DateTimeKind.Utc)),
                     CaseState = GetBaseClass(x.CaseState),
                     DTag = GetBaseClass(x.Tag),
                     RecieveDate = Timestamp.FromDateTime
                     (DateTime.SpecifyKind(x.RecieveDate.Value, DateTimeKind.Utc)),
                     Summary = x.Summary ?? String.Empty,
                     Process = GetBaseClass(x.Process),
                     CaseId = long.Parse(x.RadNumber),
                     ERPCode = x.ERPCode.Value,
                     WorkItemId = long.Parse(x.WorkItemId),
                     Requestor = GetBaseClass(x.Requestor),
                     Task = GetBaseClass(x.Task)
                 }
                 );

            _OutputCartable.RecordCartables.AddRange(_Recordtable);

            foreach (var RecordCartable in _OutputCartable.RecordCartables)
            {
                RecordCartable.ValidUserActions.AddRange(
                   OutputRequest
                   .Where(x => x.WorkItemId == RecordCartable.WorkItemId.ToString())
                   .Single().ValidUserActions
                   .Select(y => GetBaseClass(y))
                   );
            }
        }
        _logger.LogInformation("Ended " + nameof(Cartable));
        _logger.LogInformation("{@OutputCartable}", _OutputCartable);

        return _OutputCartable;
    }
    public override Task<OutputCartable> Inbox(InputCartable request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Inbox);
    }
    public override Task<OutputCartable> Outbox(InputCartable request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Outbox);
    }
    public override Task<TableInfo> Sync(TableInfo request, ServerCallContext context)
    {
        TableInfo outputSync = new();
        //iSync.Syncing(request.TableName).GetAwaiter().GetResult();
        return Task.FromResult(outputSync);
    }
    public override async Task<TableInfo> GetAllByName(TableInfo request, ServerCallContext context)
    {
        TableInfo tableInfo = new();
        var TableRecords = await simpleClassRepository.GetAllByName(request.TableInput.Name);
        tableInfo.TableOutput.AddRange(
            TableRecords.Select(x => new GRPC_BaseClass()
            {
                Id = x.Id.Value,
                Name = x.Name,
                DisplayName = x.DisplayName,
                ERPCode = x.ERPCode.Value
            })
            );
        return tableInfo;
    }
}