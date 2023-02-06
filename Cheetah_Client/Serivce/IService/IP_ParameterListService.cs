using Cheetah_Models.Parameters;

namespace Cheetah_Client.Service.IService
{
    public interface IP_ParameterListService
    {
        public Task<IEnumerable<P_ParameterListDTO>> GetAll();
        public Task<P_ParameterListDTO> Get(Int64 productId);
    }
}