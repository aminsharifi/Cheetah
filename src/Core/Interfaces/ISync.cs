using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Enums;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Interfaces;
public interface ISync
{
    public Task<Result<SimpleClassDTO>> SyncEntityAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records, CrudOperation Crud);
    public Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud);
    public Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud);
}
