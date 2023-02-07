using Newtonsoft.Json;
using Cheetah_Models;
using Cheetah_Models.Parameters;
using Cheetah_Business.Repository.IRepository;

namespace Cheetah_Client.Service
{
    public class P_ParameterListService : IP_ParameterListRepository
    {

        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        private string BaseServerUrl;
        public P_ParameterListService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            BaseServerUrl = _configuration.GetSection("BaseServerUrl").Value;
        }

        public async Task<P_ParameterListDTO> Get(long RecordId)
        {
            var response = await _httpClient.GetAsync($"/P_ParameterList/{RecordId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<P_ParameterListDTO>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public async Task<IEnumerable<P_ParameterListDTO>> GetAll()
        {
            var response = await _httpClient.GetAsync("/P_ParameterList");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<P_ParameterListDTO>>(content);
                foreach (var prod in ParameterLists)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }
                return ParameterLists;
            }
            return new List<P_ParameterListDTO>();
        }

        public Task<P_ParameterListDTO> Update(P_ParameterListDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<P_ParameterListDTO> Create(P_ParameterListDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
