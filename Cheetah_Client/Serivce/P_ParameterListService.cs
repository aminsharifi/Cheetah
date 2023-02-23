using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Parameters;
using Cheetah_Models;
using Newtonsoft.Json;

namespace Cheetah_Client.Service
{
    public class P_ParameterListService : IGeneralRepository<D_ParameterList>
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

        public async Task<D_ParameterList> Get(long RecordId)
        {
            var response = await _httpClient.GetAsync($"/P_ParameterList/{RecordId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<D_ParameterList>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public async Task<IEnumerable<D_ParameterList>> GetAll()
        {
            var response = await _httpClient.GetAsync("/P_ParameterList");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<D_ParameterList>>(content);
                foreach (var prod in ParameterLists)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }
                return ParameterLists;
            }
            return new List<D_ParameterList>();
        }

        public Task<D_ParameterList> Update(D_ParameterList obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<D_ParameterList> Create(D_ParameterList obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
