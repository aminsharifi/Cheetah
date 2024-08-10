using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;

namespace Cheetah.Core.Interfaces;
public interface ITableCRUD
{
    public Task<int> deleteAsync(string type, long? id);
    public Task<IEnumerable<BaseEntity>> GetAllByNameAsync(string type);
    public Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass);
    public Task<Dictionary<string, string>> GetAllTableNameAsync(string SchemaName);
    public Task<IEnumerable<BaseLink>> GetAllLinkAsync(string type, string sd_Status, long? linkID);
    public Task<BaseEntity> GetAsync(string type, long? id, bool Tracking = true);
    public Task<BaseEntity> GetAsync(string type, string? recordName, bool Tracking = true, params string[] TableIncludes);
    public Task<BaseEntity> GetLastAsync(string type);
    public Task<BaseEntity> CreateAsync(BaseEntity obj_DTO);
    public Task<BaseEntity> UpdateAsync(BaseEntity obj_DTO);
    public Task<int> UpdateLinkAsync(LinkStateClassDTO obj_DTO);
    public Task<DateTimeOffset?> GetLastUpdate(string TableName);
    public BaseLink AddLinkName(BaseLink simpleLinkClass, BaseEntity? firstClass, BaseEntity? SecondClass);
    Task<BaseEntity> GetAsync(long? RecordId);
}