using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Cheetah_Client.Service
{
    public class D_ParameterTypeService : ISimpleClassRepository
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

        public async Task<SimpleClassDTO> Get(long? RecordId)
        {
            var response = await _httpClient.GetAsync($"/D_ParameterType/{RecordId}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<SimpleClassDTO>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public async Task<IEnumerable<D_TagType>> GetAll()
        {
            var response = await _httpClient.GetAsync("/D_ParameterType");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<D_TagType>>(content);
                foreach (var prod in ParameterLists)
                {
                    //prod.ImageUrl=BaseServerUrl+prod.ImageUrl;
                }

                return ParameterLists;
            }
            return new List<D_TagType>();
        }

        public Task<D_TagType> Update(D_TagType obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<D_TagType> Create(D_TagType obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SimpleClass>> GetAllByName(string Name)
        {
            var response = await _httpClient.GetAsync("/" + Name);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var ParameterLists = JsonConvert.DeserializeObject<IEnumerable<SimpleClassDTO>>(content);
                return ParameterLists;
            }
            return null;
        }

        public Task<int> delete(string type, long? id)
        {
            throw new NotImplementedException();
        }


        public Task<Dictionary<string, string>> GetAllTableName(string SchemaName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SimpleLinkClass>> GetAllLink(string type, string sd_Status, long? linkID)
        {
            throw new NotImplementedException();
        }


        public Task<SimpleClass> Create(SimpleClass? obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<SimpleClass> Update(SimpleClass? obj_DTO)
        {
            throw new NotImplementedException();
        }

        public async Task<SimpleClass> Get(string type, long? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll)
        {
            var response = await _httpClient.GetAsync($"/{type} /{id}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var p_ParameterList = JsonConvert.DeserializeObject<SimpleClass>(content);
                //product.ImageUrl=BaseServerUrl+product.ImageUrl;
                return p_ParameterList;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErorrMessage);
            }
        }

        public Task<int> UpdateLink(IEnumerable<SimpleLinkClassDTO> obj_DTO, string type, string sd_Status, long? linkID)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddLink(SimpleLinkClassDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveLink(SimpleLinkClassDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<SimpleClass> GetLast(string type)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateLink(SimpleLinkClassDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        public Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
        {
            throw new NotImplementedException();
        }

        Task<int> ISimpleClassRepository.delete(string type, long? id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<SimpleClass>> ISimpleClassRepository.GetAllByName(string type)
        {
            throw new NotImplementedException();
        }

        Task<Dictionary<string, string>> ISimpleClassRepository.GetAllTableName(string SchemaName)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<SimpleLinkClass>> ISimpleClassRepository.GetAllLink(string type, string sd_Status, long? linkID)
        {
            throw new NotImplementedException();
        }

      

        Task<SimpleClass> ISimpleClassRepository.GetLast(string type)
        {
            throw new NotImplementedException();
        }

        Task<SimpleClass> ISimpleClassRepository.Create(SimpleClass obj_DTO)
        {
            throw new NotImplementedException();
        }

        Task<SimpleClass> ISimpleClassRepository.Update(SimpleClass obj_DTO)
        {
            throw new NotImplementedException();
        }

        Task<int> ISimpleClassRepository.UpdateLink(SimpleLinkClassDTO obj_DTO)
        {
            throw new NotImplementedException();
        }

        Task<SimpleLinkClass> ISimpleClassRepository.AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
        {
            throw new NotImplementedException();
        }

        public Task<F_Request> PerformRequestAsync(F_Request request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO)
        {
            throw new NotImplementedException();
        }
    }
}
