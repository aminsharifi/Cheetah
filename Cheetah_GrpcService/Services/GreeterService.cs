using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Grpc.Core;

namespace Cheetah_GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;

        public GreeterService(ILogger<GreeterService> logger, ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
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
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;
        protected ApplicationDbContext _db;
        public RequestService(ILogger<GreeterService> logger,
            ApplicationDbContext db,
            ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }

        public override Task<Brief_Output_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Case();

            f_Request.Creator = new() { Name = request.CreatorName };
            f_Request.Requestor = new() { Name = request.RequestorName };
            f_Request.Process = new() { Name = request.ProcessName };
            f_Request.ERPCode = request.ERPCode;

            f_Request = simpleClassRepository.CreateRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request();

            output_Request.ProcessState =
                new()
                {
                    Id = f_Request.CaseStateId.Value,
                    Name = f_Request.CaseState.Name,
                    DisplayName = f_Request.CaseState.DisplayName
                };

            output_Request.Id = f_Request.Id.Value;

            return Task.FromResult(output_Request);
        }
        public override Task<Brief_Output_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var F_WorkItem = _db.F_WorkItems.Single(x => x.Id == request.WorkItemId);
            var tagId = _db.D_Tags.Single(x => x.Name == request.TagName).Id;
            F_WorkItem.TagId = tagId;
            F_WorkItem.WorkItemStateId = 2;
            _db.Update(F_WorkItem);

            _db.SaveChangesAsync().GetAwaiter().GetResult();

            var f_Request = simpleClassRepository.PerformWorkItemAsync(F_WorkItem)
            .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request()
            {
                Id = f_Request.Id.Value,
                ProcessState = new GRPC_BaseClass()
                {
                    Id = f_Request.CaseStateId.Value,
                    Name = f_Request.CaseState.Name,
                    DisplayName = f_Request.CaseState.DisplayName
                }
            };

            return Task.FromResult(output_Request);
        }
        public override Task<DetailOutput_Request> GetCase(GetCase_Input_Request request, ServerCallContext context)
        {
            F_Case f_Request = new();

            f_Request.Id = request.Id;

            if (request.ERPCode > 0)
                f_Request.ERPCode = request.ERPCode;

            if (!String.IsNullOrEmpty(request.ProcessName))
                f_Request.Process = _db.D_Processes.Single(x => x.Name == request.ProcessName);

            f_Request = simpleClassRepository.GetCaseAsync(f_Request)
                .GetAwaiter().GetResult();

            DetailOutput_Request output_Request = new()
            {
                Id = f_Request.Id.Value,
                ProcessName = f_Request.Process.Name,
                ERPCode = f_Request.ERPCode.Value
            };

            output_Request.ProcessState =
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
        public Task<PageCartable> Cartable(PageCartable request, CartableProperty cartableProperty)
        {
            var cartableDTO = new CartableDTO()
            {
                Username = request.Username,
                ProcessName = request.ProcessName
            };

            var OutputRequest = (cartableProperty == CartableProperty.Inbox) ?
                simpleClassRepository.Inbox(cartableDTO).GetAwaiter().GetResult() :
                simpleClassRepository.Outbox(cartableDTO).GetAwaiter().GetResult();

            request.RecordCartables.AddRange(
                OutputRequest.Select(
                    x => new RecordCartable()
                    {
                        CreateDate = ((DateTimeOffset)x.CreateDate).ToUnixTimeSeconds(),
                        PCreateDate = x.PCreateDate,
                        DTag = (x.Tag is not null) ? new()
                        {
                            Id = x.Tag.Id.Value,
                            Name = x.Tag.Name,
                            DisplayName = x.Tag.DisplayName
                        } : new(),
                        RecieveDate = ((DateTimeOffset)x.RecieveDate).ToUnixTimeSeconds(),
                        PRecieveDate = x.PRecieveDate,
                        Summary = x.Summary ?? String.Empty,
                        ProcessName = x.ProcessName,
                        RadNumber = x.RadNumber,
                        WorkItemId = x.WorkItemId,
                        Requestor = x.Requestor,
                        TaskName = x.TaskName
                    }
                    )
                );

            return Task.FromResult(request);
        }
        public override Task<PageCartable> Inbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Inbox);
        }
        public override Task<PageCartable> Outbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Outbox);
        }
        public override Task<OutputSync> Sync(InputSync request, ServerCallContext context)
        {
            OutputSync outputSync = new();
            simpleClassRepository.Sync(request.TableName).GetAwaiter().GetResult();
            return Task.FromResult(outputSync);
        }
    }
}