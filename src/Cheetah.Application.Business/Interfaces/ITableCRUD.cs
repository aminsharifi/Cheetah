namespace Cheetah.Application.Business.Interfaces;
public interface ITableCRUD
{
    public Task<Int32> deleteAsync(string type, Int64? id);
    public Task<IEnumerable<BaseEntity>> GetAllByNameAsync(String type);

    public Task<Tuple<BaseEntity, IEnumerable<BaseEntity>>> GetAllBySimpleClassAsync(BaseEntity simpleClass);

    public Task<Dictionary<String, String>> GetAllTableNameAsync(String SchemaName);

    public Task<IEnumerable<SimpleLinkClass>> GetAllLinkAsync(String type, String sd_Status, Int64? linkID);
    public Task<BaseEntity> GetAsync(string type, Int64? id, Boolean Tracking = true);
    public Task<BaseEntity> GetAsync(string type, String? recordName, Boolean Tracking = true, params String[] TableIncludes);
    public Task<BaseEntity> GetLastAsync(string type);
    public Task<BaseEntity> CreateAsync(BaseEntity obj_DTO);
    public Task<BaseEntity> UpdateAsync(BaseEntity obj_DTO);
    public Task<Int32> UpdateLinkAsync(LinkClassDTO obj_DTO);
    public Task<DateTimeOffset?> GetLastUpdate(String TableName);
    public SimpleLinkClass AddLinkName(SimpleLinkClass simpleLinkClass, BaseEntity? firstClass, BaseEntity? SecondClass);
}