using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Parameters;
using Cheetah_Models;
using Newtonsoft.Json;

namespace Cheetah_Client.Service
{
    public class D_ParameterTypeService : IGeneralRepository<D_ParameterType>
    {

        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        private string BaseServerUrl;
        public D_ParameterTypeService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            BaseServerUrl = _configuration.GetSection("BaseServerUrl").Value;
        }

        public async Task<D_ParameterType> Get(long? RecordId)
        {
            var response = await _httpClient.GetAsync($"/D_ParameterType/{RecordId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<D_ParameterType>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public async Task<IEnumerable<D_ParameterType>> GetAll()
        {
            var response = await _httpClient.GetAsync("/D_ParameterType");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<D_ParameterType>>(content);
                foreach (var prod in ParameterLists)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }
                return ParameterLists;
            }
            return new List<D_ParameterType>();
        }

        public Task<D_ParameterType> Update(D_ParameterType obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<D_ParameterType> Create(D_ParameterType obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetAllByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
