using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Cheetah_GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly ITableCRUD _isimpleClassRepository;
        private readonly ICartable _iCartable;
        private readonly IMapper _imapper;
        private readonly ICopyClass _iCopyClass;

        public GreeterService(ILogger<GreeterService> logger,
            ITableCRUD iP_ParameterListRepository, IMapper mapper,
            ICartable iCartable, ICopyClass _iCopyClass)
        {
            _logger = logger;
            this._imapper = mapper;
            this._isimpleClassRepository = iP_ParameterListRepository;
            this._iCartable = iCartable;
            this._iCopyClass = _iCopyClass;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var helloReply = new HelloReply()
            {
                Message = "Hello " + request.Name
            };

            return Task.FromResult(helloReply);
        }
    }

    public class RequestService : Request.RequestBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly ITableCRUD simpleClassRepository;
        private readonly ICartable iCartable;
        private readonly ISync iSync;
        private readonly IView iView;
        private readonly IWorkItem iWorkItem;
        private readonly IMapper _mapper;
        private readonly ICopyClass _iCopyClass;
        protected ApplicationDbContext _db;
        public RequestService(ILogger<GreeterService> logger,
            ApplicationDbContext db,
            ITableCRUD iP_ParameterListRepository,
            ICartable _iCartable, ISync _iSync, IView _iView, IWorkItem _iWorkItem,
            IMapper mapper, ICopyClass _iCopyClass)
        {
            _logger = logger;
            _db = db;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
            this.iCartable = _iCartable;
            this.iSync = _iSync;
            this.iView = _iView;
            this.iWorkItem = _iWorkItem;
            this._iCopyClass = _iCopyClass;
        }

        public override async Task<Brief_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Case();

            f_Request.Creator = new()
            {
                Name = request.Creator.Name,
                ERPCode = request.Creator.ERPCode
            };

            f_Request.Requestor = new()
            {
                Name = request.Requestor.Name,
                ERPCode = request.Requestor.ERPCode
            };
            f_Request.Process = new()
            {
                Name = request.Process.Name,
                ERPCode = request.Process.ERPCode
            };

            f_Request.ERPCode = request.ERPCode;

            f_Request = await iWorkItem.CreateRequestAsync(f_Request);

            var output_Request = new Brief_Request();

            output_Request.CaseId = f_Request.Id.Value;

            output_Request.ERPCode = f_Request.ERPCode.Value;

            output_Request.Process =
            new()
            {
                Id = f_Request.Process.Id.Value,
                ERPCode = f_Request.Process.ERPCode.Value,
                Name = f_Request.Process.Name,
                DisplayName = f_Request.Process.DisplayName
            };

            output_Request.CaseState =
                new()
                {
                    Id = f_Request.CaseState.Id.Value,
                    ERPCode = f_Request.CaseState.ERPCode.Value,
                    Name = f_Request.CaseState.Name,
                    DisplayName = f_Request.CaseState.DisplayName
                };

            return output_Request;
        }
        public override async Task<Brief_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var f_WorkItem = new F_WorkItem();
            f_WorkItem.Id = request.WorkItemId;
            f_WorkItem.TagId = await _iCopyClass
                .GetSimpleClassId(_db.D_Tags, new D_Tag()
                {
                    Name = request.Tag.Name,
                    ERPCode = request.Tag.ERPCode
                });

            f_WorkItem = await iWorkItem.PerformWorkItemAsync(f_WorkItem);

            var output_Request = new Brief_Request()
            {
                CaseId = f_WorkItem.Case.Id.Value,
                CaseState = new GRPC_BaseClass()
                {
                    Id = f_WorkItem.Case.CaseStateId.Value,
                    ERPCode = f_WorkItem.Case.CaseState.ERPCode.Value,
                    Name = f_WorkItem.Case.CaseState.Name,
                    DisplayName = f_WorkItem.Case.CaseState.DisplayName
                },
                Process = new GRPC_BaseClass()
                {
                    Id = f_WorkItem.Case.Process.Id.Value,
                    ERPCode = f_WorkItem.Case.Process.ERPCode.Value,
                    Name = f_WorkItem.Case.Process.Name,
                    DisplayName = f_WorkItem.Case.Process.DisplayName
                },
                ERPCode = f_WorkItem.Case.ERPCode.Value
            };

            return output_Request;
        }
        public override Task<DetailOutput_Request> GetCase(Brief_Request request, ServerCallContext context)
        {
            F_Case f_Request = new();

            f_Request.Id = request.CaseId;

            if (request.ERPCode > 0)
                f_Request.ERPCode = request.ERPCode;

            if (request.Process is not null)
                f_Request.Process = _db.D_Processes.Single(x => x.Name == request.Process.Name);

            f_Request = iCartable.GetCaseAsync(f_Request)
                .GetAwaiter().GetResult();

            DetailOutput_Request output_Request = new()
            {
                Id = f_Request.Id.Value,
                Process = new GRPC_BaseClass() { Name = f_Request.Process.Name },
                ERPCode = f_Request.ERPCode.Value
            };

            output_Request.CaseState =
                new()
                {
                    Id = f_Request.CaseStateId.Value,
                    Name = f_Request.CaseState.Name,
                    DisplayName = f_Request.CaseState.DisplayName
                };

            var L_WorkItems = f_Request.WorkItems.ToList();

            output_Request.Assignments.AddRange(
                L_WorkItems.Select(x => x.Endorsement).Distinct()
                .Select(x => new GRPC_Assignment()
                {
                    Endorsement = new GRPC_BaseClass()
                    {
                        Id = x.Id.Value,
                        Name = x.Name,
                        DisplayName = x.DisplayName
                    }
                }));

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
                            User = new GRPC_BaseClass()
                            {
                                Id = x.UserId.Value,
                                Name = x.User.Name,
                                DisplayName = x.User.DisplayName
                            },
                            Tag = new GRPC_BaseClass()
                            {
                                Id = x.TagId ?? 0,
                                Name = x.Tag?.Name ?? String.Empty,
                                DisplayName = x.Tag?.DisplayName ?? String.Empty
                            },
                            WorkItemState = new GRPC_BaseClass()
                            {
                                Id = x.WorkItemStateId ?? 0,
                                Name = x.WorkItemState?.Name ?? String.Empty,
                                DisplayName = x.WorkItemState?.DisplayName ?? String.Empty
                            }
                        }
                        )
                    );
            }

            return Task.FromResult(output_Request);
        }
        public async Task<PageCartable> Cartable(PageCartable request, CartableProperty cartableProperty)
        {
            var cartableDTO = new CartableDTO()
            {
                Username = request.Assignee.Name,
                ProcessName = request.Process.Name,
                PageSize = request.PageSize,
                PageNumber = request.PageNumber,
                CaseState = (request.CaseState is null) ? new() : new SimpleClassDTO()
                {
                    ERPCode = request.CaseState.ERPCode,
                    Name = request.CaseState.Name,
                    DisplayName = request.CaseState.DisplayName
                }
            };

            var OutputRequest = (cartableProperty == CartableProperty.Inbox) ?
               await iCartable.Inbox(cartableDTO) :
               await iCartable.Outbox(cartableDTO);

            request.TotalItems = OutputRequest.FirstOrDefault().TotalItems.Value;

            request.RecordCartables.AddRange(
                 OutputRequest.Select(
                    x => new RecordCartable()
                    {
                        CreateDate = Timestamp.FromDateTime(
                            DateTime.SpecifyKind(
                            x.CreateDate.Value, DateTimeKind.Utc)),
                        CaseState = new GRPC_BaseClass()
                        {
                            ERPCode = x.CaseState.ERPCode.Value,
                            Name = x.CaseState.Name,
                            DisplayName = x.CaseState.DisplayName
                        },
                        DTag = (x.Tag != null) ? new()
                        {
                            Id = x.Tag.Id.Value,
                            Name = x.Tag.Name,
                            DisplayName = x.Tag.DisplayName
                        } : new(),
                        RecieveDate = Timestamp.FromDateTime
                        (DateTime.SpecifyKind(x.RecieveDate.Value, DateTimeKind.Utc)),
                        Summary = x.Summary ?? String.Empty,
                        Process = new GRPC_BaseClass() { Name = x.ProcessName },
                        CaseId = long.Parse(x.RadNumber),
                        WorkItemId = long.Parse(x.WorkItemId),
                        Requestor = new GRPC_BaseClass() { Name = x.Requestor },
                        Task = new GRPC_BaseClass() { Name = x.TaskName }
                    }
                    )
                );

            return request;
        }
        public override Task<PageCartable> Inbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Inbox);
        }
        public override Task<PageCartable> Outbox(PageCartable request, ServerCallContext context)
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
}