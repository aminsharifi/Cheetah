namespace Cheetah.Application.Business.Interfaces;
public interface ITableCRUD
{
    public Task<Int32> deleteAsync(string type, Int64? id);
    public Task<IEnumerable<SimpleClassDTO>> GetAllByNameAsync(String type);
    public Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass);
    public Task<Dictionary<String, String>> GetAllTableNameAsync(String SchemaName);
    public Task<IEnumerable<SimpleLinkClassDTO>> GetAllLinkAsync(String type, String sd_Status, Int64? linkID);
    public Task<SimpleClassDTO> GetAsync(string type, Int64? id, Boolean Tracking = true);
    public Task<SimpleClassDTO> GetAsync(string type, String? recordName, Boolean Tracking = true, params String[] TableIncludes);
    public Task<SimpleClassDTO> GetLastAsync(string type);
    public Task<SimpleClassDTO> CreateAsync(SimpleClassDTO obj_DTO);
    public Task<SimpleClassDTO> UpdateAsync(SimpleClassDTO obj_DTO);
    public Task<Int32> UpdateLinkAsync(LinkStateClassDTO obj_DTO);
    public Task<DateTimeOffset?> GetLastUpdate(String TableName);
    public SimpleLinkClassDTO AddLinkName(SimpleLinkClassDTO simpleLinkClass, SimpleClassDTO? firstClass, SimpleClassDTO? SecondClass);
}