namespace Cheetah.Application.Business.Interfaces;
public interface ITableCRUD
{
    public Task<Int32> delete(string type, Int64? id);
    public Task<IEnumerable<BaseEntity>> GetAllByName(String type);

    public Task<Tuple<BaseEntity, IEnumerable<BaseEntity>>> GetAllBySimpleClass(BaseEntity simpleClass);

    public Task<Dictionary<String, String>> GetAllTableName(String SchemaName);

    public Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, Int64? linkID);
    public Task<BaseEntity> Get(string type, Int64? id, Boolean Tracking = true);
    public Task<BaseEntity> Get(string type, String? recordName, Boolean Tracking = true, params String[] TableIncludes);
    public Task<BaseEntity> GetLast(string type);
    public Task<BaseEntity> Create(BaseEntity obj_DTO);
    public Task<BaseEntity> Update(BaseEntity obj_DTO);
    public Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO);
    public Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, BaseEntity? firstClass, BaseEntity? SecondClass);
}