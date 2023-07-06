using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
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
            var f_Request = new F_Request();

            f_Request.RQT_Creator = new D_User() { PName = request.CreatorPName };
            f_Request.RQT_Requestor = new D_User() { PName = request.RequestorPName };
            f_Request.RQT_Process = new D_Process() { PName = request.ProcessPName };
            f_Request.PERPCode = request.PERPCode;

            f_Request = simpleClassRepository.CreateRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request();

            output_Request.ProcessState = f_Request.RQT_ProcessState.PName;

            output_Request.Id = f_Request.Id.Value;

            return Task.FromResult(output_Request);
        }
        public override Task<Brief_Output_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Request();

            f_Request = simpleClassRepository.PerformRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request();

            output_Request.Id = f_Request.Id.Value;

            return Task.FromResult(output_Request);
        }
        public override Task<DetailOutput_Request> GetCase(GetCase_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Request();

            f_Request.Id = request.Id;

            if (request.PERPCode > 0)
                f_Request.PERPCode = request.PERPCode;

            if (!String.IsNullOrEmpty(request.ProcessName))
                f_Request.RQT_Process = _db.D_Processes.Single(x => x.PName == request.ProcessName);

            f_Request = simpleClassRepository.GetCaseAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new DetailOutput_Request();

            output_Request.Id = f_Request.Id.Value;

            output_Request.ProcessName = f_Request.RQT_Process.PName;

            output_Request.PERPCode = f_Request.PERPCode.Value;

            output_Request.ProcessState = f_Request.RQT_ProcessState.PName;

            output_Request.CurrentAssignments.AddRange(
                f_Request.RQT_CurrentAssignment.PRM_UserAssignments
                .Select(x => new GRPC_UserAssignment()
                {
                    Endorsement =
                    new GRPC_BaseClass()
                    {
                        Id = x.UA_Assignment.PRM_Endorsement.PIndex.Value,
                        PName = x.UA_Assignment.PRM_Endorsement.PName,
                        PDisplayName = x.UA_Assignment.PRM_Endorsement.PDisplayName
                    },
                    UserAssignment =
                    new GRPC_BaseClass()
                    {
                        Id = x.Id.Value,
                        PName = x.UA_User.PName
                    }
                }));

            output_Request.AllAssignments.AddRange(f_Request.RQT_Assignments
                .SelectMany(p => p.PRM_UserAssignments,
                (parent, child) => new GRPC_UserAssignment()
                {
                    UserAssignment =
                    new GRPC_BaseClass()
                    {
                        Id = child.Id.Value,
                        PName = child.UA_User.PName
                    },

                    Endorsement =
                    new GRPC_BaseClass()
                    {
                        Id = parent.PRM_Endorsement.PIndex.Value,
                        PName = parent.PRM_Endorsement.PName,
                        PDisplayName = parent.PRM_Endorsement.PDisplayName
                    }
                }));

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
                        DTag = (x.Tag is not null) ? new GRPC_BaseClass()
                        {
                            Id = x.Tag.Id.Value,
                            PName = x.Tag.PName,
                            PDisplayName = x.Tag.PDisplayName
                        } : new GRPC_BaseClass(),
                        RecieveDate = ((DateTimeOffset)x.RecieveDate).ToUnixTimeSeconds(),
                        PRecieveDate = x.PRecieveDate,
                        Summary = x.Summary ?? String.Empty,
                        ProcessName = x.ProcessName,
                        RadNumber = x.RadNumber,
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
    }
}