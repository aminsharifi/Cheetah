using AutoMapper;
using Cheetah_Business.Repository;
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
}