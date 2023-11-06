namespace Cheetah.Application.Business.Repository;
public interface ITableCRUD
{
    public Task<Int32> delete(string type, Int64? id);
    public Task<IEnumerable<SimpleClass>> GetAllByName(String type);
    public Task<Dictionary<String, String>> GetAllTableName(String SchemaName);
    public Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, Int64? linkID);
    public Task<SimpleClass> Get(string type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll);
    public Task<SimpleClass> Get(string type, String? recordName,
        QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll, params String[] TableIncludes);
    public Task<SimpleClass> GetLast(string type);
    public Task<SimpleClass> Create(SimpleClass obj_DTO); 
    public Task<SimpleClass> Update(SimpleClass obj_DTO);
    public Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO);
    public Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass);
}