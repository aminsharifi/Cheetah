using Cheetah.Domain.Common;
using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Application.Business.Interfaces;
public interface ITableCRUD
{
    public Task<Int32> deleteAsync(string type, Int64? id);
    public Task<IEnumerable<BaseEntity>> GetAllByNameAsync(String type);
    public Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass);
    public Task<Dictionary<String, String>> GetAllTableNameAsync(String SchemaName);
    public Task<IEnumerable<BaseLink>> GetAllLinkAsync(String type, String sd_Status, Int64? linkID);
    public Task<BaseEntity> GetAsync(string type, Int64? id, Boolean Tracking = true);
    public Task<BaseEntity> GetAsync(string type, String? recordName, Boolean Tracking = true, params String[] TableIncludes);
    public Task<BaseEntity> GetLastAsync(string type);
    public Task<BaseEntity> CreateAsync(BaseEntity obj_DTO);
    public Task<BaseEntity> UpdateAsync(BaseEntity obj_DTO);
    public Task<Int32> UpdateLinkAsync(LinkStateClassDTO obj_DTO);
    public Task<DateTimeOffset?> GetLastUpdate(String TableName);
    public BaseLink AddLinkName(BaseLink simpleLinkClass, BaseEntity? firstClass, BaseEntity? SecondClass);
    Task<BaseEntity> GetAsync(long? RecordId);
}