using Newtonsoft.Json;
using Cheetah_Client.Service.IService;
using Cheetah_Models;
using Cheetah_Models.Parameters;

namespace Cheetah_Client.Service
{
    
    public class P_ParameterListService : IP_ParameterListService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        private string BaseServerUrl;
        public P_ParameterListService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration=configuration;
            BaseServerUrl = _configuration.GetSection("BaseServerUrl").Value;
        }

        public async Task<P_ParameterListDTO> Get(Int64 Id)
        {
            var response = await _httpClient.GetAsync($"/P_ParameterList/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var P_ParameterList = JsonConvert.DeserializeObject<P_ParameterListDTO>(content);
                //product.ImageUrl = BaseServerUrl+product.ImageUrl;
                return P_ParameterList;
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
                var p_ParameterList = JsonConvert.DeserializeObject<IEnumerable<P_ParameterListDTO>>(content);
                foreach(var prod in p_ParameterList)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }
                return p_ParameterList;
            }
            return new List<P_ParameterListDTO>();
        }
    }
}