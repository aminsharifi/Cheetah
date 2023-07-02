using AutoMapper;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Repository;
using Cheetah_Business.Virtuals;
using Cheetah_GrpcService;
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
        public RequestService(ILogger<GreeterService> logger, ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }
        public override Task<OutputRequest> CreateRequest(InputRequest request, ServerCallContext context)
        {
            var f_Request = new Cheetah_Business.Facts.F_Request();

            f_Request.RQT_Creator = new D_User() { PName = request.RQTCreatorPName };
            f_Request.RQT_Requestor = new D_User() { PName = request.RQTRequestorPName };
            f_Request.RQT_Process = new D_Process() { PName = request.RQTProcessPName };
            f_Request.PERPCode = request.PERPCode;

            var CreatedRequest = simpleClassRepository.CreateRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var outputRequest = new OutputRequest()
            {
                Id = CreatedRequest.Id.Value
            };
            outputRequest.UserAssignments.AddRange(CreatedRequest.RQT_CurrentAssignment.PRM_UserAssignments.Select(x => new UserAssignment() { UAUserPName = x.UA_User.PName }));

            return Task.FromResult(outputRequest);
        }

        public override Task<OutputRequest> PerformRequest(InputRequest request, ServerCallContext context)
        {
            var tb1 = simpleClassRepository.GetAllTableName(nameof(Cheetah_Business.Dimentions))
                .GetAwaiter().GetResult();

            var helloReply = new OutputRequest()
            {
                //Message = tb1.First().Value + " " + request.Name
            };

            return Task.FromResult(helloReply);
        }
    }
}