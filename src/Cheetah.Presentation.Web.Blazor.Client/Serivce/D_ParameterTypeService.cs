using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Result;

namespace Cheetah.Presentation.Web.Blazor.Client.Service;

public class D_ParameterTypeService : ITableCRUD
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

    public async Task<SimpleClassDTO> GetAsync(long? RecordId)
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
            var errorModel = JsonConvert.DeserializeObject<CheetahResult>(content);
            throw new Exception(errorModel.SimpleClassDTO.DisplayName);
        }
    }

    public async Task<IEnumerable<D_TagType>> GetAllAsync()
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

    public async Task<IEnumerable<SimpleClassDTO>> GetAllByNameAsync(string Name)
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


    public async Task<SimpleClassDTO> GetAsyncAsync(string type, long? id, Boolean Tracking = true)
    {
        var response = await _httpClient.GetAsync($"/{type} /{id}");
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            var p_ParameterList = JsonConvert.DeserializeObject<SimpleClassDTO>(content);
            //product.ImageUrl=BaseServerUrl+product.ImageUrl;
            return p_ParameterList;
        }
        else
        {
            var errorModel = JsonConvert.DeserializeObject<CheetahResult>(content);
            throw new Exception(errorModel.SimpleClassDTO.DisplayName);
        }
    }

    public Task<int> deleteAsync(string type, long? id)
    {
        throw new NotImplementedException();
    }

    public Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass)
    {
        throw new NotImplementedException();
    }

    public Task<Dictionary<string, string>> GetAllTableNameAsync(string SchemaName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LinkSatetClass>> GetAllLinkAsync(string type, string sd_Status, long? linkID)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> GetAsync(string type, long? id, bool Tracking = true)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> GetAsync(string type, string? recordName, bool Tracking = true, params string[] TableIncludes)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> GetLastAsync(string type)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> CreateAsync(SimpleClassDTO obj_DTO)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> UpdateAsync(SimpleClassDTO obj_DTO)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateLinkAsync(LinkSatetClass obj_DTO)
    {
        throw new NotImplementedException();
    }

    public Task<DateTimeOffset?> GetLastUpdate(string TableName)
    {
        throw new NotImplementedException();
    }


    Task<IEnumerable<LinkSatetClass>> ITableCRUD.GetAllLinkAsync(string type, string sd_Status, long? linkID)
    {
        throw new NotImplementedException();
    }


    LinkSatetClass ITableCRUD.AddLinkName(LinkSatetClass simpleLinkClass, SimpleClassDTO? firstClass, SimpleClassDTO? SecondClass)
    {
        throw new NotImplementedException();
    }
}
