using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Microsoft.EntityFrameworkCore;
namespace Cheetah_Business.Repository;

public interface ISimpleClassRepository
{
    public Task<Int32> delete(string type, Int64? id);
    public Task<IEnumerable<SimpleClass>> GetAllByName(String type);
    public Task<Dictionary<String, String>> GetAllTableName(String SchemaName);
    public Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, Int64? linkID);
    public Task<SimpleClass> Get(string type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll);
    public Task<SimpleClass> GetLast(string type);
    public Task<SimpleClass> Create(SimpleClass obj_DTO);
    public Task<Int32> Sync(String TableName);
    public Task<F_Case> PerformRequestAsync(F_Case request);
    public Task<F_Case> CreateRequestAsync(F_Case request);
    public Task<F_Case> GetCaseAsync(F_Case request);
    public Task<SimpleClass> Update(SimpleClass obj_DTO);
    public Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO);
    public Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass);
    public Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO);
    public Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO);
    public IQueryable<CartableDTO> GetCartable(CartableDTO cartableDTO,
        IQueryable<F_WorkItem> f_WorkItems);
}