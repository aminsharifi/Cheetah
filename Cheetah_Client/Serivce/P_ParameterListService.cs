using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Parameters;
using Cheetah_Models;
using Newtonsoft.Json;

namespace Cheetah_Client.Service
{
    public class P_ParameterListService : IGeneralRepository<P_ParameterList>
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

        public async Task<P_ParameterList> Get(long RecordId)
        {
            var response = await _httpClient.GetAsync($"/P_ParameterList/{RecordId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<P_ParameterList>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public async Task<IEnumerable<P_ParameterList>> GetAll()
        {
            var response = await _httpClient.GetAsync("/P_ParameterList");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<P_ParameterList>>(content);
                foreach (var prod in ParameterLists)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }
                return ParameterLists;
            }
            return new List<P_ParameterList>();
        }

        public Task<P_ParameterList> Update(P_ParameterList obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<P_ParameterList> Create(P_ParameterList obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
